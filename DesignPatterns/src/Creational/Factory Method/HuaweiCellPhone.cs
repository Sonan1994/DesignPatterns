namespace DesignPatterns.src.Creational.Factory_Method
{
    public sealed class HuaweiCellPhone : CellPhone
    {
        public HuaweiCellPhone(float screenSize)
            : base("Huawei", screenSize)
        {}
    }
}
