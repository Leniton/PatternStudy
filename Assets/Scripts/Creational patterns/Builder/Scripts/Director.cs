using UnityEngine;

namespace Patterns.Creational.Builder
{
    public class Director
    {
        IBuilder builder;

        public IBuilder Builder
        {
            set { builder = value; }
        }

        public void BuildMinimumViableProduct()
        {
            builder.StepA();
        }

        public void BuildFullProduct()
        {
            builder.StepA();
            builder.StepB();
            builder.StepC();
        }
    }
}