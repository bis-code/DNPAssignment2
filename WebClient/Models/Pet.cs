using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Models {
public class Pet {
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("species")]
    public string Species { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("age")]
    public int Age { get; set; }
}
}