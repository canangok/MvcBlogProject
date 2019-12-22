using MvcBlogProject.Entities;
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
            return View(aboutModel);
        }
        [HttpGet]
        public ActionResult Edit()
        {
            var aboutModel = _aboutServices.GetAbout();
            return View(aboutModel);
        }

        [HttpPost]
        public ActionResult Edit(AboutPage aboutPage)
        {
           
            return View();
        }


    }
}