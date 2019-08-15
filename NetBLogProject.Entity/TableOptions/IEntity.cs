using System.ComponentModel.DataAnnotations;

namespace NetBLog.Entity
{
    public interface IEntity<TKey>
    {
        [Key]
        TKey Id { get; set; }        
    }
}