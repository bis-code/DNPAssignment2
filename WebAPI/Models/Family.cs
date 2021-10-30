using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Models {
    public class Family {
    
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("photo")]
        public string Photo  { get; set; }
        [JsonPropertyName("streetName")]

        public string StreetName { get; set; }
        [JsonPropertyName("houseNumber")]
        public int HouseNumber{ get; set; }
        [JsonPropertyName("adults")]
        public List<Adult> Adults { get; set; }
        [JsonPropertyName("children")]
        public List<Child> Children{ get; set; }
        [JsonPropertyName("pets")]
        public List<Pet> Pets{ get; set; }

        public Family() {
            Adults = new List<Adult>();     
        }
    }


}