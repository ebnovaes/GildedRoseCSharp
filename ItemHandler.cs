using System;

namespace csharp
{
    public abstract class ItemHandler
    {
        public ItemHandler(ItemHandler nextItemInChain)
        {
            _nextItemInChain = nextItemInChain;
        }

        public void Handle(Item item)
        {
            if (IsAbleToHandle(item))
            {
                ActuallyHandleItem(item);
                CheckItemQualityValueBoundariesRule(item);
                item.SellIn -= 1;

                return;
            }

            if (_nextItemInChain != null)
            {
                _nextItemInChain.Handle(item);

                return;
            }

            throw new InvalidOperationException($"Unable to find handle for item { item.Name }");
        }

        private static void CheckItemQualityValueBoundariesRule(Item item)
        {
            if (item.Quality < 0)
            {
                item.Quality = 0;
            }

            if (item.Quality > 50)
            {
                item.Quality = 50;
            }
        }

        public abstract bool IsAbleToHandle(Item item);
        protected abstract void ActuallyHandleItem(Item item);
        protected readonly ItemHandler _nextItemInChain;
    }
}
