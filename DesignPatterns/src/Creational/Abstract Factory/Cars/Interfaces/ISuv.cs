namespace DesignPatterns.src.Creational.Abstract_Factory.Cars.Interfaces
{
    /// <summary>
    /// ISuv represent properties specific for coupe type of car
    /// </summary>
    public interface ISuv : ICar
    {
        bool HasDiferentialLock { get; }
    }
}
