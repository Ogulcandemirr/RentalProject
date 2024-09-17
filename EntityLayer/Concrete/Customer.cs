using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "TC Numarası boş olamaz.")]
        public string IdentityNumber { get; set; }
        
        [Required(ErrorMessage = "Adınız boş olamaz.")]
        public string Name { get; set; }
 
        [Required(ErrorMessage = "Soyadınız boş olamaz.")]
        public string Surname { get; set; }
       
        [Required(ErrorMessage = "Telefon boş olamaz.")]   
        public string Phone { get; set; }
        
        [Required(ErrorMessage = "E-mail boş olamaz.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-mail adresi giriniz.")]
        public string Email { get; set; }
       
        [Required(ErrorMessage = "Doğum tarihi boş olamaz.")]
        public DateTime BirthDate { get; set; }
      
        [Required(ErrorMessage = "Şehir boş olamaz.")]
        public string City { get; set; }
      
        [Required(ErrorMessage = "Ehliyet No boş olamaz.")]
        public string LicenceNumber { get; set; }
        public string FlyNumber { get; set; }
       
        [Required(ErrorMessage = "Adres boş olamaz.")]
        public string Adress { get; set; }


    }
}
