﻿using Microsoft.AspNetCore.Identity;

namespace RentOdevProje.Models
{
	public class CustomIdentityValidator : IdentityErrorDescriber
	{
		public override IdentityError PasswordTooShort(int length)
		{
			return new IdentityError
			{
				Code = "PasswordTooShort",
				Description = $" Parola Minimum {length} Karakter Olmalıdır!"
			};
		}

		public override IdentityError PasswordRequiresUpper()
		{
			return new IdentityError
			{
				Code = "PasswordRequiresUpper",
				Description = "Parola En az 1 büyük harf içermelidir!"
			};
		}

		public override IdentityError PasswordRequiresLower()
		{
			return new IdentityError
			{
				Code = "PasswordRequiresLower",
				Description = "Parola en az 1 küçük harf içermelidir!"
			};
		}

		public override IdentityError PasswordRequiresNonAlphanumeric()
		{
			return new IdentityError
			{
				Code = "PasswordRequiresNonAlphanumeric",
				Description = "Parola en az 1 sembol içermelidir!"
			};
		}
	}
}