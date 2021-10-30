using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Models {
public class Interest {
    [JsonPropertyName("type")]
    public string Type { get; set; }
    [JsonPropertyName("description")]
    public string Description { get; set; }
}
}