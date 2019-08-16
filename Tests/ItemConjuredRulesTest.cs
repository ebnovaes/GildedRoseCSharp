using NUnit.Framework;
using System.Collections.Generic;
using static csharp.KeyItemConstantsClass;

namespace csharp.Tests
{
    [TestFixture]
    public class ItemConjuredRulesTest
    {
        [Test]
        public void GivenConjuredItem_WhenNextDayComes_QualityHigherThan2_SellInHigherThan0_ThenQualityShouldDecreaseByTwo()
        {
            // Arrange
            var item = new Item() { Name = Conjured, Quality = 10, SellIn = 1 };

            // Act
            var actual = new GildedRose(new List<Item> { item });
            actual.UpdateQuality();

            // Assert
            Assert.AreEqual(8, item.Quality);
        }

        [Test]
        public void GivenConjuredItem_WhenNextDayComes_QualityLessThan2_SellInHigherThan0_ThenQualityShouldBe0()
        {
            // Arrange
            var item = new Item() { Name = Conjured, Quality = 1, SellIn = 1 };

            // Act
            var actual = new GildedRose(new List<Item> { item });
            actual.UpdateQuality();

            // Assert
            Assert.AreEqual(0, item.Quality);
        }

        [Test]
        public void GivenConjuredItem_WhenNextDayComes_QualityHigherThan4_SellInEquals0_ThenQualityShouldBeDecreasedByFour()
        {
            // Arrange
            var item = new Item() { Name = Conjured, Quality = 6, SellIn = 0 };

            // Act
            var actual = new GildedRose(new List<Item> { item });
            actual.UpdateQuality();

            // Assert
            Assert.AreEqual(2, item.Quality);
        }

        [Test]
        public void GivenConjuredItem_WhenNextDayComes_QualityHigherThan4_SellInLessThan0_ThenQualityShouldBeDecreasedByFour()
        {
            // Arrange
            var item = new Item() { Name = Conjured, Quality = 8, SellIn = -1 };

            // Act
            var actual = new GildedRose(new List<Item> { item });
            actual.UpdateQuality();

            // Assert
            Assert.AreEqual(4, item.Quality);
        }

        [Test]
        public void GivenConjuredItem_WhenNextDayComes_QualityLessThan4_SellInEquals0_ThenQualityShouldBe0()
        {
            // Arrange
            var item = new Item() { Name = Conjured, Quality = 3, SellIn = 0 };

            // Act
            var actual = new GildedRose(new List<Item> { item });
            actual.UpdateQuality();

            // Assert
            Assert.AreEqual(0, item.Quality);
        }

        [Test]
        public void GivenConjuredItem_WhenNextDayComes_QualityLessThan4_SellInLessThan0_ThenQualityShouldBe0()
        {
            // Arrange
            var item = new Item() { Name = Conjured, Quality = 3, SellIn = -1 };

            // Act
            var actual = new GildedRose(new List<Item> { item });
            actual.UpdateQuality();

            // Assert
            Assert.AreEqual(0, item.Quality);
        }
    }
}