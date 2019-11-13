using FluentAssertions;
using Newtonsoft.Json;
using QaTechTest.Context;
using QaTechTest.ServiceClient.Interface;
using QaTechTest.Model;
using TechTalk.SpecFlow;
using System;
using FluentAssertions.Execution;
using System.Collections.Generic;

namespace QaTechTest.Features.Products
{
    [Binding]
    public sealed class AddProductSteps
    {

        private readonly IProductService _productService;

        private readonly ProductContext _productContext;

        
        public AddProductSteps(IProductService productService, ProductContext productContext)
        {
            _productService = productService;
            _productContext = productContext;
        }


        [StepDefinition(@"I specify product I want to add")]
        public void WhenISpecifyProductIWantToAdd(Product product)
        {
            
            var response = _productService.AddProduct(product.Name, product.Price);
            _productContext.ResponseMessage = response; 
        }     
    }
}
