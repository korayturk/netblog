using AutoMapper;
using NetBLog.Contract;
using NetBLog.Entity;
using NetBLog.Repository.Interfaces;
using NetBLog.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetBLog.Service.Implementation
{
    public class CommentService : ServiceBase, ICommentService
    {
        private readonly ICommentRepository _commentRepository;
        public CommentService(ICommentRepository commentRepository, IMapper mapper) : base(mapper)
        {
            _commentRepository = commentRepository;
        }

        public async Task<CommentContract> Add(CommentContract contract)
        {
            var data = await _commentRepository.Add(Mapper.Map<Comment>(contract));
            return Mapper.Map<CommentContract>(data);
        }

        public async Task Delete(int id)
        {
            await _commentRepository.Delete(id);
        }

        public async Task<IEnumerable<CommentContract>> GetByBlogId(int blogId)
        {
            var data = await _commentRepository.Find(x => x.BlogId == blogId);
            return Mapper.Map<IEnumerable<CommentContract>>(data);
        }
    }
}
