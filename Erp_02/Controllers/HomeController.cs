using Erp_02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Erp_02.Controllers
{
    public class HomeController : Controller
    {
        NuserContext nu =new NuserContext();
        // GET: Home
        public ActionResult Index()
        {
            var x=nu.Nusers.ToList();
            return View(x);
        }
    }
}