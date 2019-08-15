using System;
using System.Collections.Generic;

namespace NetBLog.Contract
{
    public class BlogContract
    {
        public BlogContract()
        {
            Comments = new List<CommentContract>();
        }

        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public bool AllowWriteComment { get; set; }
        public bool ShowComment { get; set; }
        public string Tags { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? ActivatedAt { get; set; }

        public CategoryContract Category { get; set; }

        public List<CommentContract> Comments { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
