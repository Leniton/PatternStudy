using System;
using UnityEngine;

namespace Patterns.Creational.Prototype
{
    public class Client : IClient
    {
        public void ClientFunction()
        {
            Person p1 = new Person();
            p1.Age = 42;
            p1.BirthDate = Convert.ToDateTime("1977-01-01");
            p1.Name = "Jack Daniels";
            p1.Id_Info = new Id_Info(666);

            // Perform a shallow copy of p1 and assign it to p2.
            Person p2 = (Person)p1.ShallowCopy();
            // Make a deep copy of p1 and assign it to p3.
            Person p3 = (Person)p1.DeepCopy();

            // Display values of p1, p2 and p3.
            Debug.Log("Original values of p1, p2, p3:");
            Debug.Log("   p1 instance values: ");
            DisplayValues(p1);
            Debug.Log("   p2 instance values:");
            DisplayValues(p2);
            Debug.Log("   p3 instance values:");
            DisplayValues(p3);

            // Change the value of p1 properties and display the values of p1,
            // p2 and p3.
            p1.Age = 32;
            p1.BirthDate = Convert.ToDateTime("1900-01-01");
            p1.Name = "Frank";
            p1.Id_Info.IdNumber = 7878;
            Debug.Log("Values of p1, p2 and p3 after changes to p1:");
            Debug.Log("   p1 instance values: ");
            DisplayValues(p1);
            Debug.Log("   p2 instance values (reference values have changed):");
            DisplayValues(p2);
            Debug.Log("   p3 instance values (everything was kept the same):");
            DisplayValues(p3);
        }

        public static void DisplayValues(Person p)
        {
            Debug.Log($"      Name: {p.Name}, Age: {p.Age}, BirthDate: {p.BirthDate}\n      ID#: {p.Id_Info.IdNumber}");
            //Debug.Log($"      ID#: {p.Id_Info.IdNumber}");
        }
    }
}