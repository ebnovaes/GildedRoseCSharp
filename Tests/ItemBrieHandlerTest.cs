using NUnit.Framework;
using System;
using System.Collections.Generic;
using static csharp.KeyItemConstantsClass;

namespace csharp.Tests
{
    [TestFixture]
    public class ItemBrieHandlerTest
    {
        [Test]
        public void GivenItemBrieHandler_WhenNextDayComes_QualityLessThan50_SellInHigherThan0_ThenQualityShouldIncreaseByOne()
        {
            // Arrange
            var item = new Item() { Name = AgedBrie, Quality = 49, SellIn = 1 };
            
            // Act
            var actual = new BrieItemHandler(null);
            actual.Handle(item);

            // Assert
            Assert.AreEqual(50, item.Quality);
        }

        [Test]
        public void GivenItemBrieHandler_WhenNextDayComes_QualityEquals50_SellInHigherThan0_ThenQualityShouldRemain50()
        {
            // Arrange
            var item = new Item() { Name = AgedBrie, Quality = 50, SellIn = 1 };

            // Act
            var actual = new BrieItemHandler(null);
            actual.Handle(item);

            // Assert
            Assert.AreEqual(50, item.Quality);
        }

        [Test]
        public void GivenItemBrieHandler_WhenNextDayComes_QualityLessThan50_SellInEquals0_ThenQualityShouldIncreaseByTwo()
        {
            // Arrange
            var item = new Item() { Name = AgedBrie, Quality = 10, SellIn = 0 };

            // Act
            var actual = new BrieItemHandler(null);
            actual.Handle(item);

            // Assert
            Assert.AreEqual(12, item.Quality);
        }

        [Test]
        public void GivenItemBrieHandler_WhenNextDayComes_QualityLessThan50_SellInLessThan0_ThenQualityShouldIncreaseByTwo()
        {
            // Arrange
            var item = new Item() { Name = AgedBrie, Quality = 22, SellIn = -3 };

            // Act
            var actual = new BrieItemHandler(null);
            actual.Handle(item);

            // Assert
            Assert.AreEqual(24, item.Quality);
        }

        [Test]
        public void GivenItemBrieHandler_WhenItemIsNotBrie_ShouldThrowError()
        {
            // Arrange
            var item = new Item() { Name = "AnotherArbitraryItem", Quality = 22, SellIn = -3 };

            // Act
            var actual = new BrieItemHandler(null);

            // Assert
            Assert.Throws<InvalidOperationException>(() => actual.Handle(item), "Item cannot be handled here");
        }
    }
}