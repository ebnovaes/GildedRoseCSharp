using System;

namespace csharp
{
    public abstract class ItemHandlerTemplateMethod
    {
        public void Handle(Item item)
        {
            if (!IsAbleToHandle(item))
            {
                throw new InvalidOperationException($"Item cannot be handled here");
            }

            ActuallyHandleItem(item);

            if (item.Quality < 0)
            {
                item.Quality = 0;
            }

            if (item.Quality > 50)
            {
                item.Quality = 50;
            }

            item.SellIn -= 1;
        }

        public abstract bool IsAbleToHandle(Item item);
        protected abstract void ActuallyHandleItem(Item item);
    }
}
