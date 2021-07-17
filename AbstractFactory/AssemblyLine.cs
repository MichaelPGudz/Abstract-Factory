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
        //private readonly ICarFactory _carFactory;

        //public AssemblyLine(ICarFactory carFactory)
        //{
        //    _carFactory = carFactory;
        //}
        public void CreateCar(string brand)
        {
            ICarFactory carType = CarFactoryFactory.CreateCarFactory(brand);
            IEngine engine = carType.CreateEnginer();
            ISteeringWheel steeringWheel = carType.CreateSteeringWheel();
            IWheel wheel = carType.CreateWheel();

            engine.PrintCylinderNumber();
            engine.PrintPower();

            steeringWheel.PrintLogo();
            steeringWheel.PrintMaterial();

            wheel.PrintDiameter();
            wheel.PrintTireType();
        }

    }
}
