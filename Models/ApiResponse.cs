using System.Text.Json.Serialization;

namespace BhamBands.Models
{
    public class ApiResponse
    {
        [JsonPropertyName("_embedded")]
        public Embedded Embedded { get; set; }
        public Links links { get; set; }
    }
}
