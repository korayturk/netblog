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
            SubCategories = new HashSet<Category>();
            Blogs = new HashSet<Blog>();
        }

        public int Id { get; set; }

        public int? ParentId { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public int LanguageId { get; set; }
        public string Icon { get; set; }
        public int Order { get; set; }
        public string Url { get; set; }
        public DateTime? DeletedAt { get; set; }

        [ForeignKey("ParentId")]
        public virtual Category Parent { get; set; }
        public virtual ICollection<Category> SubCategories { get; set; }

        public virtual ICollection<Blog> Blogs { get; set; }
    }
}
