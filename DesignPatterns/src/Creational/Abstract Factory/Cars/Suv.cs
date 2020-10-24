using DesignPatterns.src.Creational.Abstract_Factory.Cars.Interfaces;

namespace DesignPatterns.src.Creational.Abstract_Factory.Cars
{
    /// <summary>
    /// Concrete implementation of Suv type car
    /// </summary>
    internal class Suv : Car, ISuv
    {
        private readonly bool hasDiferentialLock;

        public Suv(string name, bool hasDiferentialLock = false)
            : base(name)
        {
            this.hasDiferentialLock = hasDiferentialLock;
        }

        #region ISuv members

        public bool HasDiferentialLock => this.hasDiferentialLock;

        #endregion
    }
}
