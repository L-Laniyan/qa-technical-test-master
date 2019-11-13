using BoDi;
using QaTechTest.ServiceClient;
using QaTechTest.ServiceClient.Interface;
using TechTalk.SpecFlow;

namespace QaTechTest.Binding
{   
    [Binding]
    public class ContanierSetupBindings
    {
        private readonly IObjectContainer _objectContainer;

        public ContanierSetupBindings(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario] 
        public void InitializeAddProductService()
        {
            IProductService productService = new ProductService();
            _objectContainer.RegisterInstanceAs<IProductService>(productService);
        }
    }
}
