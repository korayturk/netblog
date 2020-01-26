using AutoMapper;
using NetBLog.Contract;
using NetBLog.Repository.Interfaces;
using NetBLog.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetBLog.Service.Implementation
{
    public class LanguageService : ServiceBase, ILanguageService
    {
        private readonly ILanguageRepository _languageRepository;
        public LanguageService(IMapper mapper, ILanguageRepository languageRepository) : base(mapper)
        {
            _languageRepository = languageRepository;
        }

        public async Task<List<LanguageContract>> GetAll()
        {
            return Mapper.Map< List<LanguageContract>>(await _languageRepository.GetAll());
        }
    }
}
