using AutoMapper;
using NetBLog.Service.Interfaces;

namespace NetBLog.Service.Implementation
{
    public class ServiceBase : IServiceBase
    {
        private readonly IMapper _mapper;
        public ServiceBase(IMapper mapper)
        {
            _mapper = mapper;
        }
        public IMapper Mapper => _mapper;
    }
}
