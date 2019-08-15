using NetBLog.Service.Interfaces;
using NetBLog.Repository.Interfaces;
using NetBLog.Contract;
using System.Collections.Generic;
using AutoMapper;

namespace NetBLog.Service.Implementation
{
    public class CategoryService : ICategoryService
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(IMapper mapper, ICategoryRepository categoryRepository)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }

        public IEnumerable<CategoryContract> GetAll()
        {
            var data = _categoryRepository.GetAll();
            return _mapper.Map<IEnumerable<CategoryContract>>(data);
        }
    }
}
