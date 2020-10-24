using System;
using DesignPatterns.src.Creational.Abstract_Factory.Cars.Interfaces;

namespace DesignPatterns.src.Creational.Abstract_Factory.Cars
{
    /// <summary>
    /// Concrete implementation of Hatchback type car
    /// </summary>
    internal class Hatchback : Car, IHatchback
    {
        public Hatchback(string name)
            : base(name)
        {}
    }
}
