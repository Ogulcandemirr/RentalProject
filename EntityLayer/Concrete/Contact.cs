using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        public string Description { get; set; } = string.Empty;
		public string Mail { get; set; } = string.Empty;
		public string Adress { get; set; } = string.Empty;
		public string Phone { get; set; } = string.Empty;
		public string MapLocation { get; set; } = string.Empty;
		public bool Status { get; set; }
    }
}
