using System.ComponentModel.DataAnnotations;

namespace Jwt_Practice.Models
{
    public class RegisterRequest
    {
        [Required]
        [EmailAddress]
        [MinLength(15)]
        public string Email { get; set; }

        [Required]
        [Length(5, 20)]
        public string Password { get; set; }
    }
}
