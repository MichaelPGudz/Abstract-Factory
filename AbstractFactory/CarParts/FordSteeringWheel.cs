using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CarParts
{
    class FordSteeringWheel : ISteeringWheel
    {
        public void PrintLogo()
        {
            Console.WriteLine($"{GetType().Name} has Elliptical Logo Type with Ford name in it.");
        }

        public void PrintMaterial()
        {
            Console.WriteLine($"{GetType().Name} has PCV steering wheel");
        }
    }
}
