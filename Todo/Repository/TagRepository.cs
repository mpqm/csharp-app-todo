using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Entity;
using Todo.DB;

namespace Todo.Repository
{
    public class TagRepository
    {
        public List<Tag> SelectTagList()
        {
            var tags = new List<Tag>();
            using var conn = DBConnection.GetConnection();
            using var cmd = new SQLiteCommand("SELECT * FROM TB_Tag", conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                tags.Add(new Tag
                {
                    tagId = Convert.ToInt32(reader["tagId"]),
                    name = reader["name"].ToString(),
                    createdAt = Convert.ToDateTime(reader["createdAt"]),
                    updatedAt = reader["updatedAt"] as DateTime?
                });
            }
            return tags;
        }

        public List<Tag> SelectTagPage(string name, int page, int pageSize)
        {
            var tags = new List<Tag>();
            int offset = (page - 1) * pageSize;

            using var conn = DBConnection.GetConnection();
            using var cmd = new SQLiteCommand(@"
            SELECT * FROM TB_Tag
            WHERE name LIKE @name
            ORDER BY createdAt DESC
            LIMIT @limit OFFSET @offset", conn);

            cmd.Parameters.AddWithValue("@search", $"%{name}%");
            cmd.Parameters.AddWithValue("@limit", pageSize);
            cmd.Parameters.AddWithValue("@offset", offset);

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                tags.Add(new Tag
                {
                    tagId = Convert.ToInt32(reader["tagId"]),
                    name = reader["name"].ToString(),
                    createdAt = Convert.ToDateTime(reader["createdAt"]),
                    updatedAt = reader["updatedAt"] as DateTime?
                });
            }

            return tags;
        }

        public int CountTag(string name)
        {
            using var conn = DBConnection.GetConnection();
            using var cmd = new SQLiteCommand("SELECT COUNT(*) FROM TB_Tag WHERE name LIKE @name", conn);
            cmd.Parameters.AddWithValue("@name", $"%{name}%");

            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public void InsertTag(Tag tag)
        {
            using var conn = DBConnection.GetConnection();
            using var cmd = new SQLiteCommand("INSERT INTO TB_Tag (name, createdAt) VALUES (@name, @createdAt)", conn);
            cmd.Parameters.AddWithValue("@name", tag.name);
            cmd.Parameters.AddWithValue("@createdAt", tag.createdAt);
            cmd.ExecuteNonQuery();
        }

        public void UpdateTag(Tag tag)
        {
            using var conn = DBConnection.GetConnection();
            using var cmd = new SQLiteCommand("UPDATE TB_Tag SET name = @name, updatedAt = @updatedAt WHERE tagId = @tagId", conn);
            cmd.Parameters.AddWithValue("@tagId", tag.tagId);
            cmd.Parameters.AddWithValue("@name", tag.name);
            cmd.Parameters.AddWithValue("@updatedAt", tag.updatedAt ?? DateTime.Now);
            cmd.ExecuteNonQuery();
        }

        public void DeleteTag(int tagId)
        {
            using var conn = DBConnection.GetConnection();
            using var cmd = new SQLiteCommand("DELETE FROM TB_Tag WHERE tagId = @tagId", conn);
            cmd.Parameters.AddWithValue("@tagId", tagId);
            cmd.ExecuteNonQuery();
        }
    }
}
