using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "You must set Name length 2 and 50 characters")]
        public string Username{get;set;}
        [Required]
        [StringLength(8, MinimumLength =  4, ErrorMessage = "You must specify password between 4 and 8 characters")]
        public string Password { get; set; }
    }
}