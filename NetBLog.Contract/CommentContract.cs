using System;
using System.Collections.Generic;

namespace NetBLog.Contract
{
    public class CommentContract
    {
        public CommentContract()
        {
            Children = new List<CommentContract>();
        }

        public int Id { get; set; }
        public int BlogId { get; set; }
        public int? ParentId { get; set; }
        public DateTime Date { get; set; }
        public string Author { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }

        public BlogContract Blog { get; set; }

        public CommentContract Parent { get; set; }

        public List<CommentContract> Children { get; set; }
    }
}
