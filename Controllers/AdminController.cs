using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using MikeWebsite.Models;

namespace MikeWebsite.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            Entities context = new Entities();

            if (User.Identity.IsAuthenticated)
            {
                Role role = context.Roles.Find(User.Identity.GetUserId());
                if (role.RoleId == 1)
                    return View(context.Comments.ToList());
            }
            return RedirectToAction("index", "home");
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Index(Comment comment)
        {
            var context = new Entities();
            Role role = context.Roles.Find(User.Identity.GetUserId());
            if (comment.Message != null && role.RoleId == 1)
            {
                string command = "DELETE FROM Comment WHERE Id={0}";
                command = string.Format(command, comment.Id);
                await context.Database.ExecuteSqlCommandAsync(command);
                await context.SaveChangesAsync();
            }
            return RedirectToAction("index", "admin");
        }
    }
}