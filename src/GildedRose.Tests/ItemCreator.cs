using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Tests
{
    public static class ItemCreator
    {
        public static Item Create()
        {
            return new Item()
            {
                SellIn = 5,
                Name = "Random item",
                Quality = 5,
            };
        }

        public static Item WithName(this Item item, string name)
        {
            item.Name = name;
            return item;
        }

        public static Item WithSellIn(this Item item, int sellin)
        {
            item.SellIn = sellin;
            return item;
        }

        public static Item WithQuality(this Item item, int quality)
        {
            item.Quality = quality;
            return item;
        }

        public static Item Expired(this Item item)
        {
            item.SellIn = 0;
            return item;
        }
    }
}
