﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DprFactoryPattern.CarParts
{
    public interface IComponent
    {
        string GetName();
        int GetPrice();
    }
}
