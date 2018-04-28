using System.Data.Entity;
using Source2.Entities;

namespace Source2.Concrete
{
    class SecondContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
    }
}
