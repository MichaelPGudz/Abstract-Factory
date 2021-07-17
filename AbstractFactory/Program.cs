using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            AssemblyLine bmwAssembly = new AssemblyLine(new BMWFactory());
            AssemblyLine fordAssembly = new AssemblyLine(new FordFactory());
            bmwAssembly.createCar();
            fordAssembly.createCar();

        }
    }
}
