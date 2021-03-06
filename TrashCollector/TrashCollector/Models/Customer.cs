﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public double Bill { get; set; }


        [Display(Name = "Zip Code")]
        public double ZipCode { get; set; }

        [Display(Name = "Pick Up Day")]
        public DayOfWeek PickUpDay { get; set; }

        [Display(Name = "Monthly Add-On"),DataType(DataType.Date)]
        [DisplayFormat(NullDisplayText = "", DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? MonthlyAddOn { get; set; }

        [Display(Name = "Start Service Interruption"), DataType(DataType.Date)]
        [DisplayFormat(NullDisplayText = "", DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? StartServiceInterruption { get; set; }
        
        [Display(Name = "End Service Interruption Date"), DataType(DataType.Date)]
        [DisplayFormat(NullDisplayText = "", DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? EndServiceInterruption { get; set; }


        // Role
        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

        [NotMapped]
        public bool IsComplete { get; set; }
    }
}
