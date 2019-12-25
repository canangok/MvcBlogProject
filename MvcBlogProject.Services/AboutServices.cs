using MvcBlogProject.DAL.Database;
using MvcBlogProject.DAL.Repository;
using MvcBlogProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.Services
{
    public class AboutServices
    {
        private AboutManagement _aboutManagement;

        public AboutServices()
        {
            _aboutManagement = new AboutManagement();
        }

        public AboutPage GetAbout()
        {
            var aboutPage = _aboutManagement.GetAboutPage();
            return aboutPage;
        }

        public void UpdateAbout(AboutPage aboutPage)
        {
            var result = _aboutManagement.EditAboutPage(aboutPage);
        }
    }

}
