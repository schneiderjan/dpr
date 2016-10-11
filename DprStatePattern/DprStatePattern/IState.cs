using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DprStatePattern
{
    public interface IState
    {
        void Pull(ProductionChain prodChain);

        State GetState();
    }
}
