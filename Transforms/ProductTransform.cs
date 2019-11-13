using QaTechTest.Model;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace QaTechTest.Transforms
{
    [Binding]
    public class ProductTransform
    {
        [StepArgumentTransformation]
        public Product TransfromToNewProduct(Table table)
        {
            return table.CreateInstance<Product>();
        }

        [StepArgumentTransformation]
        public ProductArray TransfromToNewProducts(Table table)
        {
            return table.CreateInstance<ProductArray>();
        }
    }
}
