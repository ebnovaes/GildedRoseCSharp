using System;
using static csharp.KeyItemConstantsClass;

namespace csharp
{
    public class BackstagePassesItemHandler
    {
        public void Handle(Item item)
        {
            if (item.Name != BackstagePasses)
            {
                throw new InvalidOperationException($"Item cannot be handled here");
            }

            if (item.SellIn >= 11)
            {
                item.Quality += 1;
            }
            else if (item.SellIn >= 6)
            {
                item.Quality += 2;
            }
            else if (item.SellIn > 0)
            {
                item.Quality += 3;
            }
            else
            {
                item.Quality = 0;
            }

            if (item.Quality >= 50)
            {
                item.Quality = 50;
            }

            item.SellIn -= 1;
        }

        public bool IsAbleToHandle(Item item)
        {
            return item.Name == BackstagePasses;
        }
    }
}