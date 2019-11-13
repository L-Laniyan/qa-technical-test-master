using FluentAssertions;
using FluentAssertions.Execution;
using Newtonsoft.Json;
using QaTechTest.Context;
using QaTechTest.Model;
using QaTechTest.ServiceClient.Interface;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace QaTechTest.Features.Products
{
    [Binding]
    public sealed class GetAllProductSteps
    {
        private readonly IProductService _productService;

        private readonly ProductContext _productContext;


        public GetAllProductSteps(IProductService productService, ProductContext productContext)
        {
            _productService = productService;
            _productContext = productContext;
        }

        [StepDefinition(@"I makes a requset to retrieve all products")]
        public void WhenIMakesARequsetToRetrieveAllProducts()
        {
            var response = _productService.GetAllProducts();
            _productContext.ResponseMessage = response;
        }

        [StepDefinition(@"the response should contain the list of all (.*) products")]
        public void ThenTheResponseShouldContainTheListOfAllProducts(int products, Product product)
        {
            var responseBody = _productContext.ResponseMessage.Content;
            var productList = JsonConvert.DeserializeObject<List<Product>>(responseBody);
            int productCount = 0;
            for (int i = 0; i < productList.Count; i++)
            {
               productCount ++;
            }
            using (new AssertionScope())
            {
                Console.WriteLine(responseBody);
                products.Should().Be(productCount);
                var responseProduct = productList[productCount-=1];
                product.Name.Should().Be(responseProduct.Name);
                product.Price.Should().Be(responseProduct.Price);
                product.Product_code.Should().Be(responseProduct.Product_code);
            }
        }


    }
}
