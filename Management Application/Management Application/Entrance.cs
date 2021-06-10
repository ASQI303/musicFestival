using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Application
{
   public class Entrance
    {

        public int TotalNrOfVisitors { get; set; }
        public int TotalNrofCheckedInVisitors { get; set; }
        public int TotalNrOfVisitorsCheckedOut { get; set; }

        public int TotalEarnedFromEntrance(int nrOfVisitors)
        {
            return nrOfVisitors * 55;
        }
    }
}
