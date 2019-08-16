using System.Collections.Generic;
using static csharp.KeyItemConstantsClass;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            var itemHandler = SetupItemHandlersChain();
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name == Sulfuras)
                {
                    continue;
                }

                itemHandler.Handle(Items[i]);
            }
        }

        private ItemHandler SetupItemHandlersChain()
        {
            ItemHandler item = new BrieItemHandler(null);
            item = new BackstagePassesItemHandler(item);
            item = new ConjuredItemHandler(item);
            item = new OrdinaryItemHandler(item);

            return item;
        }
    }
}