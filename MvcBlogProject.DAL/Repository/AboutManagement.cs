using MvcBlogProject.DAL.Database;
using MvcBlogProject.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.DAL.Repository
{
    public class AboutManagement
    {
        private ProjectContext Database;
        public AboutManagement()
        {
            Database = new ProjectContext();
        }
        public AboutPage GetAboutPage()
        {
            var aboutPage = Database.AboutPage.FirstOrDefault();
            return aboutPage;
        }

        public bool EditAboutPage(AboutPage aboutPage)
        {
            Database.Entry(aboutPage).State = EntityState.Modified;
            var resultCount = Database.SaveChanges();
            return resultCount > 0;
        }
    }
}
