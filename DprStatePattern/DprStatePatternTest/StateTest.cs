using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DprStatePattern;
using System.Collections.Generic;

namespace DprStatePatternTest
{
    [TestClass]
    public class StateTest
    {
        private static ProductionChain prodChain;

        [TestMethod]
        public void StatesValidOrder_Test()
        {
            //Arrange
            prodChain = new ProductionChain();
            List<State> actualStates = new List<State>();
            List<State> expectedStates = new List<State>
            {
                new Initialized(),
                new PreManufacturing(),
                new Manufacturing(),
                new PostManufacturing(),
                new Terminated()
            };

            //Act
            while (!(prodChain.GetState() is Terminated))
            {
                prodChain.Pull();
                actualStates.Add(prodChain.GetState());
            }

            //Assert
            CollectionAssert.AreEqual(expectedStates, actualStates, new StateComparer());
        }
    }
}
