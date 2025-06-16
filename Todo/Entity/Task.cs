using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todo.Entity
{
    internal class Task
    {
        public int taskId { get; set; }                   // 할 일 고유 ID
        public string title { get; set; }             // 제목
        public string description { get; set; }       // 상세 설명
        public DateTime? dueDate { get; set; }        // 마감일

        public int priority { get; set; }             // 우선순위 (0: 낮음 ~ 높은 숫자)
        public bool isCompleted { get; set; }         // 완료 여부

        public int? categoryId { get; set; }          // 연결된 카테고리 ID
        public int? tagId { get; set; }               // 연결된 태그 ID

        public string frequency { get; set; }         // 반복 주기 (daily, weekly, monthly 등)
        public int interval { get; set; }             // 반복 간격 (예: 1이면 매주, 2면 2주 간격)
        public DateTime? endDate { get; set; }        // 반복 종료일

        public DateTime createdAt { get; set; }       // 생성일
        public DateTime? updatedAt { get; set; }      // 수정일
    }
}
