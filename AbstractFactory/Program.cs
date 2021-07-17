using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        { 
            AssemblyLine assembly = new AssemblyLine();
            assembly.CreateCar("BMW");
            assembly.CreateCar("Ford");
        }
    }
}
