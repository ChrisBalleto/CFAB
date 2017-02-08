using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using cfab.Models;

namespace cfab.ViewModels
{
    public class DateFormViewModel
    {
        public Date Date { get; set; }
        public IEnumerable<Zipcode> Zipcodes { get; set; }
        public IEnumerable<RestaurantType> RestaurantTypes { get; set; }
        public IEnumerable<DateTimeOfDay> DateTimeOfDays { get; set; }
        public IEnumerable<DatePrice> DatePrices { get; set; }
       
    }
}