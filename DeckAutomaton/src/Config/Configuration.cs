using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DeckAutomaton.Config
{
    public class Configuration
    {
        [JsonPropertyName("url")]
        [Required]
        public required string ApiUrl { get; set; }
        
        [JsonPropertyName("username")]
        [Required]
        public required string Username { get; set; } 

        [JsonPropertyName("password")]
        [Required]
        public required string Password { get; set; } 

        public static Configuration Load(string filename)
        {
            var json = File.ReadAllText(filename);
            return JsonSerializer.Deserialize<Configuration>(json) ?? throw new System.Exception("Failed to load configuration");
        }
    }

    
}