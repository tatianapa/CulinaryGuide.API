namespace CulinaryGuide.API.Dtos
{
    public class UserForList
    {
         public int id{get; set;}

        public string Username {get; set;}


        public string Gender{get; set;}

        public int Age {get; set;}

        public string KnownAs{get; set;}

        public System.DateTime Created {get; set;}

        public System.DateTime LastActive {get; set;}

        
    }
}