using System;
using DesignPatterns.src.Creational.Abstract_Factory;
using DesignPatterns.src.Creational.Factory_Method;
using DesignPatterns.src.Creational.Factory_Method.Creators;
using DesignPatterns.src.Creational.Factory_Method.Enums;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hey client, I am interested in VolkswagenFactory, give me what it contains !
            // Client client = new Client(new VolkswagenFactory());
            // Console.WriteLine(client.Suv.Name);

            Creator creator = new Creator();
            CellPhone cellPhone = creator.Factory(PhoneManufacturer.Samsung);

            Console.WriteLine(cellPhone);
        }
    }
}
