using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental_items
{
 public   class RentalRecords
    {

        public string ItemName { get; set; }
        public string Remarks { get; set; }

        public RentalRecords(string itemName, string remarks)
        {
            this.ItemName = itemName;
            this.Remarks = remarks;
        }
    }
}
