using System.Data.Entity;

namespace Source1
{
    public class FirstContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
