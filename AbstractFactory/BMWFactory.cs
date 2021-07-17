using AbstractFactory.CarParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class BMWFactory : ICarFactory
    {
        public IEngine CreateEnginer()
        {
            return new BMWEngine();
        }

        public ISteeringWheel CreateSteeringWheel()
        {
            return new BMWSteeringWheel();
        }

        public IWheel CreateWheel()
        {
            return new BMWWheel();
        }
    }
}
