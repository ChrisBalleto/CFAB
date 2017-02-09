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

        [Display(Name ="Name your Date")]
        public string DateName { get; set; }

        [Display(Name = "Date of Date")]
        public DateTime DayOfDate { get; set;}

        public int UserId { get; set; }

        [Display(Name = "Primary Address")]
        public string StreetOne { get; set; }

        [Display(Name = "Secondary Address")]
        public string StreetTwo { get; set; }

      
        public Zipcode Zipcode { get; set; }

        [Display(Name = "Zip Code")]
        public int ZipcodeId { get; set; }

        [Display(Name = "Will you be going to eat?")]
        public bool willEat { get; set; }

        [Display(Name = "Best describes your date.")]
        public DateType DateType { get; set; }
        [Display(Name = "What best describes your date?")]
        public int DateTypeId { get; set;}

        //[Display(Name = "Are they Chatty")]
        //public bool IsChatty { get; set; }

        //[Display(Name = "Are they Active")]
        //public bool IsActive { get; set; }

        //[Display(Name = "Are they Artsy")]
        //public bool IsArtsy { get; set; }

        [Display(Name = "Price Range")]
        public RestaurantType RestaurantType { get; set; }

        [Display(Name = "Atmosphere")]
        public int RestaurantTypeId { get; set; }

        [Display(Name = "Seach by Keyword")]
        public string Keyword { get; set; }

        [Display(Name = "Time of Day")]
        public DateTimeOfDay DateTimeOfDay { get; set; }

        [Display(Name = "Time of Date")]
        public int DateTimeOfDayId { get; set; }

        
        public DatePrice DatePrice { get; set; }

        [Display(Name = "Date Price")]
        public int DatePriceId { get; set; }


    }
}