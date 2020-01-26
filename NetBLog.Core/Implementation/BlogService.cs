using NetBLog.Service.Interfaces;
using NetBLog.Repository.Interfaces;
using NetBLog.Contract;
using System.Collections.Generic;
using System.Linq;
using NetBLog.Entity;
using System.Threading.Tasks;
using AutoMapper;

namespace NetBLog.Service.Implementation
{
    public class BlogService : ServiceBase, IBlogService
    {
        private readonly IBlogRepository _blogRepository;
        public BlogService(IMapper mapper, IBlogRepository blogRepository) : base(mapper)
        {
            _blogRepository = blogRepository;
        }

        public async Task<BlogContract> Add(BlogContract contract)
        {
            return Mapper.Map<BlogContract>(
                _blogRepository.Add(Mapper.Map<Blog>(contract)));
        }

        public async Task<IEnumerable<BlogContract>> List(DataFilterContract contract)
        {
            var query = await _blogRepository.Find(x => x.ActivatedAt.HasValue);

            if (!string.IsNullOrWhiteSpace(contract.Search))
                query = query.Where(x => x.Title.Contains(contract.Search));

            query = query.OrderByDescending(x => x.CreatedAt).Skip(contract.Page - 1 * contract.RecordCount).Take(contract.RecordCount);

            return Mapper.Map<IEnumerable<BlogContract>>(query);
        }
    }
}
