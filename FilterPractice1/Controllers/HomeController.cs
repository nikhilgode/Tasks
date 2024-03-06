using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FilterPractice1.Common;

namespace FilterPractice1.Controllers
{
    public class HomeController : Controller
    {
        [TrackExeutionFile]
        public string Index()
        {
            return "Index acion invoked";
        }

        [TrackExeutionFile]
        public string Welcome()
        {
            throw new Exception("Excption Occured");
        }
    }
}