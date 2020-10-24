using DesignPatterns.src.Creational.Abstract_Factory.Cars;
using DesignPatterns.src.Creational.Abstract_Factory.Cars.Interfaces;
using DesignPatterns.src.Creational.Abstract_Factory.Interfaces;

namespace DesignPatterns.src.Creational.Abstract_Factory
{
    public class HondaFactory : ICarAbstractFactory
    {
        public ICoupe CreateCoupe()
        {
            return new Coupe("Civic");
        }

        public IHatchback CreateHatchback()
        {
            return new Hatchback("Accord");
        }

        public ISuv CreateSuv()
        {
            return new Suv("CR-V", true);
        }
    }
}
