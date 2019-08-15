using NetBLog.Domain.ModelOptions;
using System;
using System.Collections.Generic;

namespace NetBLog.Domain.Models
{
    public class Category : IEntity<int>, ISoftDelete
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<Blog> Blogs { get; set; }
    }
}
