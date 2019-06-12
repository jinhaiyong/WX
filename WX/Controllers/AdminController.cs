using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WX.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection fc)
        {
            string strAccount = fc["txtAccount"];
            string strPwd = fc["txtPassword"];

            return View();
        }
    }
}