using AbstractFactory.CarParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class AssemblyLine
    {
        private readonly ICarFactory _carFactory;

        public AssemblyLine(ICarFactory carFactory)
        {
            _carFactory = carFactory;
        }
        public void createCar()
        {
            IEngine engine = _carFactory.CreateEnginer();
            ISteeringWheel steeringWheel = _carFactory.CreateSteeringWheel();
            IWheel wheel = _carFactory.CreateWheel();

            engine.PrintCylinderNumber();
            engine.PrintPower();

            steeringWheel.PrintLogo();
            steeringWheel.PrintMaterial();

            wheel.PrintDiameter();
            wheel.PrintTireType();
        }
    }
}
