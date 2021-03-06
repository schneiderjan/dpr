﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DprStatePattern
{
  public  class Idle : State
    {
        public Idle()
        {
            Action = "Idle";
        }

        public override void Pull(ProductionChain prodChain)
        {
            prodChain.NextState(new Initialized());
        }

    }
}
