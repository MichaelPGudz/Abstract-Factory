using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CarParts
{
    class FordWheel : IWheel
    {
        public void PrintDiameter()
        {
            Console.WriteLine($"{GetType().Name} has 17\" Wheel");
        }

        public void PrintTireType()
        {
            Console.WriteLine($"{GetType().Name} has Pirelli Tires");
        }
    }
}
