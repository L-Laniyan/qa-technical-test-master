using QaTechTest.Context;
using QaTechTest.ServiceClient.Interface;
using TechTalk.SpecFlow;

namespace QaTechTest.Features.Products
{
    [Binding]
    public sealed class DeleteProductSteps
    {
        private readonly IProductService _productService;

        private readonly ProductContext _productContext;


        public DeleteProductSteps(IProductService productService, ProductContext productContext)
        {
            _productService = productService;
            _productContext = productContext;
        }
        [StepDefinition(@"I specify product code (.*) to delete")]
        public void WhenIAddTheProductCode(int product_code)
        {
            var response = _productService.DeleteProduct(product_code.ToString());
            _productContext.ResponseMessage = response;
        }
    }
}

