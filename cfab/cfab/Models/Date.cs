using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace cfab.Models
{
    public class Date
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter Date Name")]
        [Display(Name ="Name your Date")]
        public string DateName { get; set; }

        [Display(Name = "Date of Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [Required(ErrorMessage = "Use the following format: mm/dd/yyyy")]
        //[RegularExpression(@"/^\d{2}\/\d{2}\/\d{4}/", ErrorMessage = "Use the following format: mm/dd/yyyy")]
        public DateTime DayOfDate { get; set;}

        public int UserId { get; set; }
        [Required(ErrorMessage = "Enter Address")]
        [Display(Name = "Start Address")]
        public string StreetOne { get; set; }

        [Display(Name = "Alternative Address")]
        public string StreetTwo { get; set; }
      
        public Zipcode Zipcode { get; set; }
        [Required(ErrorMessage = "Choose Zip Code")]
        [Display(Name = "Zip Code")]
        public int ZipcodeId { get; set; }
        
    
        [Display(Name = "Will you be going to eat?")]
        public bool willEat { get; set; }

        //[Required(ErrorMessage = "Choose An Option")]
        //[Display(Name = "Best describes your date.")]
        public DateType DateType { get; set; }

        [Required(ErrorMessage = "Choose An Option")]
        [Display(Name = "What best describes your date?")]
        public int DateTypeId { get; set;}

        //[Required(ErrorMessage = "Choose An Option")]
        //[Display(Name = "Price Range")]
        public RestaurantType RestaurantType { get; set; }

        [Required(ErrorMessage = "Choose An Option")]
        [Display(Name = "Atmosphere")]
        public int RestaurantTypeId { get; set; }


        [Display(Name = "Seach by Keyword")]
        public string Keyword { get; set; }


        public DateTimeOfDay DateTimeOfDay { get; set; }

        [Required(ErrorMessage = "Choose An Option")]
        [Display(Name = "Time of Date")]
        public int DateTimeOfDayId { get; set; }

        
        public DatePrice DatePrice { get; set; }

        [Required(ErrorMessage = "Choose An Option")]
        [Display(Name = "Date Price")]
        public int DatePriceId { get; set; }


    }
}