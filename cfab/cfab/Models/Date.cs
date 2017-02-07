using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using cfab.Models;

namespace cfab.Models
{
    public class Weather
    {
        public int Id { get; set; }

        public DateTime DayOfDate { get; set;}

        public int UserId { get; set; }

        [Display(Name = "Are they are Chatty")]
        public bool IsChatty { get; set; }

        [Display(Name = "Are they are Active")]
        public bool IsActive { get; set; }

        [Display(Name = "Are they are Artsy")]
        public bool IsArtsy { get; set; }

        public RestaurantType RestaurantType { get; set; }

        public int RestaurantTypeId { get; set; }

        public string Keyword { get; set; }

        public DateTimeOfDay DateTimeOfDay { get; set; }

        public int DateTimeOfDayId { get; set; }

        public DatePrice DatePrice { get; set; }

        public int DatePriceId { get; set; }


    }
}