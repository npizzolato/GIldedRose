using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose
{
    public static class UpdaterFactory
    {
        public static IUpdater CreateUpdater(Item item)
        {
            IUpdater updater = null;

            if (item.Name == "Aged Brie")
            {
                updater = new BrieUpdater();
            }
            else if (item.Name.StartsWith("Backstage pass", StringComparison.OrdinalIgnoreCase))
            {
                updater = new PassUpdater();
            }
            else if (item.Name.Equals("Sulfuras, Hand of Ragnaros", StringComparison.OrdinalIgnoreCase))
            {
                updater = new NoOpUpdater();
            }
            else
            {
                updater = new GenericUpdater();
            }

            return updater;
        }
    }
}
