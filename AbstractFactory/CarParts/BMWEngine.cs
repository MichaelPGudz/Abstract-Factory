using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CarParts
{
    class BMWEngine : IEngine
    {
        public void PrintCylinderNumber()
        {
            Console.WriteLine($"{GetType().Name} has 4 cylinders.");
        }

        public void PrintPower()
        {
            Console.WriteLine($"{GetType().Name} has 200 HP.");
        }
    }
}
