using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DprStatePattern
{
    public abstract class State : IState
    {
        public void Pull(ProductionChain prodChain)
        {
            prodChain.NextState(new Terminated());
        }
    }
}
