using MvcBlogProject.Entities;
using MvcBlogProject.Extensions;
using MvcBlogProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlogProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly AboutServices _aboutServices;
        private readonly ContactServices _contactServices;

        public HomeController()
        {
            _aboutServices = new AboutServices();
            _contactServices = new ContactServices();
        }
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult About()
        {
            AboutPage about = _aboutServices.GetAbout();
            var model = about.GetAboutViewModel();
            //var model = AboutExtensions.GetAboutViewModel(about);

            //if(about == null)
            //{
            //    return PartialView("_NotFound");
            //}
            return View(model);
        }

        [HttpGet]
        public ActionResult Contact()
        {
            var contact = _contactServices.GetContact();
            if (contact == null)
            {
                // return PartialView("_NotFound");
                return PartialView("_NotFound");
            }
            return View(contact);
        }
    }
}