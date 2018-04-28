using System.Data.Entity;

namespace Source2
{
    public class SecondContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
    }
}
