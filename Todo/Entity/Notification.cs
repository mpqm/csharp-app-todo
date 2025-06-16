using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todo.Entity
{
    internal class Notification
    {
        public int notificationID { get; set; }       // 알림 고유 ID
        public int taskId { get; set; }               // 연결된 Task ID
        public bool isSent { get; set; }              // 발송 여부
        public DateTime notifyAt { get; set; }        // 알림 예정 시간
    }
}
