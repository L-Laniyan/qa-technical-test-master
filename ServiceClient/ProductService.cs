using System.Net.Http;
using QaTechTest.ServiceClient.Interface;
using Newtonsoft.Json;
using QaTechTest.Model;
using RestSharp;

namespace QaTechTest.ServiceClient
{
   public class ProductService :IProductService
    {

        HttpClient client = new HttpClient();

        public IRestResponse AddProduct(string name, decimal price)
        {

            var client = new RestClient("http://localhost:5000/v1/product");

            var request = new RestRequest(Method.POST);

            request.AddParameter("application/json; Encoding.UTF8", JsonConvert.SerializeObject(new Product() { Name = name, Price = price }), ParameterType.RequestBody);

            var response = client.ExecutePostTaskAsync<Product>(request).GetAwaiter().GetResult();

            return response;

        }

        public IRestResponse DeleteProduct(string product_code)
        {

            var client = new RestClient(string.Format("http://localhost:5000/v1/product/{0}",product_code));

            var request = new RestRequest(Method.DELETE);

            var response = client.ExecuteTaskAsync<Product>(request).GetAwaiter().GetResult();

            return response;

        }


        public IRestResponse GetProductByProductCode(string product_code)
        {

            var client = new RestClient(string.Format("http://localhost:5000/v1/product/{0}", product_code));

            var request = new RestRequest(Method.GET);

            var response = client.ExecuteGetTaskAsync<Product>(request).GetAwaiter().GetResult();

            return response;

        }

        public IRestResponse GetAllProducts()
        {

            var client = new RestClient("http://localhost:5000/v1/products");

            var request = new RestRequest(Method.GET);

            var response = client.ExecuteGetTaskAsync<Product>(request).GetAwaiter().GetResult();

            return response;

        }

        public IRestResponse UpdateProduct(string product_code, string name, decimal price)
        {

            var client = new RestClient(string.Format("http://localhost:5000/v1/product/{0}", product_code));

            var request = new RestRequest(Method.PUT);

            request.AddParameter("application/json; Encoding.UTF8", JsonConvert.SerializeObject(new Product() { Name = name, Price = price }), ParameterType.RequestBody);

            var response = client.ExecuteTaskAsync<Product>(request).GetAwaiter().GetResult();

            return response;

        }
    }
}
