using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CarParts
{
    class BMWSteeringWheel : ISteeringWheel
    {
        public void PrintLogo()
        {
            Console.WriteLine($"{GetType().Name} has Circular Logo Type");
        }

        public void PrintMaterial()
        {
            Console.WriteLine($"{GetType().Name} has leather steering wheel");
        }
    }
}
