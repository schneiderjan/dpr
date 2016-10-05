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

        public void NextState(State state)
        {
            if (state != null) currentState = state;
        }

        public string GetStateAction()
        {
            return currentState.GetAction();
        }

        public void Pull()
        {
            currentState.Pull(this);
        }
    }
}