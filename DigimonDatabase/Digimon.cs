namespace DigimonFacts;
using System.Text.Json.Serialization;

public class Digimon
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
}