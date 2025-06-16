using System;
using System.Data.SQLite;
using System.IO;
using System.Threading;

namespace Todo.DB
{
    public static class DBConnection
    {
        private static readonly string projectRoot = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName; // Made static and readonly
        private static readonly string dbFilePath = Path.Combine(projectRoot, "todo.db"); // Made readonly
        private static readonly string connectionString = $"Data Source={dbFilePath};"; // Made readonly
        private static SQLiteConnection sqliteConnection;
        private static readonly object _lock = new object();

        public static SQLiteConnection GetConnection()
        {
            lock (_lock)
            {
                if (sqliteConnection == null || sqliteConnection.State != System.Data.ConnectionState.Open)
                {
                    if (sqliteConnection != null)
                    {
                        try
                        {
                            sqliteConnection.Dispose();
                        }
                        catch (Exception ex)
                        {
                            throw new Exception($"DB 연결 해제 중 오류 발생: {ex.Message}", ex);
                        }
                    }

                    sqliteConnection = new SQLiteConnection(connectionString);
                    sqliteConnection.Open();
                }
                return sqliteConnection;
            }
        }

        public static void CloseConnection()
        {
            lock (_lock)
            {
                if (sqliteConnection != null && sqliteConnection.State == System.Data.ConnectionState.Open)
                {
                    try
                    {
                        sqliteConnection.Close();
                        sqliteConnection.Dispose();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"DB 연결 종료 중 오류 발생: {ex.Message}", ex);
                    }
                    finally
                    {
                        sqliteConnection = null;
                    }
                }
            }
        }

        public static void Initialize()
        {
            if (!File.Exists(dbFilePath)) // Corrected variable name
            {
                SQLiteConnection.CreateFile(dbFilePath); // Corrected variable name
            }

            using (var conn = GetConnection())
            {
                var sql = @"
                -- 🏷️ 태그 테이블: 할 일에 태그를 붙일 때 사용
                CREATE TABLE IF NOT EXISTS Tag (
                    tagId INTEGER PRIMARY KEY AUTOINCREMENT,         -- 태그 ID (기본 키)
                    name TEXT NOT NULL UNIQUE,                       -- 태그 이름 (중복 불가)
                    createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,    -- 생성 시간
                    updatedAt DATETIME                               -- 수정 시간
                );

                -- 🗂️ 카테고리 테이블: 할 일을 카테고리로 분류
                CREATE TABLE IF NOT EXISTS Categories (
                    categoryId INTEGER PRIMARY KEY AUTOINCREMENT,    -- 카테고리 ID (기본 키)
                    name TEXT NOT NULL,                              -- 카테고리 이름
                    createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,    -- 생성 시간
                    updatedAt DATETIME                               -- 수정 시간
                );

                -- 📅 할 일(Task) 테이블: 일정 및 반복 기능 포함
                CREATE TABLE IF NOT EXISTS Task (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,            -- 할 일 ID (기본 키)
                    title TEXT NOT NULL,                             -- 제목
                    description TEXT,                                -- 상세 설명
                    dueDate DATETIME,                                -- 마감일
                    priority INTEGER,                                -- 우선순위
                    isCompleted BOOLEAN DEFAULT 0,                   -- 완료 여부
                    categoryId INTEGER,                              -- 카테고리 ID (외래키 없음)
                    tagId INTEGER,                                   -- 태그 ID (외래키 없음)
                    frequency TEXT,                                  -- 반복 주기 (예: daily, weekly)
                    interval INTEGER DEFAULT 1,                      -- 반복 간격
                    endDate DATETIME,                                -- 반복 종료일
                    createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,    -- 생성 시간
                    updatedAt DATETIME                               -- 수정 시간
                );

                -- 🔔 알림 테이블: 할 일 알림 예약 정보
                CREATE TABLE IF NOT EXISTS Notifications (
                    notificationID INTEGER PRIMARY KEY AUTOINCREMENT, -- 알림 ID (기본 키)
                    taskId INTEGER NOT NULL,                          -- 연결된 할 일 ID (외래키 없음)
                    isSent BOOLEAN DEFAULT 0,                         -- 알림 발송 여부
                    notifyAt DATETIME NOT NULL                        -- 알림 예정 시간
                );

                ";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
