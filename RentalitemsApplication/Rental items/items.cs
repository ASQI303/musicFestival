using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental_items
{
    class items
    {

        private String name;
        private int price;

        public items(String name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public String Name { get { return this.name; } }
        public int Price { get { return this.price; } }
    }
}
