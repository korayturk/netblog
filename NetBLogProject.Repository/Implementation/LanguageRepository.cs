using Microsoft.EntityFrameworkCore;
using NetBLog.Entity;
using NetBLog.Repository.Interfaces;

namespace NetBLog.Repository.Implementation
{
    public class LanguageRepository : Repository<Language>, ILanguageRepository
    {
        public LanguageRepository(DbContext context) : base(context)
        {
        }
    }
}
