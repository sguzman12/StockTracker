using Microsoft.VisualStudio.TestTools.UnitTesting;
using StockTrackerAPI.Models;

namespace StockTests
{
    [TestClass]
    public class RandomizePriceTest
    {
        [TestMethod]
        public void CheckRandomizerRange() 
        {
            // Arrange
            decimal priceToTest = 143.45M;
            PriceRandomizer ran = new PriceRandomizer();

            // Act
            ran.RandomizePrice(priceToTest);

            // Assert

        }
    }
}
