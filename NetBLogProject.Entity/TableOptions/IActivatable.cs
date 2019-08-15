using System;

namespace NetBLog.Entity.TableOptions
{
    public interface IActivatable
    {
        DateTime? ActivatedAt { get; set; }
    }
}
