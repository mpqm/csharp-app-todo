using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Entity
{
    public class Tag
    {
        public int tagId { get; set; }                // 태그 고유 ID
        public string name { get; set; }              // 태그 이름
        public DateTime createdAt { get; set; }       // 생성일
        public DateTime? updatedAt { get; set; }      // 수정일
    }
}
