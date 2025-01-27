﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Reservation
    {
        [Key]
        public int RezervationId { get; set; }
        public int AppUserId { get; set; }

        public AppUser AppUser { get; set; }

        public DateTime ReservationDate { get; set; }
        public DateTime ReservationDropDate { get; set; }

        public string Description { get; set; } 

		public string Status { get; set; } 

		public int CarId { get; set;}

        public Car Car { get; set; }
        public Customer Customers { get; set; }

    }
}
