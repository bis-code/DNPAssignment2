using System.Text.Json.Serialization;

namespace Models {
public class Adult : Person {
    [JsonPropertyName("jobTitle")]
    public Job JobTitle { get; set; }

    public Adult()
    {
        JobTitle = new Job();
    }
}
}