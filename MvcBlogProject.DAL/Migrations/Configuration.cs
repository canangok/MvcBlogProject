namespace MvcBlogProject.DAL.Migrations
{
    using MvcBlogProject.Entities;

    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcBlogProject.DAL.Database.ProjectContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MvcBlogProject.DAL.Database.ProjectContext context)
        {
            
            if (!context.AboutPage.Any())
            {
                var AboutPage = new AboutPage()
                {
                    TitleName = "Örnek Baþlýk",
                    AboutDescription = "Seed ile gelen içerik bu þekilde kullanýlmalýdýr"
                };
                context.AboutPage.Add(AboutPage);
                context.SaveChanges();
               
            }
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
