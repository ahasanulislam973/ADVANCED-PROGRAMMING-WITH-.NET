using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CV.Controllers
{
    public class CVController : Controller
    {
        //
        // GET: /CV/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PersonalInfo()
        {
            return View();
        }

        public ActionResult EducationalQualification()
        {
            return View();
        }

        public ActionResult ContactInfo()
        {
            return View();
        }

    }
}
