using System.ComponentModel.DataAnnotations;

namespace NetBLog.Domain.Models
{
    public interface IEntity<TKey>
    {
        [Key]
        TKey Id { get; set; }        
    }
}