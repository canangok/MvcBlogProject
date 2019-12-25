using MvcBlogProject.Entities;
using MvcBlogProject.Extensions;
using MvcBlogProject.Models;
using MvcBlogProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlogProject.Areas.Admin.Controllers
{
    public class AboutController : Controller
    {
        private AboutServices _aboutServices;
        public AboutController()
        {
            _aboutServices = new AboutServices();
        }
        // GET: Admin/About
        [HttpGet]
        public ActionResult Index()
        {
            var aboutModel = _aboutServices.GetAbout();
            //var aboutViewModel = new AboutViewModel
            //{
            //    Title = aboutModel.TitleName,
            //    Description = aboutModel.AboutDescription
            //};
            var aboutViewModel = aboutModel.GetAboutViewModel();
            return View(aboutViewModel);
        }
        [HttpGet]
        public ActionResult Edit()
        {
            var aboutModel = _aboutServices.GetAbout();

            //var aboutViewModel = new AboutViewModel
            //{
            //    Title = aboutModel.TitleName,
            //    Description = aboutModel.AboutDescription
            //};
            //return View(aboutViewModel);
            var aboutViewModel = aboutModel.GetAboutViewModel();
            return View(aboutViewModel);
        }

        [HttpPost]
        public ActionResult Edit(AboutViewModel aboutViewModel)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "İçeriği düzenleyebilmek için gerekli tüm alanları doldurmanız gerekmektedir");
                return View();
            }
            var aboutPage = aboutViewModel.GetAboutPage();
            _aboutServices.UpdateAbout(aboutPage);

            return RedirectToAction("Index");
        }


    }
}