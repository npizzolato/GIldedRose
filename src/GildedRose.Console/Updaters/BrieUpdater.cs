namespace GildedRose.Updaters
{
    public class BrieUpdater : IUpdater
    {
        public void UpdateItem(Item item)
        {
            int qualityIncrease = item.SellIn <= 0 ? 2 : 1;
            item.SellIn -= 1;
            item.Quality += qualityIncrease;
            
            item.Quality = item.Quality > 50 ? 50 : item.Quality;
        }
    }
}
