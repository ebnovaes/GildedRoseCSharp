using NUnit.Framework;
using System.Collections.Generic;
using static csharp.KeyItemConstantsClass;

namespace csharp.Tests
{
    [TestFixture]
    public class ItemSulfurasRulesTest
    {
        [Test]
        public void GivenItemSulfuras_WhenNextDayComes_SellInHigherThan0_ThenQualityAndSellInShouldKeepTheirValues()
        {
            Item item = new Item() { Name = Sulfuras };
            item.Quality = 80;
            item.SellIn = 1;

            var actual = new GildedRose(new List<Item> { item });
            actual.UpdateQuality();

            Assert.AreEqual(80, item.Quality);
            Assert.AreEqual(1, item.SellIn);
        }

        [Test]
        public void GivenItemBrie_WhenNextDayComes_SellInEquals0_ThenQualityAndSellInShouldKeepTheirValues()
        {
            Item item = new Item() { Name = Sulfuras };
            item.Quality = 80;
            item.SellIn = 0;

            var actual = new GildedRose(new List<Item> { item });
            actual.UpdateQuality();

            Assert.AreEqual(80, item.Quality);
            Assert.AreEqual(0, item.SellIn);
        }

        [Test]
        public void GivenItemBrie_WhenNextDayComes_SellInLessThan0_ThenQualityAndSellInShouldKeepTheirValues()
        {
            Item item = new Item() { Name = Sulfuras };
            item.Quality = 80;
            item.SellIn = -1;

            var actual = new GildedRose(new List<Item> { item });
            actual.UpdateQuality();

            Assert.AreEqual(80, item.Quality);
            Assert.AreEqual(-1, item.SellIn);
        }

    }
}
