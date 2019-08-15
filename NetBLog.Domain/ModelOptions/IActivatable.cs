using System;

namespace NetBLog.Domain.ModelOptions
{
    public interface IActivatable
    {
        DateTime? ActivatedAt { get; set; }
    }
}
