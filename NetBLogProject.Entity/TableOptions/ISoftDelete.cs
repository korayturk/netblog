using System;

namespace NetBLog.Entity.TableOptions
{
    public interface ISoftDelete
    {
        DateTime? DeletedAt { get; set; }
    }
}
