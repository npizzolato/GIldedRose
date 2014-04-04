using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose
{
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
            if (item.Name == "Aged Brie")
            {
                var updater = new BrieUpdater();
                updater.UpdateItem(item);
                return;
            }
            else if (item.Name.StartsWith("Backstage pass", StringComparison.OrdinalIgnoreCase))
            {
                var updater = new PassUpdater();
                updater.UpdateItem(item);
                return;
            }
            else if (item.Name.Equals("Sulfuras, Hand of Ragnaros", StringComparison.OrdinalIgnoreCase))
            {
                var updater = new NoOpUpdater();
                updater.UpdateItem(item);
                return;
            }
            else
            {
                var updater = new GenericUpdater();
                updater.UpdateItem(item);
                return;
            }
        }
    }
}
