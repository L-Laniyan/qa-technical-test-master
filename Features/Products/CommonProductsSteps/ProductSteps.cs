using FluentAssertions;
using FluentAssertions.Execution;
using Newtonsoft.Json;
using QaTechTest.Context;
using QaTechTest.Model;
using QaTechTest.ServiceClient.Interface;
using TechTalk.SpecFlow;

namespace QaTechTest.Features.Products
{
    
    [Binding]
    public sealed class ProductSteps
    {
        
        private readonly IProductService _productService;

        private readonly ProductContext _productContext;


        public ProductSteps(IProductService productService, ProductContext productContext)
        {
            _productService = productService;
            _productContext = productContext;
        }
        
        
        [StepDefinition(@"I should get a (.*) response status")]
        public void ThenIShouldGetAOKResponseStatus(string statusCode)
        {
            var status = _productContext.ResponseMessage.StatusCode.ToString();
            status.Should().Be(statusCode);
        }
     
        [StepDefinition(@"the response should contain my specify product details")]
        public void ThenTheResponseShouldContainTheFollowingProductDetails(Product product)
        {
            var responseBody = JsonConvert.DeserializeObject<Product>(_productContext.ResponseMessage.Content);

            using (new AssertionScope())
            {
                product.Name.Should().Be(responseBody.Name);
                product.Price.Should().Be(responseBody.Price);
                if(product.Product_code != 0)
                {
                    product.Product_code.Should().Be(responseBody.Product_code);
                }
            }
        }
    }
}
