﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DprFactoryPattern.CarParts;

namespace DprFactoryPattern.Hannover
{
    public class GolfAxe : IComponent
    {

        public string GetName()
        {
            return "GolfAxe";
        }

        public int GetPrice()
        {
            return 2420;
        }
    }
}
