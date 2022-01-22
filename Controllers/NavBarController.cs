using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using MikeWebsite.Models;

namespace MikeWebsite.Controllers
{
    public class NavBarController : Controller
    {
        public PartialViewResult Admin()
        {
            var context = new Entities();
            if (User.Identity.IsAuthenticated)
            {
                if (context.Roles.Find(User.Identity.GetUserId()).RoleId == 1)
                {
                    return PartialView();
                }
            }
            return PartialView("empty");
        }

        public PartialViewResult Empty()
        {
            return PartialView();
        }

        public PartialViewResult Login()
        {
            if (!User.Identity.IsAuthenticated)
                return PartialView();
            LoginViewModel model = new LoginViewModel();
            model.AccountName = User.Identity.Name;
            return PartialView("loggedin", model);
        }

        public PartialViewResult LoggedIn(LoginViewModel model)
        {
            if (User.Identity.IsAuthenticated)
                return PartialView(model);
            return PartialView("login");
        }
    }
}