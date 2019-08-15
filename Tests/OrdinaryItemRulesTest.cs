using NUnit.Framework;
using System.Collections.Generic;

namespace csharp.Tests
{
    [TestFixture]
    public class OrdinaryItemRulesTest
    {
        [Test]
        public void GivenOrdinaryItem_WhenNextDayComes_QualityHigherThan0_SellInHigherThan0_ThenQualityShouldDecreaseByOne()
        {
            // Arrange
            var item = new Item() { Name = "Ordinary Item", Quality = 10, SellIn = 1 };

            // Act
            var actual = new GildedRose(new List<Item> { item });
            actual.UpdateQuality();

            // Assert
            Assert.AreEqual(9, item.Quality);
        }

        [Test]
        public void GivenOrdinaryItem_WhenNextDayComes_QualityEquals0_SellInHigherThan0_ThenQualityShouldRemain0()
        {
            //  Arrange
            var item = new Item() { Name = "Ordinary Item", Quality = 0, SellIn = 1 };

            // Act
            var actual = new GildedRose(new List<Item> { item });
            actual.UpdateQuality();

            // Assert
            Assert.AreEqual(0, item.Quality);
        }

        [Test]
        public void GivenOrdinaryItem_WhenNextDayComes_QualityHigherThan2_SellInEquals0_ThenQualityShouldDecreaseByTwo()
        {
            // Arrange
            var item = new Item() { Name = "Ordinary Item", Quality = 35, SellIn = 0 };

            // Act
            var actual = new GildedRose(new List<Item> { item });
            actual.UpdateQuality();

            // Assert
            Assert.AreEqual(33, item.Quality);
        }
        
        [Test]
        public void GivenOrdinaryItem_WhenNextDayComes_QualityHigherThan2_SellInLessThan0_ThenQualityShouldDecreaseByTwo()
        {
            // Arrange
            var item = new Item() { Name = "Ordinary Item", Quality = 11, SellIn = -1 };

            // Act
            var actual = new GildedRose(new List<Item> { item });
            actual.UpdateQuality();

            // Assert
            Assert.AreEqual(9, item.Quality);
        }

        [Test]
        public void GivenOrdinaryItem_WhenNextDayComes_QualityEquals1_SellInLessThan0_ThenQualityShouldBe0()
        {
            // Arrange
            var item = new Item() { Name = "Ordinary Item", Quality = 1, SellIn = -1 };

            // Act
            var actual = new GildedRose(new List<Item> { item });
            actual.UpdateQuality();

            // Assert
            Assert.AreEqual(0, item.Quality);
        }
    }
}