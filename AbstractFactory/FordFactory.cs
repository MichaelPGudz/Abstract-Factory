using AbstractFactory.CarParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class FordFactory : ICarFactory
    {
        public IEngine CreateEnginer()
        {
            return new FordEngine();
        }

        public ISteeringWheel CreateSteeringWheel()
        {
            return new FordSteeringWheel();
        }

        public IWheel CreateWheel()
        {
            return new FordWheel();
        }
    }
}
