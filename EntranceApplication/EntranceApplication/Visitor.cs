using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntranceApplication
{
   public class Visitor
    {
    //    //Instance Variable
    //    private string firstname;
    //    private string lastname;
    //    private string city;
    //    private string street;
    //    private string housenumber;
    //    private string country;
    //    private int phone;
    //    private string email;
    //    private string username;
    //    private string password;
        
        //properties
        public int ID { get; set; }
         public string FirstName
        {
            get;set;
        }

        public string LastName
        { get; set; }



        public string City { get; set; }
        public string Country { get; set; }
        public string RfidCode { get; set; }
        public string Status { get;set; }
        public string EntryFee { get; set; }

        //Constructor
        public Visitor(string rfidcode)
        {
            this.RfidCode = rfidcode;
        }


    }
}
