using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gilded_Rose
{
    class Program
    {
        static void Main(string[] args)
        {
            var box = new Box();

            box.PrintItems();
            box.UpdateQuality();
            box.PrintItems();
            Console.ReadKey();
        }
       }
}
