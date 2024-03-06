using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FilterPrac1st.Common;

namespace FilterPrac1st.Controllers
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