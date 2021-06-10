using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phidgets;

namespace TopUpMoney
{
    public class AppException : Exception
    {

        private string message;


        //All Methods constructor ends here
        public AppException(string message) : base(message)
        {
            this.message = message;

        }

        public override string Message
        {
            get
            {
                return base.Message;
            }
        }
    }
}
