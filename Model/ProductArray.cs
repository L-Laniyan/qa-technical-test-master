using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace QaTechTest.Model
{
   public class ProductArray
    {
        [JsonProperty("[]")]
        public Product[] ProductList { get; set; }
    }
}
