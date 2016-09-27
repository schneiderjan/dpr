using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DprFactoryPattern;
using DprFactoryPattern.Factories;
using DprFactoryPattern.Wolfsburg;


namespace DprFactoryPatternTest
{
    [TestClass]
    public class PoloTest
    {
        [TestMethod]
        public void PoloPartsAreValidPrice_Test()
        {
            //Arrange
            var polo = new Polo(new WolfsburgFactory());

            //Act
            polo.Assemble();

            //Assert
            Assert.AreEqual(polo.Axe.GetPrice(), 6340);
            Assert.AreEqual(polo.Hood.GetPrice(), 9650);
            Assert.AreEqual(polo.Interior.GetPrice(), 14300);
        }

        [TestMethod]
        public void PoloInDifferentFactory_Test()
        {
            //Arrange
            var polo = new Polo(new HannoverFactory());

            //Act
            polo.Assemble();

            //Assert
            Assert.AreEqual(polo.Axe.GetPrice(), 2420);
            Assert.AreEqual(polo.Hood.GetPrice(), 600);
            Assert.AreEqual(polo.Interior.GetPrice(), 7500);
        }
    }
}
