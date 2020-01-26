using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace NetBLog.Api.Filters
{
    public class TransactionManagerFilter : IAsyncActionFilter
    {
        //UnitOfWork died
        private readonly DbContext _context;
        public TransactionManagerFilter(DbContext context)
        {
            _context = context;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            _context.Database.BeginTransaction();

            await next();
            try
            {
                if (_context.ChangeTracker.HasChanges())
                {
                    _context.Database.CurrentTransaction.Commit();
                    await _context.SaveChangesAsync();
                }
            }
            catch
            {
                if (_context.Database.CurrentTransaction != null)
                    _context.Database.RollbackTransaction();
                throw;
            }
        }
    }
}
