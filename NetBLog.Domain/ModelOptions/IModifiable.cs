using System;

namespace NetBLog.Domain.ModelOptions
{
    public interface IModifiable
    {
        DateTime CreatedAt { get; set; }
        DateTime UpdatedAt { get; set; }
        string CreatedBy { get; set; }
        string UpdatedBy { get; set; }
    }
}
