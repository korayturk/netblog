using System;
using NetBLog.Entity.TableOptions;

namespace NetBLog.Entity
{
    public class User : IEntity<int>, ISoftDelete
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Role { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
