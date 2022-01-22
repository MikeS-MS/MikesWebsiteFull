using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Configuration;
using System.Data.SqlClient;
using Microsoft.AspNet.Identity;
using MikeWebsite.Models;

namespace MikeWebsite.Controllers
{
    public class CommentsController : Controller
    {
        [AllowAnonymous]
        [HttpGet]
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View();
            }
            return RedirectToAction("anonymous", "comments");
        }

        public PartialViewResult CommentsBox()
        {
            var comments = new Entities();
            return PartialView(comments.Comments.ToList());
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Index(Comment comment)
        {
            if (comment.Message != null && (comment.Message.Length > 0 && comment.Message.Length < 501))
            {
                var comments = new Entities();
                string command = "INSERT INTO Comment (Message, AuthorUserName, AuthorID) VALUES('{0}', '{1}', '{2}')";
                command = string.Format(command, comment.Message, User.Identity.Name, User.Identity.GetUserId());
                await comments.Database.ExecuteSqlCommandAsync(command);
                await comments.SaveChangesAsync();
                return RedirectToAction("index", "comments");
            }
            return View(comment);
        }

        public ActionResult Anonymous()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return View();
            }
            return RedirectToAction("index", "comments");
        }
    }
}
