using Microsoft.AspNetCore.Http;

namespace RentOdevProje.Areas.Member.Models
{
    public class UserEditViewModel
    {
        public string name { get; set; } = string.Empty;
        public string surname { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;
        public string confirmpassword { get; set; } = string.Empty;
        public string phonenumber { get; set; } = string.Empty;
        public string mail { get; set; } = string.Empty;
        public string imageurl { get; set; } = string.Empty;

        public IFormFile Image { get; set; }
    }
}
