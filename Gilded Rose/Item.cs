using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gilded_Rose
{
    public class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public void UpdateQuality()
        {
            QualityDecreaseBeforeSellIn();
            SellInItem();
            QualityDecreaseAfterSellIn();
        }

        virtual protected void QualityDecreaseBeforeSellIn()
        {
            if (Quality <= 0) return;

            Quality--;
        }
        virtual protected void SellInItem()
        {
            SellIn--;
        }
        virtual protected void QualityDecreaseAfterSellIn()
        {
            if (SellIn >= 0) return;

            if (Quality <= 0) return;

            Quality--;
        }
    }
}
