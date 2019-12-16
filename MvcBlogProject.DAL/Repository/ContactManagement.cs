using MvcBlogProject.DAL.Database;
using MvcBlogProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.DAL.Repository
{
    public class ContactManagement
    {
        private ProjectContext Database;
        public ContactManagement()
        {
            Database = new ProjectContext();
        }
        public ContactPage GetContactPage()
        {
            var contactPage = Database.ContactPage.FirstOrDefault();
            return contactPage;
        }
    }
}

