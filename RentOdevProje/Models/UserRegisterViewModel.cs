using System.ComponentModel.DataAnnotations;

namespace RentOdevProje.Models
{
	public class UserRegisterViewModel
	{
		[Required(ErrorMessage = "Lütfen Adınızı Giriniz")]
		public string Name { get; set; } = string.Empty;

		[Required(ErrorMessage = "Lütfen Soyadınızı Giriniz")]
		public string SurName { get; set; } = string.Empty;

		[Required(ErrorMessage = "Lütfen Kullanıcı Adınızı Giriniz")]
		public string UserName { get; set; } = string.Empty;

		[Required(ErrorMessage = "Lütfen Mail Adresinizi Giriniz")]
		public string Mail { get; set; } = string.Empty;

		[Required(ErrorMessage = "Lütfen Şifrenizi Giriniz")]
		public string Password { get; set; } = string.Empty;

		[Required(ErrorMessage = "Lütfen Şifrenizi Tekrar Giriniz")]
		[Compare("Password", ErrorMessage = "Şifreler aynı olmalıdır !")]
		public string ComfirmPassword { get; set; } = string.Empty;
	}
}
