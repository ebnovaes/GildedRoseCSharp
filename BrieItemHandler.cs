using System;
using static csharp.KeyItemConstantsClass;

namespace csharp
{
    public class BrieItemHandler : ItemHandlerTemplateMethod
    {
        public override bool IsAbleToHandle(Item item)
        {
            return item.Name == AgedBrie;
        }

        protected override void ActuallyHandleItem(Item item)
        {
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
        }
    }
}