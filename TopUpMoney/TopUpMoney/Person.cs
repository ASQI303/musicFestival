using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopUpMoney
{
  public  class Person
    {
        public int ID { get; set; }
        public string RFIDCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Decimal Balance { get; set; }
        public string Address { get; set; }
        public Decimal NewBalance { get; set; }
        public string Email { get; set; }
        //public string City { get; set; }
        //public string Street { get; set; }
        //public string HouseNumber { get; set; }
        //public string Country
        //{
        //    get;set;
        //}
        //constructor
        public Person(string rfidcode)
        {
            this.RFIDCode = rfidcode;
        }



        //All Methods Ends Here
    }
}
