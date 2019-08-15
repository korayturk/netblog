using AutoMapper;
using NetBLog.Contract;
using NetBLog.Entity;

namespace NetBLog.Service.Configuration
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<CategoryContract, Category>().ReverseMap();
            CreateMap<UserContract, User>().ReverseMap();
            CreateMap<CommentContract, Comment>().ReverseMap();
            CreateMap<BlogContract, Blog>().ReverseMap();
        }
    }
}
