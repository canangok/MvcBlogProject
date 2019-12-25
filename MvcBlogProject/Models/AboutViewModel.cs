using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlogProject.Models
{
    public class AboutViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Başlık")]
        [Required(ErrorMessage = "Hakkımda bilgisini göstermek için bu alan zorunludur")]
        [MinLength(4, ErrorMessage = "{0} için en az {1}  karakter girin")]
        [MaxLength(20, ErrorMessage = "{0} için En fazla {1} karakter")]
        //[StringLength(11,ErrorMessage ="TC KIMLIK {1} HANE OLMAK ZORUNDA", MinimumLength = 11)]//max,error,min
        //[EmailAddress]
        //[Phone]
        
        public string Title { get; set; }

        [Display(Name = "İçerik")]
        [Required(ErrorMessage = "Hakkımda bilgisinin içeriğini burdan değiştirilmelidir")]
        [AllowHtml]

        public string Description { get; set; }
    }
}