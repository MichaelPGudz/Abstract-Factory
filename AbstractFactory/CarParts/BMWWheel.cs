using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CarParts
{
    class BMWWheel : IWheel
    {
        public void PrintDiameter()
        {
            Console.WriteLine($"{GetType().Name} has 19\" Wheel");
        }

        public void PrintTireType()
        {
            Console.WriteLine($"{GetType().Name} has Dunlop Tires");
        }
    }
}
