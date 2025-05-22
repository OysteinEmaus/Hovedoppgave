using System.ComponentModel.DataAnnotations;

namespace Hovedoppgave_2.Server.Models
{
    public class RegisterRequest
    {
        [Required]
        [MaxLength(100)]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(255)]
        public string Email { get; set; }

        [Required]
        [MinLength(8)]
        public string Password { get; set; }
    }
}
