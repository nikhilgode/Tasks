using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilterPrac1st.Controllers
{
    public class BagDataController : Controller
    {
        // GET: BagData
        public ActionResult ViewBagImplementation()
        {

            ViewBag.Countries = new List<String>() 
            {
                  "India",
                  "Us",
                  "UK",
                  "Shrilanka"
            };

            return View();
        }

        public ActionResult ViewDataImplementation()
        {

            ViewData["Countries"] = new List<String>()
            {
                 "India",
                 "Us",
                 "UK",
                 "Shrilanka"

            };

            return View();
        }
    }
}