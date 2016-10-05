using System;

namespace DprStatePattern
{
    public class ProductionChain
    {
        private State currentState;

        public ProductionChain()
        {
            currentState = new Idle();
        }

        public void NextState(State state)
        {
            if (state != null) currentState = state;
        }

        public State GetState()
        {
            return currentState.GetState();
        }

        public void Pull()
        {
            currentState.Pull(this);
        }
    }
}