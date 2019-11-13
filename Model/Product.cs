using Newtonsoft.Json;


namespace QaTechTest.Model
{
   public class Product
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("price")]
        public decimal Price { get; set; }

        [JsonProperty("product_code")]
        public int Product_code { get; set; }

        [JsonProperty("product_price")]
        public decimal Product_Price { get; set; }

        [JsonProperty("job")]
        public string Job { get; set; }

        [JsonProperty("detail")]
        public string Detail { get; set; }
    }
}
