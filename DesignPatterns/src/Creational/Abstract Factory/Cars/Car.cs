using DesignPatterns.src.Creational.Abstract_Factory.Cars.Interfaces;

namespace DesignPatterns.src.Creational.Abstract_Factory.Cars
{
    /// <summary>
    /// Concrete implementation of ICar and represent basic implementation for all cars
    /// </summary>
    internal class Car : ICar
    {
        private readonly string name;

        public Car(string name)
        {
            this.name = name;
        }

        #region ICar members

        public string Name => this.name;

        #endregion
    }
}
