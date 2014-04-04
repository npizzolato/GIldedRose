namespace GildedRose
{
    using System.Collections.Generic;

    public static class Updater
    { 
        public static void UpdateQuality(IList<Item> items)
        {
            foreach (Item item in items)
            {
                UpdateItem(item);
            }
        }

        public static void UpdateItem(Item item)
        {
            IUpdater updater = UpdaterFactory.CreateUpdater(item);
            updater.UpdateItem(item);
            return;
        }
    }
}
