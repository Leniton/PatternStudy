using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Creational.Prototype
{
    public interface ICopy
    {
        /// <summary>
        /// Creates a copy keeping the references
        /// </summary>
        /// <returns>A copy of the object</returns>
        public ICopy ShallowCopy();

        /// <summary>
        /// Creates a copy with new references
        /// </summary>
        /// <returns>A copy of the object</returns>
        public ICopy DeepCopy();
    }
}