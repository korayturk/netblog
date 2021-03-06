﻿using NetBLog.Contract;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetBLog.Service.Interfaces
{
    public interface ICategoryService : IServiceBase
    {
        Task<IEnumerable<CategoryContract>> GetForTopMenu(int languageId);
    }
}
