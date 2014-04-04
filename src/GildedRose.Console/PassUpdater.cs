using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose
{
    public class PassUpdater : IUpdater
    {
        public void UpdateItem(Item item)
        {
            if (item.SellIn > 10)
            {
                item.Quality += 1;
            }
            else if (item.SellIn > 5)
            {
                item.Quality += 2;
            }
            else if (item.SellIn > 0)
            {
                item.Quality += 3;
            }
            else
            {
                item.Quality = 0;
            }

            item.SellIn -= 1;

        }
    }
}
