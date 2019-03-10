using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gilded_Rose
{
    class GoldItem:Item
    {
        protected override void QualityDecreaseBeforeSellIn()
        {
            return;
        }

        protected override void SellInItem()
        {
            return;
        }

        protected override void QualityDecreaseAfterSellIn()
        {
            return;
        }
    }
}
