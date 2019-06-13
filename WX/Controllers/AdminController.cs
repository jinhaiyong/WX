using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;

namespace WX.Controllers
{
    public class AdminController : Controller
    {
        private ConnectionString db = new ConnectionString();
        // GET: Admin
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection fc)
        {
            try
            {
                string strAccount = fc["txtAccount"];
                string strPwd = fc["txtPassword"];

                var user = db.sysUsers.Where(u => u.account == strAccount & u.passWord == strPwd);
                if (user.Count() > 0)
                {
                    return View("Index");
                }
            }
            catch (Exception ex)
            {

            }
            return View();

        }
    }
}