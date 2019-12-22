using MvcBlogProject.Entities;
using MvcBlogProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcBlogProject.Extensions
{
    public static class AboutExtensions
    {
        public static AboutViewModel GetAboutViewModel(AboutPage aboutPage)
        {
            AboutViewModel aboutViewModel = new AboutViewModel
            {
                Title = aboutPage.TitleName,
                Description = aboutPage.AboutDescription
            };

            return aboutViewModel;
        }
    }
}