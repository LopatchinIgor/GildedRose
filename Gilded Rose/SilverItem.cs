using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gilded_Rose
{
    public class SilverItem:Item
    {
        protected override void QualityDecreaseBeforeSellIn()
        {
            if (Quality >= 50) return;

            Quality++;

            if (SellIn >= 11 || Quality >= 50) return;

            Quality++;

            if (SellIn >= 6 || Quality >= 50) return;

            Quality++;
        }

        protected override void QualityDecreaseAfterSellIn()
        {
            if (SellIn >= 0) return;

            Quality = 0;
        }
    }
}
