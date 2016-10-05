using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DprStatePattern
{
    public abstract class State : IState
    {
        public string Action = "Terminated";

        public virtual void Pull(ProductionChain prodChain)
        {
            prodChain.NextState(new Terminated());
        }

        public string GetAction()
        {
            return Action;
        }
    }
}
