using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class PickUp
    {
        public int PickUpId { get; set; }
        public bool Paid { get; set; }

        [Display(Name = "Date"), DataType(DataType.Date)]
        public DateTime Date { get; set; }

        //Customer associated with the pickup
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        // Employee responsible for picking up
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
