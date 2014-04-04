namespace GildedRose
{
    using System.Collections.Generic;

    public static class Updater
    { 
        public static void UpdateQuality(IList<Item> items)
        {
            for (var i = 0; i < items.Count; i++)
            {
                UpdateItem(items[0]);
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
