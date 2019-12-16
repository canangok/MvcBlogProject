using MvcBlogProject.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.DAL.Mappings
{
    public class ContactPageMappings : EntityTypeConfiguration<ContactPage>
    {
        public ContactPageMappings()
        {
            ToTable("Contact", "blog");
        }
    }
}
