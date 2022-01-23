using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MikeWebsite.Models;

namespace MikeWebsite.Controllers
{
    public class DownloadsController : Controller
    {
        // GET: Download
        public ActionResult Index()
        {
            string directory = Server.MapPath("/Content/downloads/");
            DirectoryInfo dir = new DirectoryInfo(directory);
            List<DownloadViewModel> Files = new List<DownloadViewModel>();

            foreach (var file in dir.GetFiles()) 
            {
                var download = new DownloadViewModel();
                download.href = "/Content/downloads/{0}";
                download.href = string.Format(download.href, file.Name);
                download.filedownloadname = file.Name;
                download.filename = file.Name.Replace(file.Extension, "");
                Files.Add(download);
            }
            return View(Files);
        }
    }
}