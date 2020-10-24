using System;
using DesignPatterns.src.Creational.Abstract_Factory;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hey client, I am interested in VolkswagenFactory, give me what it contains !
            Client client = new Client(new VolkswagenFactory());
            Console.WriteLine(client.Suv.Name);
        }
    }
}
