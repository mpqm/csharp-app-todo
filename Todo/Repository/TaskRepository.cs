using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Todo.DB;
using Todo.Entity;
namespace Todo.Repository
{
    public class TaskRepository
    {
        public List<Task> SelectTaskList()
        {
            var tasks = new List<Task>();
            using var conn = DBConnection.GetConnection();
            using var cmd = new SQLiteCommand("SELECT * FROM TB_Task", conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                tasks.Add(new Task
                {
                    taskId = Convert.ToInt32(reader["taskId"]),
                    title = reader["title"].ToString(),
                    description = reader["description"].ToString(),
                    dueDate = reader["dueDate"] as DateTime?,
                    priority = Convert.ToInt32(reader["priority"]),
                    isCompleted = Convert.ToBoolean(reader["isCompleted"]),
                    categoryId = reader["categoryId"] as int?,
                    tagId = reader["tagId"] as int?,
                    frequency = reader["frequency"]?.ToString(),
                    interval = reader["interval"] != DBNull.Value ? Convert.ToInt32(reader["interval"]) : 0,
                    endDate = reader["endDate"] as DateTime?,
                    createdAt = Convert.ToDateTime(reader["createdAt"]),
                    updatedAt = reader["updatedAt"] as DateTime?
                });
            }
            return tasks;
        }

        public void InsertTask(Task task)
        {
            using var conn = DBConnection.GetConnection();
            using var cmd = new SQLiteCommand(@"
            INSERT INTO TB_Task (title, description, dueDate, priority, isCompleted, categoryId, tagId, frequency, interval, endDate, createdAt, updatedAt)
            VALUES (@title, @description, @dueDate, @priority, @isCompleted, @categoryId, @tagId, @frequency, @interval, @endDate, @createdAt, @updatedAt)", conn);

            cmd.Parameters.AddWithValue("@title", task.title);
            cmd.Parameters.AddWithValue("@description", task.description);
            cmd.Parameters.AddWithValue("@dueDate", (object?)task.dueDate ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@priority", task.priority);
            cmd.Parameters.AddWithValue("@isCompleted", task.isCompleted);
            cmd.Parameters.AddWithValue("@categoryId", (object?)task.categoryId ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@tagId", (object?)task.tagId ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@frequency", (object?)task.frequency ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@interval", task.interval);
            cmd.Parameters.AddWithValue("@endDate", (object?)task.endDate ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@createdAt", task.createdAt);
            cmd.Parameters.AddWithValue("@updatedAt", (object?)task.updatedAt ?? DBNull.Value);

            cmd.ExecuteNonQuery();
        }

        public void UpdateTask(Task task)
        {
            using var conn = DBConnection.GetConnection();
            using var cmd = new SQLiteCommand(@"
            UPDATE TB_Task SET
                title = @title,
                description = @description,
                dueDate = @dueDate,
                priority = @priority,
                isCompleted = @isCompleted,
                categoryId = @categoryId,
                tagId = @tagId,
                frequency = @frequency,
                interval = @interval,
                endDate = @endDate,
                updatedAt = @updatedAt
            WHERE taskId = @taskId", conn);

            cmd.Parameters.AddWithValue("@taskId", task.taskId);
            cmd.Parameters.AddWithValue("@title", task.title);
            cmd.Parameters.AddWithValue("@description", task.description);
            cmd.Parameters.AddWithValue("@dueDate", (object?)task.dueDate ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@priority", task.priority);
            cmd.Parameters.AddWithValue("@isCompleted", task.isCompleted);
            cmd.Parameters.AddWithValue("@categoryId", (object?)task.categoryId ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@tagId", (object?)task.tagId ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@frequency", (object?)task.frequency ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@interval", task.interval);
            cmd.Parameters.AddWithValue("@endDate", (object?)task.endDate ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@updatedAt", task.updatedAt ?? DateTime.Now);

            cmd.ExecuteNonQuery();
        }

        public void DeleteTask(int taskId)
        {
            using var conn = DBConnection.GetConnection();
            using var cmd = new SQLiteCommand("DELETE FROM TB_Task WHERE taskId = @taskId", conn);
            cmd.Parameters.AddWithValue("@taskId", taskId);
            cmd.ExecuteNonQuery();
        }
    }
}
