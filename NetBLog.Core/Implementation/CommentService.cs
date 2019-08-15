using AutoMapper;
using NetBLog.Contract;
using NetBLog.Entity;
using NetBLog.Repository.Interfaces;
using NetBLog.Service.Interfaces;
using System.Collections.Generic;

namespace NetBLog.Service.Implementation
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IMapper _mapper;
        public CommentService(ICommentRepository commentRepository, IMapper mapper)
        {
            _commentRepository = commentRepository;
            _mapper = mapper;
        }

        public CommentContract Add(CommentContract contract)
        {
            return _mapper.Map<CommentContract>(
                _commentRepository.Add(_mapper.Map<Comment>(contract)));
        }

        public void Delete(int id)
        {
            _commentRepository.Delete(id);
        }

        public IEnumerable<CommentContract> GetByBlogId(int blogId)
        {
            var data = _commentRepository.Find(x => x.BlogId == blogId);
            return _mapper.Map<IEnumerable<CommentContract>>(data);
        }
    }
}
