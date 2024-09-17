using System.ComponentModel.DataAnnotations;

namespace RentOdevProje.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage = "Lütfen Kullanıcı Adını Giriniz !")]
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Lütfen Şifrenizi Giriniz !")]
        public string Password { get; set; } = string.Empty;

    }
}
