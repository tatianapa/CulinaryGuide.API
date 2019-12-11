using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace CulinaryGuide.API.Models
{
    public class Place
    {
          public int PlaceId{get; set;}
          public string Name {get; set;}

          public string PhotoLocation {get; set;}
          
          public string Description {get; set;}


        [JsonIgnore]
        public IEnumerable<TagPlace> tagPlaces{ get; set; }
    }
}