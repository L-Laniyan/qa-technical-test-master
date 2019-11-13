using QaTechTest.Context;
using QaTechTest.ServiceClient.Interface;
using TechTalk.SpecFlow;

namespace QaTechTest
{
    [Binding]
    public class GetProductByProductCodeSteps
    {
        private readonly IProductService _productService;

        private readonly ProductContext _productContext;


        public GetProductByProductCodeSteps(IProductService productService, ProductContext productContext)
        {
            _productService = productService;
            _productContext = productContext;
        }
        [StepDefinition(@"I specify product code (.*)")]
        public void WhenISpecifyProductCode(int product_code)
        {
            var response = _productService.GetProductByProductCode(product_code.ToString());
            _productContext.ResponseMessage = response;
        }
    }
}

