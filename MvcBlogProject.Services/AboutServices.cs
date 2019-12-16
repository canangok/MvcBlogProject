using MvcBlogProject.DAL.Database;
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
        private ProjectContext Database;
        public AboutServices()
        {
            Database = new ProjectContext();
        }

       
    }
}
