using DesignPatterns.src.Creational.Factory_Method.Enums;

namespace DesignPatterns.src.Creational.Factory_Method.Creators
{
    public class Creator
    {
        public CellPhone Factory(PhoneManufacturer phoneManufacturer)
        {
            switch (phoneManufacturer)
            {
                case PhoneManufacturer.Huawei:
                    return new HuaweiCellPhone(6.2f);
                case PhoneManufacturer.Samsung:
                    return new SamsungCellPhone(6.0f);
                default: 
                    return null;
            }
        }
    }
}