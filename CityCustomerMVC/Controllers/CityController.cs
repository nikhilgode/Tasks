using CityCustomerMVC.Models;
using CityCustomerMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CityCustomerMVC.Controllers
{
    public class CityController : Controller
    {

        private readonly ApplicationDbContext _context;

        public CityController()
        {
            _context = new ApplicationDbContext();
        }



        public ActionResult viewCitis() 
        {

            var c1= _context.cities.ToList();
            return View(c1);
        }


        public ActionResult NewCityForm()
        {
            return View();
        }


        public ActionResult AddCity(City c1)
        {
            if(!ModelState.IsValid)
            {


                return View("NewCityForm");
            }

            _context.cities.Add(c1);
            _context.SaveChanges();

            return RedirectToAction("viewCitis","City");
        }

        public ActionResult EditCity()
        {
            var c1=_context.cities.ToList();
            var c2 = new CityList
            {
                cities = c1
            };
            return View(c2);
        }

        public ActionResult SaveEditedCity(City c1)
        {

            

            return RedirectToAction("viewCitis", "City");
          //  return View();
        }


        public ActionResult TrialCity()
        {


            var c1= _context.cities.ToList();
            return View(c1);  
        }

    }


     

}