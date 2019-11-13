using Allure.Commons;
using FluentAssertions;
using FluentAssertions.Execution;
using Newtonsoft.Json;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using QaTechTest.Context;
using QaTechTest.Model;
using QaTechTest.ServiceClient.Interface;
using TechTalk.SpecFlow;

namespace QaTechTest.Features.Products
{
    [TestFixture]
    [AllureNUnit]
    [AllureDisplayIgnored]
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
        [Test(Description = "Specfflow")]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("User")]
        [AllureSuite("PassedSuite")]
        [AllureSubSuite("Assert")]
        [StepDefinition(@"I should get a successful (.*) response")]
        public void ThenIShouldGetASuccessfulOKResponse(string statusCode)
        {
            var status = _productContext.ResponseMessage.StatusCode.ToString();
            status.Should().Be(statusCode);
        }
        [Test(Description = "XXX")]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("User")]
        [AllureSuite("PassedSuite")]
        [AllureSubSuite("NoAssert")]
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
