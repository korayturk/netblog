using NetBLog.Entity.TableOptions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetBLog.Entity
{
    public class Category : IEntity<int>, ISoftDelete
    {
        public Category()
        {
            Children = new HashSet<Category>();
            Blogs = new HashSet<Blog>();
        }

        public int Id { get; set; }

        public int? ParentId { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? DeletedAt { get; set; }

        [ForeignKey("ParentId")]
        public virtual Category Parent { get; set; }
        public virtual ICollection<Category> Children { get; set; }

        public virtual ICollection<Blog> Blogs { get; set; }
    }
}
