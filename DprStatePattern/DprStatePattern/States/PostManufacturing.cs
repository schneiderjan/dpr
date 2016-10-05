using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DprStatePattern
{
    public class PostManufacturing : State
    {
        public PostManufacturing()
        {
            Action = "PostManufacturing";
        }

        public override void Pull(ProductionChain prodChain)
        {
            prodChain.NextState(null);
        }
    }
}
