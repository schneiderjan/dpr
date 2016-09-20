using System;
using DprDecoratorPattern;
using DprDecoratorPattern.PizzaExtras;
using DprDecoratorPattern.Pizzas;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace DprDecoratorPatternTest
{
    [TestClass]
    public class VerdureTest
    {
        private static Pizza _pizza;
        private static double expectedCost;

        [TestMethod]
        public void VerdureAllExtras_Test()
        {

            //Arrange
            _pizza = new Verdura();
            expectedCost = 28.25;

            //Act
            _pizza = new Gorgonzola(_pizza);
            _pizza = new Rucola(_pizza);
            _pizza = new Garlic(_pizza);
            _pizza = new Parmezan(_pizza);
            _pizza = new DprDecoratorPattern.PizzaExtras.Salami(_pizza);
            _pizza = new Gorgonzola(_pizza);
            _pizza = new Rucola(_pizza);
            _pizza = new Garlic(_pizza);
            _pizza = new Parmezan(_pizza);
            _pizza = new DprDecoratorPattern.PizzaExtras.Salami(_pizza);

            //Assert
            Assert.AreEqual(expectedCost, _pizza.Cost());
        }
    }
}
