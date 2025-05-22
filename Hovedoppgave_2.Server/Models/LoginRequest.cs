using System.ComponentModel.DataAnnotations;

namespace Hovedoppgave_2.Server.Models
{
    public class LoginRequest
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
