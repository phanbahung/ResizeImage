using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UploadImage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Error = TempData["e"] == null ? "" : TempData["e"].ToString();
            ViewBag.Files = TempData["file"] == null ? new List<string>() : (List<string>)TempData["file"];
            return View();
        }

        public ActionResult Crop()
        {
            ViewBag.Error = TempData["e"] == null ? "" : TempData["e"].ToString();
            ViewBag.Files = TempData["file"] == null ? new List<string>() : (List<string>)TempData["file"];
            return View();
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

        
    }

}
