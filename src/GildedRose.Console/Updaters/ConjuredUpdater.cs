namespace GildedRose.Updaters
{
    public class ConjuredUpdater : IUpdater
    {
        public void UpdateItem(Item item)
        {
            item.Quality -= item.IsExpired() ? 4 : 2;
            item.SellIn -= 1;
            item.Quality = item.Quality < 0 ? 0 : item.Quality;
        }
    }
}
