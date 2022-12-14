using System.Text.Json;
using System.Text.Json.Serialization;

namespace NiceCrafts_Website.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Maker { get; set; }

        [JsonPropertyName("img")]
        public string Image { get; set; }

        public string Url { get; set; }
        public string Description { get; set; }


        public int[] Ratings { get; set; }

        // toString method that overrides the standard procedure
        public override string ToString() =>
            JsonSerializer.Serialize<Product>(this);




    }
}
