namespace CulinaryGuide.API.Models
{
    public class TagPlace
    {
        public int PlaceId {get; set;}

        public Place place {get; set;}

        public int TagId {get; set;}

        public Tag tag {get; set;}
    }
}