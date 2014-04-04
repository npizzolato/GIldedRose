namespace GildedRose.Updaters
{
    public class PassUpdater : IUpdater
    {
        public void UpdateItem(Item item)
        {
            if (item.SellIn > 10)
            {
                item.Quality += 1;
            }
            else if (item.SellIn > 5)
            {
                item.Quality += 2;
            }
            else if (item.SellIn > 0)
            {
                item.Quality += 3;
            }
            else
            {
                item.Quality = ItemConstants.MinimumQuality;
            }

            item.SellIn -= 1;
        }
    }
}
