using UnityEngine;

namespace Patterns.Creational.Builder
{
    public class ConcreteBuilder : IBuilder
    {
        Product product = new Product();

        public ConcreteBuilder()
        {
            Reset();
        }

        void Reset()
        {
            product = new Product();
        }

        public void StepA()
        {
            product.Add("Product PartA");
        }

        public void StepB()
        {
            product.Add("Product PartB");
        }

        public void StepC()
        {
            product.Add("Product PartC");
        }

        public Product GetProduct()
        {
            Product result = product;

            //optional
            Reset();
            result.ListParts();
            return result;
        }
    }
}