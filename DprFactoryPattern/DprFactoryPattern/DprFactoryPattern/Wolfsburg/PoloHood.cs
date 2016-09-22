﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DprFactoryPattern.CarParts;

namespace DprFactoryPattern.Wolfsburg
{
    public class PoloHood: IHood
    {
        public string Name;
        public PoloHood()
        {
            Name = "Hood type: Polo";
        }
    }
}
