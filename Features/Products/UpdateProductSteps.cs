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
            if (product.Name != null)
            {
                var response = _productService.UpdateProduct(product_code.ToString(), product.Name, product.Price);
                _productContext.ResponseMessage = response;
            }
            else 
            {
                var response = _productService.UpdateProductPrice(product_code.ToString(), product.Price);
                _productContext.ResponseMessage = response;
            }
        }

        [StepDefinition(@"I dont specify the product code")]
        public void WhenIDontSpecifyTheProductCode(Product product)
        {
            var response = _productService.UpdateProduct(product.Name, product.Price);
            _productContext.ResponseMessage = response;
        }

    }
}