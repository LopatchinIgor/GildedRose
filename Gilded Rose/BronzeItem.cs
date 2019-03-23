using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gilded_Rose
{
    class BronzeItem:Item
    {
        protected override void QualityDecreaseBeforeSellIn()
        {
            if (Quality >= 50) return;

            Quality+=1;
        }

        protected override void QualityDecreaseAfterSellIn()
        {
            if (SellIn >= 0) return;

            if (Quality >= 50) return;

            Quality++;
        }
    }
}
