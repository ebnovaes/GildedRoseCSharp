using static csharp.KeyItemConstantsClass;

namespace csharp
{
    public class ConjuredItemHandler : ItemHandler
    {
        public ConjuredItemHandler(ItemHandler nextItemInChain) : base(nextItemInChain)
        {
        }

        public override bool IsAbleToHandle(Item item)
        {
            return item.Name == Conjured;
        }

        protected override void ActuallyHandleItem(Item item)
        {
            if (item.SellIn > 0)
            {
                item.Quality -= 2;
            }
            else
            {
                item.Quality -= 4;
            }

            if (item.Quality < 0)
            {
                item.Quality = 0;
            }
        }
    }
}