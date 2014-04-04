using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose
{
    public class NoOpUpdater : IUpdater
    {
        public void UpdateItem(Item item)
        {
        }
    }
}
