using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refund_Application
{
    class AppException : Exception
    {
        private string message;
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
