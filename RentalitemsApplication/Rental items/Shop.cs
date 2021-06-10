using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental_items
{
    class Shop
    {
        private List<items> myitems;

        public Shop()
        {
            myitems = new List<items>();

            myitems.Add(new items("Boat", 100));
            myitems.Add(new items("Light sticker", 3));
            myitems.Add(new items("Yoga bat", 4));
            myitems.Add(new items("Kite", 10));
            myitems.Add(new items("Tools for making dumpling", 10));
            myitems.Add(new items("Tent", 20));

           
        }

        public List<items> getitems() { return this.myitems; }
    }
}
