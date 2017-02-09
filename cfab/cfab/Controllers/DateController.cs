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
        [Authorize]
        public ViewResult Index()  //we might want to chance index to something else. This currently this will be called when date/index is called
        {
            var dates = _context.Dates.Include(m => m.RestaurantType).Include(z => z.Zipcode).Include(i => i.DateTimeOfDay).Include(k => k.DatePrice).Include(j => j.DateType).ToList();
            return View(dates);
        }
        public ViewResult RandomResults()
        {
            return View("RandomResults");
        }

        public ActionResult Results(int id)
        {
            {
                var date = _context.Dates.Include(m => m.Zipcode).SingleOrDefault(c => c.Id == id);

                if (date == null)
                    return HttpNotFound();
                var viewModel = new DateFormViewModel
                {
                    Date = date,
                    RestaurantTypes = _context.RestaurantTypes,
                    Zipcodes = _context.Zipcodes,
                    DatePrices = _context.DatePrices,
                    DateTimeOfDays = _context.DateTimeOfDays,
                    DateTypes = _context.DateTypes,


                };
                return View("Results", viewModel);
            }
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
                DateTypes = _context.DateTypes,


            };
            return View("MainDateForm", viewModel);
        }

        public ActionResult New()
        {
            var dateTypes = _context.DateTypes.ToList();
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
                DateTypes = dateTypes,

            };
            return View("MainDateForm", viewModel);
        }

        public ViewResult Details(int id)
        {
            var date = _context.Dates.Include(m => m.RestaurantType).Include(z => z.DatePrice).Include(y => y.DateTimeOfDay).Include(t => t.DateType)
            .Include(z => z.Zipcode).SingleOrDefault(c => c.Id == id);

            return View(date);
        }

        [HttpPost]
        public ActionResult Save(Date date)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new DateFormViewModel
                {
                    Date = date,
                    RestaurantTypes = _context.RestaurantTypes.ToList(),
                    Zipcodes = _context.Zipcodes.ToList(),
                    DatePrices = _context.DatePrices.ToList(),
                    DateTimeOfDays = _context.DateTimeOfDays.ToList(),
                    DateTypes = _context.DateTypes.ToList(),

                };

                return View("MainDateForm", viewModel);
            }

            if (date.Id == 0)
                _context.Dates.Add(date);
            else
            {
                var dateInDb = _context.Dates.Single(c => c.Id == date.Id);

                /*TryUpdateModel(customerInDb); */  //Malicious users can mess-up database
                dateInDb.DayOfDate = date.DayOfDate;
                dateInDb.DateName = date.DateName;
                dateInDb.StreetOne = date.StreetOne;
                dateInDb.StreetTwo = date.StreetTwo;
                dateInDb.ZipcodeId = date.ZipcodeId;
                dateInDb.willEat = date.willEat;
                //dateInDb.IsActive = date.IsActive;
                //dateInDb.IsChatty = date.IsChatty;
                //dateInDb.IsArtsy = date.IsArtsy;
                dateInDb.RestaurantTypeId = date.RestaurantTypeId;
                dateInDb.DateTimeOfDayId = date.DateTimeOfDayId;
                dateInDb.DatePriceId = date.DatePriceId;
                dateInDb.DateTypeId = date.DateTypeId;
                //Or use AutoMapper
            }
            _context.SaveChanges();
            return RedirectToAction("Details", date);
        }
    }
}