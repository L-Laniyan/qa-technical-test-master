using QaTechTest.Context;
using QaTechTest.Model;
using QaTechTest.ServiceClient.Interface;
using TechTalk.SpecFlow;

namespace QaTechTest.Features.Products
{
    [Binding]
    public sealed class UpdateProductSteps
    {
        private readonly IProductService _productService;

        private readonly ProductContext _productContext;


        public UpdateProductSteps(IProductService productService, ProductContext productContext)
        {
            _productService = productService;
            _productContext = productContext;
        }

        [StepDefinition(@"I specify the product code (.*) to be updated with these details")]
        public void WhenISpecifyTheProductCodeToBeUpdatedWithTheseDetails(int product_code, Product product)
        {
            var response = _productService.UpdateProduct(product_code.ToString(), product.Name, product.Price);
            _productContext.ResponseMessage = response;
        }
    }
}