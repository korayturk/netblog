using System;

namespace NetBLog.Entity.TableOptions
{
    public interface IModifiable
    {
        DateTime CreatedAt { get; set; }
        DateTime UpdatedAt { get; set; }
        string CreatedBy { get; set; }
        string UpdatedBy { get; set; }
    }
}
