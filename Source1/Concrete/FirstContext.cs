using System.Data.Entity;
using Source1.Entities;

namespace Source1.Concrete
{
    public class FirstContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
