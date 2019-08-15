using NetBLog.Service.Interfaces;
using NetBLog.Repository.Interfaces;
using NetBLog.Contract;
using System.Collections.Generic;
using AutoMapper;
using System.Linq;
using NetBLog.Entity;

namespace NetBLog.Service.Implementation
{
    public class BlogService : IBlogService
    {
        private readonly IMapper _mapper;
        private readonly IBlogRepository _blogRepository;
        public BlogService(IMapper mapper, IBlogRepository blogRepository)
        {
            _mapper = mapper;
            _blogRepository = blogRepository;
        }

        public BlogContract Add(BlogContract contract)
        {
            return _mapper.Map<BlogContract>(
                _blogRepository.Add(_mapper.Map<Blog>(contract)));
        }

        public IEnumerable<BlogContract> List(DataFilterContract contract)
        {
            var query = _blogRepository.Find(x => x.ActivatedAt.HasValue);

            if (!string.IsNullOrWhiteSpace(contract.Search))
                query = query.Where(x => x.Title.Contains(contract.Search));

            query = query.OrderByDescending(x => x.CreatedAt).Skip(contract.Page - 1 * contract.RecordCount).Take(contract.RecordCount);

            return _mapper.Map<IEnumerable<BlogContract>>(query);
        }
    }
}
