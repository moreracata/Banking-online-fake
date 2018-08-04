using Microsoft.AspNet.Identity;
using Online_Banking.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Online_Banking.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private UserService userService = new UserService();
        public ActionResult Index()
        {
            

            //var currentUser = userService.GetCustomerData();
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