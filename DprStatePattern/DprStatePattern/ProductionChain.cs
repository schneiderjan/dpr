using System;

namespace DprStatePattern
{
    public class ProductionChain
    {
        private State currentState;

        public ProductionChain()
        {
            currentState = new Terminated();
        }

        internal void NextState(State state)
        {
            currentState = state;
        }

        internal void Pull()
        {
            currentState.Pull(this);
        }
    }
}