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
        public static AboutViewModel GetAboutViewModel(this AboutPage aboutPage)
        {
            AboutViewModel aboutViewModel = new AboutViewModel
            {
                Id = aboutPage.Id,
                Title = aboutPage.TitleName,
                Description = aboutPage.AboutDescription
            };

            return aboutViewModel;
        }

        public static AboutPage GetAboutPage(this AboutViewModel viewModel)
        {
            var aboutPage = new AboutPage
            {
                Id = viewModel.Id,
                TitleName = viewModel.Title,
                AboutDescription = viewModel.Description
            };
            return aboutPage;

        }
    }
}