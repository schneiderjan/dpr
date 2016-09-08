using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DprStrategyPattern
{
    /// <summary>
    /// Holds read requests
    /// Current read request and previous
    /// </summary>
    public class Request
    {
        public int Current { get; set; }
        public int Previous { get; set; }
    }
}
