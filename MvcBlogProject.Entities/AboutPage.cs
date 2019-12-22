using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.Entities
{
    [Table("About",Schema ="blog")]
    public class AboutPage
    {
        public int Id { get; set; }
        [Display(Name ="Başlık")]
        public string TitleName { get; set; }
        [Display(Name = "İçerik")]
        public string AboutDescription { get; set; }
    }
}
