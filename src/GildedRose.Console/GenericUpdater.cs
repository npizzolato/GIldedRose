using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose
{
    public class GenericUpdater : IUpdater
    {
        public void UpdateItem(Item item)
        {
            item.Quality -= item.IsExpired() ? 2 : 1;
            item.SellIn -= 1;
            item.Quality = item.Quality < 0 ? 0 : item.Quality;
        }
    }
}
