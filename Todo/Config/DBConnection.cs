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
                -- 태그
                CREATE TABLE IF NOT EXISTS Tag (
                    TagId INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL UNIQUE,
                    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
                    UpdatedAt DATETIME
                );

                -- 카테고리
                CREATE TABLE IF NOT EXISTS Categories (
                    CategoryId INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
                    UpdatedAt DATETIME
                );

                -- 일정
                CREATE TABLE IF NOT EXISTS Task (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Title TEXT NOT NULL,
                    Description TEXT,
                    DueDate DATETIME,
                    Priority INTEGER,
                    IsCompleted BOOLEAN DEFAULT 0,
                    CategoryId INTEGER,
                    TagId INTEGER,
                    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
                    UpdatedAt DATETIME
                );

                -- 반복 일정 테이블
                CREATE TABLE IF NOT EXISTS RecurrenceTask (
                    RecurrenceTaskID INTEGER PRIMARY KEY AUTOINCREMENT,
                    TaskId INTEGER NOT NULL,
                    Frequency TEXT NOT NULL, -- daily, weekly, monthly, yearly 등
                    Interval INTEGER DEFAULT 1, -- 반복 간격 (예: 2면 2주마다)
                    EndDate DATETIME
                );

                -- 알림 테이블
                CREATE TABLE IF NOT EXISTS Notifications (
                    NotificationID INTEGER PRIMARY KEY AUTOINCREMENT,
                    TaskId INTEGER NOT NULL,
                    IsSent BOOLEAN DEFAULT 0,
                    NotifyAt DATETIME NOT NULL
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
