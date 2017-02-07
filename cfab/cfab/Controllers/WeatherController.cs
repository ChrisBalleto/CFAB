using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cfab.Models;

namespace cfab.Controllers
{
    public class WeatherController : Controller
    {
        private ApplicationDbContext _context;
        public WeatherController()
        {
            _context = new ApplicationDbContext();

        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Date
        public ActionResult Index() 
        {
            var weather = new Weather();
            return View();
        }
    }
}