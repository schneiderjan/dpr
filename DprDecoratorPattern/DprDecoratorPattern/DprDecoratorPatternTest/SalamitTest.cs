using Microsoft.VisualStudio.TestTools.UnitTesting;
using DprDecoratorPattern;
using DprDecoratorPattern.PizzaExtras;
using DprDecoratorPattern.Pizzas;

namespace DprDecoratorPatternTest
{
    [TestClass]
    public class SalamitTest
    {
        private static Pizza _pizza;
        private static double expectedCost;

        [TestMethod]
        public void SalamiAllExtras_Test()
        {
            //Arrange
            _pizza = new DprDecoratorPattern.Pizzas.Salami();
            expectedCost = 30;

            //Act
            _pizza = new DprDecoratorPattern.PizzaExtras.Salami(_pizza);
            _pizza = new Garlic(_pizza);
            _pizza = new Garlic(_pizza);
            _pizza = new Parmezan(_pizza);
            _pizza = new Rucola(_pizza);
            _pizza = new Rucola(_pizza);
            _pizza = new Gorgonzola(_pizza);
            _pizza = new Parmezan(_pizza);
            _pizza = new Gorgonzola(_pizza);
            _pizza = new DprDecoratorPattern.PizzaExtras.Salami(_pizza);

            //Assert
            Assert.AreEqual(expectedCost, _pizza.Cost());
        }
    }
}
