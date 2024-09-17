using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AppUser :IdentityUser<int>
    {
        public string ImageUrl { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
		public string SurName { get; set; } = string.Empty;
		public string Adress { get; set; } = string.Empty;
		public DateTime BirthDay { get; set; }
        public double TcNo { get; set; }
        public int LicenseNumber { get; set; }
        public string City { get; set; } = string.Empty;

		public List<Reservation> Reservations { get; set; }
		public List<Comment> Comments { get; set; }

    }
}
