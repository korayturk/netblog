using AutoMapper;

namespace NetBLog.Service.Interfaces
{
    public interface IServiceBase
    {
        IMapper Mapper { get; }
    }
}
