using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class CarFactoryFactory
    {
        public static ICarFactory CreateCarFactory(string brand)
        {
            if (brand == nameof(Brands.BMW))
            {
                return new BMWFactory();
            }
            else if (brand == nameof(Brands.Ford))
            {
                return new FordFactory();
            }
            else
            {
                throw new Exception($"No such brand: {brand}");
            }
        }

    }
}
