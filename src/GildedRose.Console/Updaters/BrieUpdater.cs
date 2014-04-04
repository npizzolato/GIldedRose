namespace GildedRose.Updaters
{
    using System;

    public class BrieUpdater : IUpdater
    {
        public void UpdateItem(Item item)
        {
            item.SellIn -= 1;
            item.Quality += item.GetQualityChange();

            item.Quality = Math.Min(ItemConstants.MaximumQuality, item.Quality);
        }
    }
}
