using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose
{
    public class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }
    }

    public static class ItemExtensions
    {
        public static bool IsExpired(this Item item)
        {
            return item.SellIn <= 0;
        }
    }
}
