using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DprFactoryPattern;
using DprFactoryPattern.Factories;
using DprFactoryPattern.Wolfsburg;
using DprFactoryPattern.Hannover;

namespace DprFactoryPatternTest
{
    [TestClass]
    public class GolfTest
    {
        [TestMethod]
        public void GolfPartsAreValidPrice_Test()
        {
            //Arrange
            var golf = new Golf(new HannoverFactory());

            //Act
            golf.Assemble();

            //Assert
            Assert.AreEqual(golf.Axe.GetPrice(), 2420);
            Assert.AreEqual(golf.Hood.GetPrice(), 600);
            Assert.AreEqual(golf.Interior.GetPrice(), 7500);
        }

        [TestMethod]
        public void GolfInDifferentFactory_Test()
        {
            //Arrange
            var golf = new Golf(new WolfsburgFactory());

            //Act
            golf.Assemble();

            //Assert
            Assert.AreEqual(golf.Axe.GetPrice(), 6340);
            Assert.AreEqual(golf.Hood.GetPrice(), 9650);
            Assert.AreEqual(golf.Interior.GetPrice(), 14300);
        }
    }
}
