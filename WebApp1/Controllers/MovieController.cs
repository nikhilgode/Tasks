using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.MappingViews;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp1.Models;
using WebApp1.ViewModels;

namespace WebApp1.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Random()
        {

            var movie = new Movie() { Name = "RHTDM" };

            var customers = new List<Customer>
            {
                new Customer  { Name="Customer1" } ,
                new Customer  { Name="Customer2" }
            };

            var v1 = new RandomMovieViewModel
            {
                Movie=movie,
                Customer=customers,
            };

               return View(v1);



            //    return Content("RHTDM...!");
            //      return HttpNotFound();

            //    return new EmptyResult();

           // return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }


        public  ActionResult Edit(int id) 
        {
            return Content("ID=" + id);
        }

        public ActionResult Index(int? pageindex ,String sortby)
        {
            if (!pageindex.HasValue)
                pageindex = 111;

            if (String.IsNullOrWhiteSpace(sortby))
                sortby = "Name";

            return Content(string.Format("Pageindex={0}&Sortby={1}", pageindex, sortby));
        }


        //[Route("Movie/released/{year}/")]
        // public ActionResult ByreleaseDate(int year,byte month)
        //{
        //    return Content(year + "/" + month);
        //}

        [Route("Movie/Released/{year}/{month}")]

        public ActionResult ByreleaseDate(int year,string month)
        {
            //  if(!month.HasValue)
            //      month = 1;
            //  /{ month: regex(\\d{ 2}):range(1, 12)}

            return Content(year + "/"+month);
        }
        //[Route("Movie/released")]
        //public ActionResult ByreleaseDate(string year="2024")
        //{
        //    return Content(year);
        //}



    }
}