using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Medtonic.mStar.DirectoryListings.Controllers
{
    public class HomeController : Controller
    {

        public class FileName
        {
            public string Path { get; set; }
            public DateTime Date { get; set; }
        }

        public ActionResult Index()
        {
          String buildDir =   System.Configuration.ConfigurationManager.AppSettings["BuildDirectory"];
    
            DirectoryInfo dInfo =  new DirectoryInfo(buildDir);

            var files = dInfo.GetFiles();
       
            return View(files);
        }

     
    }
}