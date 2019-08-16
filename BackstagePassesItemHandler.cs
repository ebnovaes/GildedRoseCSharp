using System;
using static csharp.KeyItemConstantsClass;

namespace csharp
{
    public class BackstagePassesItemHandler : ItemHandlerTemplateMethod
    {
        public override bool IsAbleToHandle(Item item)
        {
            return item.Name == BackstagePasses;
        }

        protected override void ActuallyHandleItem(Item item)
        {
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
        }
    }
}