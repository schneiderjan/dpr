using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DprStatePattern
{
    public abstract class State : IState
    {
        public string Action = "---";

        public virtual State GetState()
        {
            return this;
        }

        public abstract void Pull(ProductionChain prodChain);
    }
}
