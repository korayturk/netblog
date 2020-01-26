using NetBLog.Entity.TableOptions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetBLog.Entity
{
    public class Blog : IEntity<int>, ISoftDelete, IActivatable, IModifiable
    {
        public Blog()
        {
            Comments = new HashSet<Comment>();
        }

        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public bool AllowWriteComment { get; set; }
        public bool ShowComment { get; set; }
        public string Tags { get; set; }
        public int LanguageId { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? ActivatedAt { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
