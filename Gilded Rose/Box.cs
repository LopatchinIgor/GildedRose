using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gilded_Rose
{
    public class Box
    {
        private IList<Item> Items;
        public Box()
        {
            Items = new List<Item>
                {
                    new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                    new BronzeItem {Name = "Aged Brie", SellIn = 2, Quality = 0},
                    new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                    new GoldItem {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                    new SilverItem {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20},
                    new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                };
        }
        public void UpdateQuality()
        {
            Console.WriteLine("Updating items...");
            for (var i = 0; i < Items.Count; i++)
            {
                Items[i].UpdateQuality();
            }
        }
        public void PrintItems()
        {
            Console.WriteLine("Items in box:");
            foreach (var item in Items)
            {
                Console.WriteLine($"\t{item.Name}, SellIn: {item.SellIn}, Quality: {item.Quality}");
            }
            Console.WriteLine();
        }
    }
}
