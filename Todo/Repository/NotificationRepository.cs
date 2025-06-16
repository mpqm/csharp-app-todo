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
    public class NotificationRepository
    {
        public List<Notification> SelectNotificationList()
        {
            var list = new List<Notification>();
            using var conn = DBConnection.GetConnection();
            using var cmd = new SQLiteCommand("SELECT * FROM TB_Notification", conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Notification
                {
                    notificationId = Convert.ToInt32(reader["notificationId"]),
                    taskId = Convert.ToInt32(reader["taskId"]),
                    isSent = Convert.ToBoolean(reader["isSent"]),
                    notifyAt = Convert.ToDateTime(reader["notifyAt"])
                });
            }
            return list;
        }

        public void InsertNotification(Notification notification)
        {
            using var conn = DBConnection.GetConnection();
            using var cmd = new SQLiteCommand("INSERT INTO TB_Notification (taskId, isSent, notifyAt) VALUES (@taskId, @isSent, @notifyAt)", conn);
            cmd.Parameters.AddWithValue("@taskId", notification.taskId);
            cmd.Parameters.AddWithValue("@isSent", notification.isSent);
            cmd.Parameters.AddWithValue("@notifyAt", notification.notifyAt);
            cmd.ExecuteNonQuery();
        }

        public void UpdateNotification(Notification notification)
        {
            using var conn = DBConnection.GetConnection();
            using var cmd = new SQLiteCommand("UPDATE TB_Notification SET taskId = @taskId, isSent = @isSent, notifyAt = @notifyAt WHERE notificationId = @notificationId", conn);
            cmd.Parameters.AddWithValue("@notificationId", notification.notificationId);
            cmd.Parameters.AddWithValue("@taskId", notification.taskId);
            cmd.Parameters.AddWithValue("@isSent", notification.isSent);
            cmd.Parameters.AddWithValue("@notifyAt", notification.notifyAt);
            cmd.ExecuteNonQuery();
        }

        public void DeleteNotification(int id)
        {
            using var conn = DBConnection.GetConnection();
            using var cmd = new SQLiteCommand("DELETE FROM TB_Notification WHERE notificationId = @notificationId", conn);
            cmd.Parameters.AddWithValue("@notificationId", id);
            cmd.ExecuteNonQuery();
        }
    }
}
