
namespace CulinaryGuide.API.Models
{

    public class User
    {
        public int id{get; set;}

        public string Username {get; set;}

        public byte[] PasswordHash{get; set;}

        public byte[] PasswordSalt{get; set;}

        public string Gender{get; set;}

        public System.DateTime DateOfBirth {get; set;}

        public string KnownAs{get; set;}

        public System.DateTime Created {get; set;}

        public System.DateTime LastActive {get; set;}

        
    }
}
    
