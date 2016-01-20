using StebraDesign2016MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StebraDesign2016MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() //example comment
        {
            //list to hold Archived News
            List<StebraEntity> news = new List<StebraEntity>();

            //Get news from AzureTable
            news = AzureManager.LoadNews();

            //sort list descend by Dateprop
            news = SortByDateManager.LatestFirst(news);

            return View(news);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult NewsFlash()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult News()
        {
            ViewBag.Message = "Latest News.";

            //list to hold Archived News
            List<StebraEntity> news = new List<StebraEntity>();

            //Get news from AzureTable
            news = AzureManager.LoadNews();

            //sort list descend by Dateprop
            news = SortByDateManager.LatestFirst(news);

            return View(news);
        }

        public ActionResult NewsOne()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult NewsTwo()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult NewsThree()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Blogs()
        {
            ViewBag.Message = "Your contact page.";

            return View();

        }
        public ActionResult BlogsOne()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult BlogsTwo()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult BlogsThree()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Projects()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult ProjectsOne()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult ProjectsTwo()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult ProjectsThree()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}