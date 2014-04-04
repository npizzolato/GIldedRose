namespace GildedRose.Updaters
{
    using System;

    public class GenericUpdater : IUpdater
    {
        public void UpdateItem(Item item)
        {
            item.Quality -= item.GetQualityChange();
            item.SellIn -= 1;
            item.Quality = Math.Max(ItemConstants.MinimumQuality, item.Quality);
        }
    }
}
