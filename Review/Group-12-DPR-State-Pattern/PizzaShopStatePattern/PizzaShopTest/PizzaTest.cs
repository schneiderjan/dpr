using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaShopStatePattern;

namespace PizzaShopTest
{
    [TestClass]
    public class PizzaTest
    {
        Pizza p = new Pizza(PizzaNames.BBQ.ToString());
        [TestMethod]
        public void OrderStartTest()
        {            
            Assert.IsTrue(p.getState().GetType() == typeof(ProductGatheringState));
        }
        [TestMethod]
        public void GatherTest()
        {
            Assert.IsTrue(p.getState().GetType() == typeof(ProductGatheringState));
            p.Gather();
            Assert.IsTrue(p.getState().GetType() == typeof(CookingState));
        }
        [TestMethod]
        public void CookTest()
        {
            Assert.IsTrue(p.getState().GetType() == typeof(ProductGatheringState));
            p.setState(p.getCookingState());
            Assert.IsTrue(p.getState().GetType() == typeof(CookingState));
            p.Cook();
            Assert.IsTrue(p.getState().GetType() == typeof(PackingState));
        }
        [TestMethod]
        public void PackTest()
        {
            Assert.IsTrue(p.getState().GetType() == typeof(ProductGatheringState));
            p.setState(p.getPackingState());
            Assert.IsTrue(p.getState().GetType() == typeof(PackingState));
            p.Pack();
            Assert.IsTrue(p.getState().GetType() == typeof(DeliveryState));
        }
    }
}
