using DesignPatterns.src.Creational.Abstract_Factory.Cars;
using DesignPatterns.src.Creational.Abstract_Factory.Cars.Interfaces;
using DesignPatterns.src.Creational.Abstract_Factory.Interfaces;

namespace DesignPatterns.src.Creational.Abstract_Factory
{
    public class VolkswagenFactory : ICarAbstractFactory
    {
        public ICoupe CreateCoupe()
        {
            return new Coupe("Scirocco");
        }

        public IHatchback CreateHatchback()
        {
            return new Hatchback("Golf");
        }

        public ISuv CreateSuv()
        {
            return new Suv("Touareg", true);
        }
    }
}
