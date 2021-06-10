using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental_items
{
    class Visitor
    {
        public int ID { get; set; }
        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        { get; set; }

        public Decimal Balance { get; set; }
        public Decimal NewBalance { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string RfidCode { get; set; }
        public string Status { get; set; }

        //Constructor
        public Visitor(string rfidcode)
        {
            this.RfidCode = rfidcode;
        }
    }
}
