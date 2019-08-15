using NUnit.Framework;
using System.Collections.Generic;
using static csharp.KeyItemConstantsClass;

namespace csharp.Tests
{
    [TestFixture]
    public class ItemBrieRulesTest
    {
        [Test]
        public void GivenItemBrie_WhenNextDayComes_QualityLessThan50_SellInHigherThan0_ThenQualityShouldIncreaseByOne()
        {
            // Arrange
            var item = new Item() { Name = AgedBrie, Quality = 49, SellIn = 1 };
            
            // Act
            var actual = new GildedRose(new List<Item> { item });
            actual.UpdateQuality();

            // Assert
            Assert.AreEqual(50, item.Quality);
        }

        [Test]
        public void GivenItemBrie_WhenNextDayComes_QualityEquals50_SellInHigherThan0_ThenQualityShouldRemain50()
        {
            // Arrange
            var item = new Item() { Name = AgedBrie, Quality = 50, SellIn = 1 };

            // Act
            var actual = new GildedRose(new List<Item> { item });
            actual.UpdateQuality();

            // Assert
            Assert.AreEqual(50, item.Quality);
        }

        [Test]
        public void GivenItemBrie_WhenNextDayComes_QualityLessThan50_SellInEquals0_ThenQualityShouldIncreaseByTwo()
        {
            // Arrange
            var item = new Item() { Name = AgedBrie, Quality = 10, SellIn = 0 };

            // Act
            var actual = new GildedRose(new List<Item> { item });
            actual.UpdateQuality();

            // Assert
            Assert.AreEqual(12, item.Quality);
        }

        [Test]
        public void GivenItemBrie_WhenNextDayComes_QualityLessThan50_SellInLessThan0_ThenQualityShouldIncreaseByTwo()
        {
            // Arrange
            var item = new Item() { Name = AgedBrie, Quality = 22, SellIn = -3 };

            // Act
            var actual = new GildedRose(new List<Item> { item });
            actual.UpdateQuality();

            // Assert
            Assert.AreEqual(24, item.Quality);
        }
    }
}