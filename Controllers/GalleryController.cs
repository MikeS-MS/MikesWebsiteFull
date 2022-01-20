using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MikeWebsite.Controllers
{
    public class GalleryController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
