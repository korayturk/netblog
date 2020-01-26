using Microsoft.EntityFrameworkCore;
using NetBLog.Repository.Interfaces;
using NetBLog.Entity;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace NetBLog.Repository.Implementation
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly DbContext _context;
        public CategoryRepository(DbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Category>> GetForTopMenu(int languageId)
        {
            return await _context.Set<Category>().Include(x => x.SubCategories).Where(x => x.LanguageId == languageId).OrderBy(x => x.Order).ToListAsync();
        }
    }
}
