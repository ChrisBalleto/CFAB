using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using cfab.Models;
using cfab.ViewModels;

namespace DateNightApp.Controllers
{
    public class DateController : Controller
    {
        private ApplicationDbContext _context;
        public DateController()
        {
            _context = new ApplicationDbContext();

        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Date
        public ViewResult Index()  //we might want to chance index to something else. This currently this will be called when date/index is called
        {
            var dates = _context.Dates.Include(m => m.RestaurantType).Include(z => z.Zipcode).Include(i => i.DateTimeOfDay).Include(k => k.DatePrice).ToList();
            return View(dates);
        }
        

        public ActionResult BasicInfo()
        {
            return View();
        }
        public ActionResult Edit(int id)
        {
            var date = _context.Dates.SingleOrDefault(c => c.Id == id);

            if (date == null)
                return HttpNotFound();
            var viewModel = new DateFormViewModel
            {
                Date = date,
                RestaurantTypes = _context.RestaurantTypes,
                Zipcodes = _context.Zipcodes,
                DatePrices = _context.DatePrices,
                DateTimeOfDays = _context.DateTimeOfDays,             

            };
            return View("MainDateForm", viewModel);
        }

        public ActionResult New()
        {
            var restaurantTypes = _context.RestaurantTypes.ToList();
            var dateTimeOfDays = _context.DateTimeOfDays.ToList();
            var zipcodes = _context.Zipcodes.ToList();
            var datePrices = _context.DatePrices.ToList();
            var viewModel = new DateFormViewModel
            {
                Date = new Date(),

                RestaurantTypes = restaurantTypes,
                DatePrices = datePrices,
                DateTimeOfDays = dateTimeOfDays,
                Zipcodes = zipcodes,

            };
            return View("MainDateForm", viewModel);
        }
    }
}