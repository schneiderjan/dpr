using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DprStatePattern
{
    public class PostManufacturing : IState
    {
        public void Pull(ProductionChain prodChain)
        {
            prodChain.NextState( new Terminated());
        }
    }
}
