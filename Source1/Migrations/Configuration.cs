namespace Source1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FirstContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FirstContext context)
        {
            if (context.Users.Any())
                return;
            for (int i = 1; i < 5; i++)
            {
                context.Users.Add(new User
                {
                    UserName = $"User_{i}",
                    DepartmentId = i
                });
            }
            context.SaveChanges();
        }
    }
}
