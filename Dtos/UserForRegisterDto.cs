using System;
using System.ComponentModel.DataAnnotations;

namespace CulinaryGuide.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username {get; set;}
        
        [Required]
        [StringLength(10, MinimumLength = 8, ErrorMessage = "You must specify password between 8 and 10 characters")]
        public string Password {get; set;}

        [Required]
        public string Gender { get; set; }
        
        [Required]
        public string KnownAs { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }

        public UserForRegisterDto()
        {
            Created = DateTime.Now;
            LastActive = DateTime.Now;
        }
    }
}