using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Creational.Builder
{
    public class Product
    {
        List<object> parts = new List<object>();

        public void Add(object part)
        {
            parts.Add(part);
        }

        public void ListParts()
        {
            string result = string.Empty;

            for (int i = 0; i < parts.Count; i++)
            {
                result += $"{parts[i].ToString()}, ";
            }

            result = result.Remove(result.Length - 2, 2);

            Debug.Log($"Product contains: {result}");
        }
    }
}