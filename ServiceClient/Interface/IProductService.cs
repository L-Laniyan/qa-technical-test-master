using RestSharp;

namespace QaTechTest.ServiceClient.Interface
{
  public  interface IProductService
    {
        IRestResponse AddProduct(string name, decimal price);

        IRestResponse DeleteProduct();

        IRestResponse DeleteProduct(string product_code);

        IRestResponse GetProductByProductCode(string product_code);

        IRestResponse GetAllProducts();

        IRestResponse UpdateProduct(string product_code, string name, decimal price);

        IRestResponse UpdateProduct(string name, decimal price);

        IRestResponse UpdateProductPrice(string product_code, decimal price);
    }
}
