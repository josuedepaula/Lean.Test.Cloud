using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lean.Test.Cloud.Areas.Login.Controllers
{
    [RoutePrefix("Login")]
    public class LoginController : Controller
    {
        // GET: Login/Login
        public ActionResult Index()
        {
            return View();
        }
    }
}