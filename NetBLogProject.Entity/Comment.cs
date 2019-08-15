using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetBLog.Entity
{
    public class Comment : IEntity<int>
    {
        public Comment()
        {
            Children = new HashSet<Comment>();
        }
        public int Id { get; set; }
        public int BlogId { get; set; }
        public int? ParentId { get; set; }
        public DateTime Date { get; set; }
        public string Author { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }

        [ForeignKey("BlogId")]
        public Blog Blog { get; set; }

        [ForeignKey("ParentId")]
        public Comment Parent { get; set; }

        public virtual ICollection<Comment> Children { get; set; }
    }
}
