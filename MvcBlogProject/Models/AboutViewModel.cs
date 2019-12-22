using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcBlogProject.Models
{
    public class AboutViewModel
    {
        [Display(Name="Başlık")]
        public string Title { get; set; }

        [Display(Name = "İçerik")]
        public string Description { get; set; }
    }
}