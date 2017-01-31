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

      

        public ActionResult Index(string id)
        {
            String buildDir = System.Configuration.ConfigurationManager.AppSettings["BuildDirectory"];
            DirectoryView view = new DirectoryView();
            if (id != null)
            {
                DirectoryInfo dInfo1 = new DirectoryInfo(buildDir + "/" + id);
                
                var files = dInfo1.GetFiles().ToList();
                view.Files = files;
                view.Directories = false;
            }else
            {
                DirectoryInfo dInfo = new DirectoryInfo(buildDir);
                var directories = dInfo.GetDirectories().ToList();
                view.Directories = true;
                view.Dirs = directories;
            }
          
            
       
            return View(view);
        }

     
    }
}