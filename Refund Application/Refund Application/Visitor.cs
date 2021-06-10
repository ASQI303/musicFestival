using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refund_Application
{
   public class Visitor
    {
        public int ID { get; set; }
        public string RFIDCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Decimal Balance { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        private decimal newBalance;
        public decimal NewBalance
        {
            get { return newBalance; }
            set
            {
                newBalance = 0.00m;
            }
        }

        
        //construtor
        
        public Visitor(string rfid)
        {
            this.RFIDCode = rfid;
        }
    }
}
