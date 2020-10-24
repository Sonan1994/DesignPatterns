using DesignPatterns.src.Creational.Abstract_Factory.Cars.Interfaces;
using DesignPatterns.src.Creational.Abstract_Factory.Interfaces;

namespace DesignPatterns.src.Creational.Abstract_Factory
{
    /// <summary>
    /// Class provided for users of our abstract factory. In this class we define what external user can use.
    /// Think about it as filter of data for external user
    /// User <- Filter (Client class) <- Creating (Factory classes) <- What to create? (Interfaces) 
    /// </summary>
    public sealed class Client 
    {
        private readonly ICoupe coupe;
        private readonly IHatchback hatchback;
        private readonly ISuv suv;

        public Client(ICarAbstractFactory factory)
        {
            // Let's factory decide what need to create, it is not part 
            this.coupe = factory.CreateCoupe();
            this.hatchback = factory.CreateHatchback();
            this.suv = factory.CreateSuv();
        }

        #region Properties

        public ICoupe Coupe =>  this.coupe;

        public IHatchback Hatchback => this.hatchback;

        public ISuv Suv => this.suv;

        #endregion 
    }
}
