using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace cfab.Models
{
    public class Date
    {
        public int Id { get; set; }

        public string DateName { get; set; }

        public DateTime DayOfDate { get; set;}

        public int UserId { get; set; }

        public string StreetOne { get; set; }

        public string StreetTwo { get; set; }

        public Zipcode Zipcode { get; set; }

        public int ZipcodeId { get; set; }

        [Display(Name = "Will you be going to Eat?")]
        public bool willEat { get; set; }

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