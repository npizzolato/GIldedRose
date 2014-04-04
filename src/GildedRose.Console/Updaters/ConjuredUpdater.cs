namespace GildedRose.Updaters
{
    using System;

    public class ConjuredUpdater : IUpdater
    {
        public void UpdateItem(Item item)
        {
            item.Quality -= item.GetQualityChange() * 2;
            item.SellIn -= 1;
            item.Quality = Math.Max(ItemConstants.MinimumQuality, item.Quality);
        }
    }
}
