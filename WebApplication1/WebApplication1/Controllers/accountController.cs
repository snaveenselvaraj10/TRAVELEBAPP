using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Mvc;
using WebApplication1.Controllers;
using WebApplication1.Models;

namespace Acount_MVC_Controllers
{
    
    public class accountController : Controller
    {

        private tripplanning_dbEntities db = new tripplanning_dbEntities();
        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult submit(login log)
        {
            if (log.username== "admin" && log.password== "admin")
            {
                return RedirectToAction("Index","admin");
            }

            return View(log);
        }

    }
}