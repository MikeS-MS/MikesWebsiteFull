using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Configuration;
using System.Data.SqlClient;
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
            var comments = new CommentsDBModel();
            return PartialView(comments.Comments.ToList());
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Index(Comment comment)
        {
            if (comment.Message != null && (comment.Message.Length > 0 && comment.Message.Length < 501))
            {
                var comments = new CommentsDBModel();
                string command = "INSERT INTO Comment (Message, AuthorUserName) VALUES('{0}', '{1}')";
                command = string.Format(command, comment.Message, User.Identity.Name);
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
