using NUnit.Framework;
using System.Collections.Generic;
using static csharp.KeyItemConstantsClass;

namespace csharp.Tests
{
    [TestFixture]
    public class ItemBackstagePassesRulesTest
    {
        [Test]
        public void GivenItemBackstagePasses_WhenNextDayComes_QualityLessThan50_SellInHigherThan0_ThenQualityShouldIncreaseByOne()
        {
            // Arrange
            var item = new Item() { Name = BackstagePasses, Quality = 49, SellIn = 1 };

            // Act
            var actual = new GildedRose(new List<Item> { item });
            actual.UpdateQuality();

            // Assert
            Assert.AreEqual(50, item.Quality);
        }

        [Test]
        public void GivenItemBackstagePasses_WhenNextDayComes_SellInEquals10_ThenQualityShouldIncreaseByTwo()
        {
            // Arrange
            var item = new Item() { Name = BackstagePasses, Quality = 28, SellIn = 10 };

            // Act
            var actual = new GildedRose(new List<Item> { item });
            actual.UpdateQuality();

            // Assert
            Assert.AreEqual(30, item.Quality);
        }

        [Test]
        public void GivenItemBackstagePasses_WhenNextDayComes_SellInLessThan10AndHigherThan5_ThenQualityShouldIncreaseByTwo()
        {
            // Arrange
            var item = new Item() { Name = BackstagePasses, Quality = 13, SellIn = 7 };

            // Act
            var actual = new GildedRose(new List<Item> { item });
            actual.UpdateQuality();

            // Assert
            Assert.AreEqual(15, item.Quality);
        }

        [Test]
        public void GivenItemBackstagePasses_WhenNextDayComes_SellInEquals5_ThenQualityShouldIncreaseByThree()
        {
            // Arrange
            var item = new Item() { Name = BackstagePasses, Quality = 37, SellIn = 5 };

            // Act
            var actual = new GildedRose(new List<Item> { item });
            actual.UpdateQuality();

            // Assert
            Assert.AreEqual(40, item.Quality);
        }

        [Test]
        public void GivenItemBackstagePasses_WhenNextDayComes_SellInLessThan5AndHigherThan0_ThenQualityShouldIncreaseByThree()
        {
            // Arrange
            var item = new Item() { Name = BackstagePasses, Quality = 22, SellIn = 2 };

            // Act
            var actual = new GildedRose(new List<Item> { item });
            actual.UpdateQuality();

            // Assert
            Assert.AreEqual(25, item.Quality);
        }

        [Test]
        public void GivenItemBackstagePasses_WhenNextDayComes_SellInIs0_ThenQualityShouldBe0()
        {
            // Arrange
            var item = new Item() { Name = BackstagePasses, Quality = 10, SellIn = 0 };

            // Act
            var actual = new GildedRose(new List<Item> { item });
            actual.UpdateQuality();

            // Assert
            Assert.AreEqual(0, item.Quality);
        }

        [Test]
        public void GivenItemBackstagePasses_WhenNextDayComes_SellInLessThan0_ThenQualityShouldBe0()
        {
            // Arrange
            var item = new Item() { Name = BackstagePasses, Quality = 10, SellIn = -2 };

            // Act
            var actual = new GildedRose(new List<Item> { item });
            actual.UpdateQuality();

            // Assert
            Assert.AreEqual(0, item.Quality);
        }
    }
}