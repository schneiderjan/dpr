﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DprFactoryPattern.CarParts;
using DprFactoryPattern.Hannover;

namespace DprFactoryPattern.Factories
{
    public class HannoverFactory: IFactory
    {
        public IHood CreateHood()
        {
            return new GolfHood();
        }

        public IComponent CreateAxe()
        {
            return new GolfAxe();
        }

        public IInterior CreateInterior()
        {
            return new GolfInterior();
        }
    }
}
