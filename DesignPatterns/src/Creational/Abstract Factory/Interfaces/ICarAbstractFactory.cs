using DesignPatterns.src.Creational.Abstract_Factory.Cars.Interfaces;

namespace DesignPatterns.src.Creational.Abstract_Factory.Interfaces
{
    /// <summary>
    /// Abstract factory which define what every factory need to implement to be factory (our cases)
    /// </summary>
    public interface ICarAbstractFactory
    {
        ICoupe CreateCoupe();

        IHatchback CreateHatchback();

        ISuv CreateSuv();
    }
}
