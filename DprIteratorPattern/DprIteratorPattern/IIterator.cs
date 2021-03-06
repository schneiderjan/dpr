﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DprIteratorPattern
{
    public interface IIterator
    {
        bool HasNext();
        bool HasPrevious();
        object Next();
        object Previous();
    }
}
