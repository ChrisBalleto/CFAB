using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cfab.Models;

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
        public ActionResult Index()  //we might want to chance index to something else. This currently this will be called when date/index is called
        {
            var date = new Date();
            return View();
        }
    }
}