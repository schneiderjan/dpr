using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DprStatePattern
{
    public class Terminated : State
    {
        public Terminated()
        {
            Action = "Terminated";
        }

        public override void Pull(ProductionChain prodChain) { }
    }
}
