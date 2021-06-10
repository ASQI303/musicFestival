using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;

namespace Refund_Application
{
    public class DatabaseHelper
    {
        private MySqlConnection connectionToDB;
        private string connectionInfo;
        private Visitor person;

        //Constructor
        public DatabaseHelper()
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
        public Visitor TagCheckedIn(string rfidcode)
        {
            person = new Visitor(rfidcode);
            //if database connection returns true;
            if (DatabaseConnection())
            {
                try
                {
                    string query = "SELECT v.visitor_id, v.FirstName,v.LastName,v.Street,v.HouseNumber,v.City,v.Country,v.Email, r.RFID_String FROM visitors v, rfidassign r WHERE v.visitor_id = r.visitor_id AND r.RFID_String ='" + person.RFIDCode.ToString() + "'";

                    MySqlCommand cmd = null;
                    MySqlDataReader datareader = null;
                    cmd = connectionToDB.CreateCommand();
                    cmd.CommandText = query;
                    datareader = cmd.ExecuteReader();

                    if (datareader.Read())
                    {

                        person.FirstName = datareader["FirstName"].ToString();

                        person.LastName = datareader["LastName"].ToString();
                        person.Address = datareader["Street"].ToString() + " " + datareader["HouseNumber"].ToString() + ", " + datareader["City"].ToString() + ", " + datareader["Country"].ToString();
                        person.Email = datareader["Email"].ToString();
                        person.RFIDCode = datareader["RFID_String"].ToString();
                        person.ID = Convert.ToInt32(datareader["visitor_id"]);
                        CloseDatabase();
                        datareader.Close();



                    }
                    // throws exception of exception class and plays sounds
                    else
                    {


                        throw new AppException("Sorry, We cannot find you on our System");
                    }


                }
                catch
                {
                    throw new AppException("Sorry, We cannot find you on our System");

                }
                if (DatabaseConnection())
                {
                    try
                    {

                        string retrivequery = "SELECT b.Balance from balance b inner JOIN(SELECT visitor_id, TopUpTime, MAX(TopUpTime) as LatestTopUP FROM balance GROUP BY visitor_id) ls on b.visitor_id = ls.visitor_id  and b.TopUpTime = ls.LatestTopUP and b.visitor_id = '" + person.ID + "'";
                        MySqlCommand ReadCmd = null;
                        MySqlDataReader RecordRead = null;
                        ReadCmd = connectionToDB.CreateCommand();
                        ReadCmd.CommandText = retrivequery;
                        RecordRead = ReadCmd.ExecuteReader();
                        if (RecordRead.Read())
                        {
                            person.Balance = Convert.ToDecimal(RecordRead["Balance"].ToString());
                            
                            CloseDatabase();
                            RecordRead.Close();
                            UpdateDatabase(person);

                        }
                    }
                    catch
                    {
                        MessageBox.Show("cannot find record");
                    }
                }

            }
            return person;
        }


        public void UpdateDatabase(Visitor person)
        {
            if (person.Balance > 0)
            {


                if (DatabaseConnection())
                {
                    decimal amount = person.Balance;
                    person.NewBalance = 0;
                    try
                    {

                        string insertquery = "INSERT into balance (TopUpAmount, TopupTime, visitor_ID, Balance, Remarks) VALUES('-" + amount.ToString() + "','" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "'," + "'" + person.ID.ToString() + "'," + "'" + person.NewBalance.ToString() + "'," + "'REFUNDED'" + ")";

                        MySqlCommand sqlcmd = new MySqlCommand(insertquery, connectionToDB);
                        sqlcmd.ExecuteNonQuery();
                        UpdateTextFile(person);
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

            else
            {
                try
                {
                    if (DatabaseConnection())
                    {
                        CloseDatabase();
                    }

                }
                catch (AppException)
                {
                    throw new AppException("No Balance to Refund");
                }
            }
        }



        public void UpdateTextFile(Visitor person)
        {
            string path = @"C:\Users\Yogesh  Chaudhary\Desktop\RefundLog.txt";
            if (person.Balance>0)
            {
                if (File.Exists(path)) {
                    FileStream fs = null;
                    
                    try
                    {
                        fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                        StreamWriter sw = new StreamWriter(fs);
                        
                        sw.WriteLine(person.FirstName + " " + person.LastName + "," + person.Address + "," + person.Email + ",€ " + person.Balance.ToString() +"- To be Refunded \n");

                        sw.Close();

                    }
                    catch (AppException)
                    {
                        throw new Exception("Error Writing on Text file");
                    }
                    finally
                    {
                        fs.Close();
                        
                    }
                }
            }

        }

        //all methods ends here

    }
}

