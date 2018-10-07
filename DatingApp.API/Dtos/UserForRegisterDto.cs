using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]       
        public string Username { get; set; }

        [Required]
        [StringLength(int.MaxValue, MinimumLength = 8, ErrorMessage = "Your password must be at least 8 characters")]
        public string Password { get; set; }
    }
}