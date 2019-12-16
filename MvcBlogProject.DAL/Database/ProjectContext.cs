using MvcBlogProject.DAL.Mappings;
using MvcBlogProject.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.DAL.Database
{
    public class ProjectContext : DbContext
    {
        public ProjectContext() : base("defaultConnection")
        {
                        
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ContactPageMappings());
            //dbfirst yaparken isimlendirme de s takısı getirmesin diye bunun tikini kaldırıyorduk. 
            //Burda da istemiyoruz
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DbSet<AboutPage> AboutPage { get; set; }
        public DbSet<ContactPage> ContactPage { get; set; }
    }
}
