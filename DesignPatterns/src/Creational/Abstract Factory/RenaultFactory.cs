using DesignPatterns.src.Creational.Abstract_Factory.Cars;
using DesignPatterns.src.Creational.Abstract_Factory.Cars.Interfaces;
using DesignPatterns.src.Creational.Abstract_Factory.Interfaces;

namespace DesignPatterns.src.Creational.Abstract_Factory
{
    public class RenaultFactory : ICarAbstractFactory
    {
        public ICoupe CreateCoupe()
        {
            return new Coupe("Megane");
        }

        public IHatchback CreateHatchback()
        {
            return new Hatchback("Clio");
        }

        public ISuv CreateSuv()
        {
            return new Suv("Kadjar");
        }
    }
}
