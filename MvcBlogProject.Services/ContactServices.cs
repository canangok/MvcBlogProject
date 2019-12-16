using MvcBlogProject.DAL.Repository;
using MvcBlogProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.Services
{
    public class ContactServices
    {
        private ContactManagement _contactManagement;

        public ContactServices()
        {
            _contactManagement = new ContactManagement();
        }

        public ContactPage GetContact()
        {
            var contactPage = _contactManagement.GetContactPage();
            return contactPage;
        }
    }
}
