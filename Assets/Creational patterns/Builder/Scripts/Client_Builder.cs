using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Creational.Builder
{
    public class Client_Builder : MonoBehaviour
    {
        void Start()
        {
            Director director = new Director();

            MonsterBuilder builder = new();
            director.Builder = builder;

            Debug.Log("Basic Product");
            director.BuildMinimumViableProduct();
            builder.GetProduct().ListParts();

            Debug.Log("Full Product");
            director.BuildFullProduct();
            builder.GetProduct().ListParts();

            Debug.Log("Custom Product");
            builder.StepB();
            builder.StepC();
            builder.GetProduct().ListParts();
        }
    }
}
