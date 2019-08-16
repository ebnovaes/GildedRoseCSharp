using System;
using static csharp.KeyItemConstantsClass;

namespace csharp
{
    public class OrdinaryItemHandler
    {
        public void Handle(Item item)
        {
            if (!IsAbleToHandle(item))
            {
                throw new InvalidOperationException($"Item cannot be handled here");
            }

            if (item.SellIn > 0)
            {
                item.Quality -= 1;
            }
            else
            {
                item.Quality -= 2;
            }

            if (item.Quality < 0)
            {
                item.Quality = 0;
            }

            item.SellIn -= 1;
        }

        public bool IsAbleToHandle(Item item)
        {
            return item.Name != AgedBrie &&
                   item.Name != BackstagePasses &&
                   item.Name != Sulfuras;
        }
    }
}