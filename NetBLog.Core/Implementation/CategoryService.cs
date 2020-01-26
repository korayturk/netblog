using NetBLog.Service.Interfaces;
using NetBLog.Repository.Interfaces;
using NetBLog.Contract;
using System.Collections.Generic;
using AutoMapper;
using System.Threading.Tasks;
using System.Linq;

namespace NetBLog.Service.Implementation
{
    public class CategoryService : ServiceBase, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(IMapper mapper, ICategoryRepository categoryRepository) : base(mapper)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<CategoryContract>> GetForTopMenu(int languageId)
        {
            var data = await _categoryRepository.GetForTopMenu(languageId);
            return Mapper.Map<IEnumerable<CategoryContract>>(data.OrderBy(x => x.Order));
        }
    }
}
