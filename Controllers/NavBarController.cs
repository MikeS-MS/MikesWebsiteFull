using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MikeWebsite.Models;

namespace MikeWebsite.Controllers
{
    public class NavBarController : Controller
    {
        // GET: NavBar
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