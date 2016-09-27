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
        public void PoloPartsAreValid_Test()
        {
            //Arrange
            var polo = new Polo(new WolfsburgFactory());

            //Act
            polo.Assemble();

            //Assert
            Assert.AreEqual()
        }
    }
}
