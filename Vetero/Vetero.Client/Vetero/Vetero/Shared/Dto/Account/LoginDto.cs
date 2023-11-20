﻿using System.ComponentModel.DataAnnotations;

namespace Vetero.Shared.Dto.Account
{
    public class LoginUserDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(6)]
        public string Password { get; set; }
    }
}
