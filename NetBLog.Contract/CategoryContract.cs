using System;
using System.Collections.Generic;

namespace NetBLog.Contract
{
    public class CategoryContract
    {
        public CategoryContract()
        {
            SubCategories = new List<CategoryContract>();
            Blogs = new List<BlogContract>();
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

        public CategoryContract Parent { get; set; }
        public List<CategoryContract> SubCategories { get; set; }

        public List<BlogContract> Blogs { get; set; }
    }
}
