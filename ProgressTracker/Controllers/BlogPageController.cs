using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProgressTracker.Models;

namespace ProgressTracker.Controllers
{
    public class BlogPageController : Controller
    {
        // GET: BlogPage
        public ActionResult Index(string id)
        {
            //BlogPageViewModel vm = new BlogPageViewModel();
            return View();
        }
    }
}