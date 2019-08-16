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
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name == Sulfuras)
                {
                    continue;
                }

                var brieItemHandler = new BrieItemHandler();
                var backstagePassesItemHandler = new BackstagePassesItemHandler();
                var ordinaryItemHandler = new OrdinaryItemHandler();
                if (brieItemHandler.IsAbleToHandle(Items[i]))
                {
                    brieItemHandler.Handle(Items[i]);
                    continue;
                }

                if (backstagePassesItemHandler.IsAbleToHandle(Items[i]))
                {
                    backstagePassesItemHandler.Handle(Items[i]);
                    continue;
                }

                if (ordinaryItemHandler.IsAbleToHandle(Items[i]))
                {
                    ordinaryItemHandler.Handle(Items[i]);
                    continue;
                }
            }
        }
    }
}