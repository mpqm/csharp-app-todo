using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Entity
{
    public class Category
    {
        public int categoryId { get; set; }           // 카테고리 고유 ID
        public string name { get; set; }              // 카테고리 이름
        public DateTime createdAt { get; set; }       // 생성일
        public DateTime? updatedAt { get; set; }      // 수정일
    }
}
