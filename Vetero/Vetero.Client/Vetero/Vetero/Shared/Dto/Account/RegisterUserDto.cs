using System.ComponentModel.DataAnnotations;

namespace Vetero.Shared.Dto.Account
{
    public class RegisterUserDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(6)]
        public string Password { get; set; }
        [Required]
        [MinLength(6)]
        public string ConfirmPassword { get; set; }
        [Required]
        [MinLength(3)]
        [RegularExpression("^[^0-9]*$", ErrorMessage = "Nie można wprowadzać cyfr.")]
        public string City { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int RoleId { get; set; } = 1;
        [Required]
        [MinLength(3)]
        [RegularExpression("^[^0-9]*$", ErrorMessage = "Nie można wprowadzać cyfr.")]
        public string FirstName { get; set; }
        [Required]
        [MinLength(3)]
        [RegularExpression("^[^0-9]*$", ErrorMessage = "Nie można wprowadzać cyfr.")]
        public string LastName { get; set; }

    }
}
