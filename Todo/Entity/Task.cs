using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Entity
{
    public class Task
    {
        public int taskId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public DateTime? dueDate { get; set; }
        public int priority { get; set; }
        public bool isCompleted { get; set; }
        public int? categoryId { get; set; }
        public int? tagId { get; set; }
        public string frequency { get; set; }
        public int interval { get; set; }
        public DateTime? endDate { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? updatedAt { get; set; }
    }
}
