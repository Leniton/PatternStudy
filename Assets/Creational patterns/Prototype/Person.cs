using System;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Creational.Prototype
{
    public class Person
    {
        public int Age;
        public DateTime BirthDate;
        public string Name;
        public Id_Info Id_Info;

        public Person ShallowCopy()
        {
            return (Person)MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person clone = (Person)MemberwiseClone();
            clone.Id_Info = new Id_Info(Id_Info.IdNumber);
            clone.Name = String.Copy(Name);
            return clone;
        }
    }
}