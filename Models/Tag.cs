using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace CulinaryGuide.API.Models
{
    public class Tag
    {
        public int TagId{ get; set; }
        public string color {get; set;}

        public string text {get; set;}
        [JsonIgnore]
        public IEnumerable<TagPlace> tagPlaces{ get; set; }
    }
}