﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DprFactoryPattern.CarParts;

namespace DprFactoryPattern.Hannover
{
    public class GolfInterior : IComponent
    {
        public string GetName()
        {
            return "GolfInterior";
        }

        public int GetPrice()
        {
            return 7500;
        }
    }
}
