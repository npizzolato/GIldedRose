namespace GildedRose
{
    public class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }
    }

    public static class ItemConstants
    {
        public static int MinimumQuality = 0;

        public static int MaximumQuality = 50;
    }

    public static class ItemExtensions
    {
        public static bool IsExpired(this Item item)
        {
            return item.SellIn <= 0;
        }

        public static int GetQualityChange(this Item item)
        {
            return item.IsExpired() ? 2 : 1;
        }
    }
}
