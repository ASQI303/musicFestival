using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Management_Application
{
    public class DatabaseConnector
    {
        private MySqlConnection connectionToDB;
        private string connectionInfo;

        private Entrance ent;
        private Sales sales;
        private TopUp topup;
        private bool checking;
        private string InfoMessage;
        private MySqlCommand cmd = null;

        /// <summary>
        /// constructor
        /// </summary>
        public DatabaseConnector()
        {
            connectionInfo = "server=studmysql01.fhict.local;" + "Uid = dbi341965;" + "Database = dbi341965;" + "Pwd = Fontys123;" + "connect timeout = 30;";
            connectionToDB = new MySqlConnection(connectionInfo);
        }

        public bool Databaseconnection()
        {
            bool connected = false;
            try
            {
                connectionToDB.ConnectionString = connectionInfo;
                connectionToDB.Open();
                connected = true;
            }
            catch
            {
                connected = false;
                connectionToDB.Close();
            }

            return connected;
        }


        public void CloseDatabase()
        {
            connectionToDB.Close();

        }


        public Entrance EntranceInfo(out bool checking ,out string infoMessage)
        {
            ent = new Entrance();
           if(Databaseconnection())

            {
                string temp = "CHECKEDIN";
                string query = "SELECT COUNT(FirstName) from Visitors";
                string query1 = "SELECT COUNT(*) FROM SESSION s INNER JOIN (SELECT visitor_id, EntryTime, max(EntryTime)AS MaxDate FROM SESSION GROUP BY visitor_id)ls ON s.visitor_id = ls.visitor_id AND s.EntryTime = ls.MaxDate AND STATUS ='"+temp +"'";
                string query2 = "SELECT COUNT(*) FROM SESSION s INNER JOIN (SELECT visitor_id, EntryTime, max(EntryTime)AS MaxDate FROM SESSION GROUP BY visitor_id)ls ON s.visitor_id = ls.visitor_id AND s.EntryTime = ls.MaxDate AND STATUS ='CHECKEDOUT'";
                try
                {
                    cmd = connectionToDB.CreateCommand();
                   
                    cmd.CommandText = query;
                    int Totalcount = Convert.ToInt32(cmd.ExecuteScalar());
                    cmd.CommandText = query1;
                    int totalcheckin = Convert.ToInt32(cmd.ExecuteScalar());
                    cmd.CommandText = query2;
                    
                    ent.TotalNrOfVisitors = Totalcount;
                    ent.TotalNrofCheckedInVisitors = totalcheckin;
                    ent.TotalNrOfVisitorsCheckedOut = Convert.ToInt32(cmd.ExecuteScalar());
                  this.checking = true;
                }
                catch (Exception ex)
                {
                    this.checking = false;
                    this.InfoMessage = ex.ToString();

                    
                }
                
            }
            else
            {

            }
            infoMessage = this.InfoMessage;
            checking = this.checking;
            return ent;

        }



        public Sales SalesInfo(out bool checking, out string infoMessage)
        {
            sales = new Sales();
            if (Databaseconnection())
            {
                string query = "SELECT  count( Distinct visitor_id) FROM balance Where Remarks ='BOUGHT'";
                string querytotalsale = "SELECT sum(TopUpAmount) FROM balance Where Remarks ='Bought'";
                try
                {
                    cmd = connectionToDB.CreateCommand();
                    cmd.CommandText = query;
                    int totalBuyer = Convert.ToInt32(cmd.ExecuteScalar());
                    cmd.CommandText = querytotalsale;
                    decimal totalsale = Convert.ToDecimal(cmd.ExecuteScalar());
                    sales.TotalNrOfVisitorBuyFood = totalBuyer;
                    sales.TotalEarnedFromFood = Math.Abs(totalsale);
                    this.checking = true;

                }
                catch (Exception ex)
                {
                    this.checking = false;
                    this.InfoMessage = ex.ToString();
                }
            }
            else
            {
            }
                infoMessage = this.InfoMessage;
                checking = this.checking;
                return sales;
            
            
        }

        public TopUp TopUpInfo(out bool checking, out string infoMessage)
        {
            topup = new TopUp();
            if(Databaseconnection())
            {
                string query2count = "SELECT count(Distinct visitor_id) from balance where Remarks ='UPLOADED'";
                string query2uploaded = "SELECT SUM(Topupamount) as sum from balance where Remarks ='UPLOADED'";
                string query2refund = "SELECt SUM(Topupamount) from balance where Remarks ='REFUNDED'";
                try
                {
                    cmd = connectionToDB.CreateCommand();
                    cmd.CommandText = query2count;
                    topup.TotalNumberOfVisitorToppingUp = Convert.ToInt32(cmd.ExecuteScalar());
                    cmd.CommandText = query2uploaded;
                    topup.TotalTopUpAmount= Convert.ToDecimal(cmd.ExecuteScalar());
                    cmd.CommandText = query2refund;
                    topup.TotalToBeRefunded = Math.Abs(Convert.ToDecimal(cmd.ExecuteScalar()));
                    this.checking = true;
                }
                catch(Exception ex)
                {
                    this.checking = false;
                    this.InfoMessage = ex.ToString();
                }
            }
            else
            {

                
            }
            infoMessage = this.InfoMessage;
            checking = this.checking;
            return topup;
        }
        //all methods ends here

    }
}
