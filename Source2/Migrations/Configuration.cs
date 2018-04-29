namespace Source2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SecondContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SecondContext context)
        {
            if (context.Departments.Any())
                return;
            for (int i = 1; i <= 15; i++)
            {
                context.Departments.Add(new Department
                {
                    Title = $"Department_{i}"
                });
            }
            context.SaveChanges();
        }
    }
}
