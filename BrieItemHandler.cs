using System;
using static csharp.KeyItemConstantsClass;

namespace csharp
{
    public class BrieItemHandler
    {
        public void Handle(Item item)
        {
            if (item.Name != AgedBrie)
            {
                throw new InvalidOperationException($"Item cannot be handled here");
            }

            if (item.SellIn > 0)
            {
                item.Quality += 1;
            }
            else
            {
                item.Quality += 2;
            }

            if (item.Quality >= 50)
            {
                item.Quality = 50;
            }

            item.SellIn -= 1;
        }

        public bool IsAbleToHandle(Item item)
        {
            return item.Name == AgedBrie;
        }
    }
}