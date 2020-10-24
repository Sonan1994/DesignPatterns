using DesignPatterns.src.Creational.Abstract_Factory.Cars.Interfaces;

namespace DesignPatterns.src.Creational.Abstract_Factory.Cars
{
    /// <summary>
    /// Concrete implementation of Coupe type car
    /// </summary>
    internal class Coupe : Car, ICoupe
    {
        public Coupe(string name)
            : base(name)
        {}
    }
}
