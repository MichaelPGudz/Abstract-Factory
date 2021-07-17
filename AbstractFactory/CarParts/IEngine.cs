﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CarParts
{
    interface IEngine
    {
        void PrintPower();
        void PrintCylinderNumber();
    }
}