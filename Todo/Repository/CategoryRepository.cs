﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Todo.Entity;
using Todo.DB;

namespace Todo.Repository
{
    public class CategoryRepository
    {
        public List<Entity.Category> SelectAll()
        {
            var list = new List<Entity.Category>();
            using var conn = DBConnection.GetConnection();
            using var cmd = new SQLiteCommand("SELECT * FROM TB_Category", conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Entity.Category
                {
                    categoryId = Convert.ToInt32(reader["categoryId"]),
                    name = reader["name"].ToString(),
                    createdAt = Convert.ToDateTime(reader["createdAt"]),
                    updatedAt = reader["updatedAt"] as DateTime?
                });
            }
            return list;
        }

        public void Insert(Entity.Category category)
        {
            using var conn = DBConnection.GetConnection();
            using var cmd = new SQLiteCommand("INSERT INTO TB_Category (name, createdAt) VALUES (@name, @createdAt)", conn);
            cmd.Parameters.AddWithValue("@name", category.name);
            cmd.Parameters.AddWithValue("@createdAt", category.createdAt);
            cmd.ExecuteNonQuery();
        }

        public void Update(Entity.Category category)
        {
            using var conn = DBConnection.GetConnection();
            using var cmd = new SQLiteCommand("UPDATE TB_Category SET name = @name, updatedAt = @updatedAt WHERE categoryId = @categoryId", conn);
            cmd.Parameters.AddWithValue("@categoryId", category.categoryId);
            cmd.Parameters.AddWithValue("@name", category.name);
            cmd.Parameters.AddWithValue("@updatedAt", category.updatedAt ?? DateTime.Now);
            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var conn = DBConnection.GetConnection();
            using var cmd = new SQLiteCommand("DELETE FROM TB_Category WHERE categoryId = @categoryId", conn);
            cmd.Parameters.AddWithValue("@categoryId", id);
            cmd.ExecuteNonQuery();
        }
    }
}
