using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InstituteSystem.Controllers
{
    public class MasterMVCController : Controller
    {
        // GET: MasterMVC
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Teacher()
        {
            return View();
        }

        public ActionResult Subject()
        {
            return View();
        }
        public ActionResult SubTech()
        {
            return View();
        }

    }
}