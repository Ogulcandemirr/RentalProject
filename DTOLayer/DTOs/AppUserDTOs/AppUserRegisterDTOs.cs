﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.DTOs.AppUserDTOs
{
	public class AppUserRegisterDTOs
	{
		public string Name { get; set; } = string.Empty;

		public string SurName { get; set; } = string.Empty;

		public string UserName { get; set; } = string.Empty;
		public string Mail { get; set; } = string.Empty;

		public string Password { get; set; } = string.Empty;

		public string ComfirmPassword { get; set; } = string.Empty;
	}
}
