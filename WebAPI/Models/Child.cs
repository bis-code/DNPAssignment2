using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Models {
public class Child : Person {
    
    [JsonPropertyName("interests")]
    public List<Interest> Interests { get; set; }
    [JsonPropertyName("pets")]
    public List<Pet> Pets { get; set; }
}
}