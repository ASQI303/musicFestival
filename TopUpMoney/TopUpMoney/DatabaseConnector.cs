using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Media;

namespace TopUpMoney
{
    //Class to connect Database
    public class DatabaseConnector
    {
        private MySqlConnection connectionToDB;
        private string connectionInfo;
        private Person visitor;

        //Constructor
        public DatabaseConnector()
        {
            connectionInfo = "server=studmysql01.fhict.local;" + "Uid = dbi341965;" + "Database = dbi341965;" + "Pwd = Fontys123;" + "connect timeout = 30;";
            connectionToDB = new MySqlConnection(connectionInfo);

        }

        //Methods returns true if database connected

        public bool DatabaseConnection()
        {
            //Creating Database connection
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

        //DatabaseClosing with Method
        public void CloseDatabase()
        {
            connectionToDB.Close();
        }

        // method which returns more than one outputs!!!
        public Person TagCheckedIn(string rfidcode)
        {
            visitor = new Person(rfidcode);
            //if database connection returns true;
            if (DatabaseConnection())
            {
                try
                {
                    string query = "SELECT v.visitor_id, v.FirstName,v.LastName,v.Street,v.HouseNumber,v.City,v.Country,v.Email, r.RFID_String FROM visitors v, rfidassign r WHERE v.visitor_id = r.visitor_id AND r.RFID_String ='" + visitor.RFIDCode.ToString() + "'";

                    MySqlCommand cmd = null;
                    MySqlDataReader datareader = null;
                    cmd = connectionToDB.CreateCommand();
                    cmd.CommandText = query;
                    datareader = cmd.ExecuteReader();

                    if (datareader.Read())
                    {

                        visitor.FirstName = datareader["FirstName"].ToString();
                       
                            visitor.LastName = datareader["LastName"].ToString();
                            visitor.Address = datareader["Street"].ToString() + " " + datareader["HouseNumber"].ToString() + ", " + datareader["City"].ToString() + ", " + datareader["Country"].ToString();
                            visitor.Email = datareader["Email"].ToString();
                            visitor.RFIDCode = datareader["RFID_String"].ToString();
                            visitor.ID = Convert.ToInt32(datareader["visitor_id"]);
                            CloseDatabase();
                            SoundPlayer play = new SoundPlayer(@"E:/ICT_Year1/Block3/ProP/WorkBook/GitForProp/ProP/TopUpMoney/Scan.wav");
                            play.Play();

                        

                    }
                    // throws exception of exception class and plays sounds
                    else
                    {
                        
                        SoundPlayer playUnsucess = new SoundPlayer(@"E:/ICT_Year1/Block3/ProP/WorkBook/GitForProp/ProP/TopUpMoney/error.wav");
                        playUnsucess.Play();
                        throw new Exception("Sorry, We cannot find you on our System");
                    }
                        

                }
                catch
                {
                    throw new Exception("Sorry, We cannot find you on our System");
                    
                }
                if (DatabaseConnection())
                {
                    try
                    {

                        string retrivequery = "SELECT b.Balance from balance b inner JOIN(SELECT visitor_id, TopUpTime, MAX(TopUpTime) as LatestTopUP FROM balance GROUP BY visitor_id) ls on b.visitor_id = ls.visitor_id  and b.TopUpTime = ls.LatestTopUP and b.visitor_id = '" + visitor.ID + "'";
                        MySqlCommand ReadCmd = null;
                        MySqlDataReader RecordRead = null;
                        ReadCmd = connectionToDB.CreateCommand();
                        ReadCmd.CommandText = retrivequery;
                        RecordRead = ReadCmd.ExecuteReader();
                        if (RecordRead.Read())
                        {
                            visitor.Balance = Convert.ToDecimal(RecordRead["Balance"].ToString());
                            RecordRead.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("cannot find record");
                    }
                }

            }
            return visitor;
        }
        //End of TagCheckedIn Method


        //  Creating Object to access value;

        /// <summary>
        /// gets visitor from Form and updates the database
        /// </summary>
        /// <param name="visitor"></param>
        /// <param name="amount"></param>

        public void UpdateBalance(Person visitor, decimal amount)
        {
            //check for database connection
            if (DatabaseConnection())
            {
                visitor.NewBalance = visitor.Balance + amount;

                try
                {

                    string insertquery = "INSERT into balance (TopUpAmount, TopupTime, visitor_ID, Balance, Remarks) VALUES('" + amount.ToString() + "','" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "'," + "'" + visitor.ID.ToString() + "'," + "'" + visitor.NewBalance.ToString() + "'," + "'UPLOADED " + "')";

                    MySqlCommand sqlcmd = new MySqlCommand(insertquery, connectionToDB);
                    sqlcmd.ExecuteNonQuery();
                    SoundPlayer PlayerSuccess = new SoundPlayer(@"E:/ICT_Year1/Block3/ProP/WorkBook/GitForProp/ProP/TopUpMoney/success.wav");
                    PlayerSuccess.Play();




                }
                catch (AppException)

                {

                    throw new AppException("Cannot Insert Into Database");

                }
                finally
                {
                    CloseDatabase();
                }
            }


        }




        //All Methods Ends Here
    }
}
