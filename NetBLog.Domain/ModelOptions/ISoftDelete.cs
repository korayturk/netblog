using System;

namespace NetBLog.Domain.ModelOptions
{
    public interface ISoftDelete
    {
        DateTime? DeletedAt { get; set; }
    }
}
