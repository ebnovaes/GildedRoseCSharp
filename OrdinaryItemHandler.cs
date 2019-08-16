using static csharp.KeyItemConstantsClass;

namespace csharp
{
    public class OrdinaryItemHandler : ItemHandlerTemplateMethod
    {
        public override bool IsAbleToHandle(Item item)
        {
            return item.Name != AgedBrie &&
                   item.Name != BackstagePasses &&
                   item.Name != Sulfuras &&
                   item.Name != Conjured;
        }

        protected override void ActuallyHandleItem(Item item)
        {
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
        }
    }
}