using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilterPrac1st.Controllers
{
    public class AuthNonauthController : Controller
    {
      
        public ActionResult SecureMethod()
        {
            return View();
        }

        public ActionResult NonSecureMethod()
        {
            return View();
        }


    }
}