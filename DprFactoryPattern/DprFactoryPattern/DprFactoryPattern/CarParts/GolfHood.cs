﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DprFactoryPattern.CarParts;

namespace DprFactoryPattern.Hannover
{
    public class GolfHood : IComponent
    {
        public string GetName()
        {
            return "GolfHood";
        }

        public int GetPrice()
        {
            return 600;
        }
    }
}
