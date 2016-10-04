using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DprIteratorPattern
{
    public class Channel
    {
        public string Name { get; set; }

        public Channel(string _name)
        {
            Name = _name;
        }
    }
}
