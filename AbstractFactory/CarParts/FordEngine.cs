using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CarParts
{
    class FordEngine : IEngine
    {
        public void PrintCylinderNumber()
        {
            Console.WriteLine($"{GetType().Name} has 2 cylinders.");
        }

        public void PrintPower()
        {
            Console.WriteLine($"{GetType().Name} has 150 HP.");
        }
    }
}
