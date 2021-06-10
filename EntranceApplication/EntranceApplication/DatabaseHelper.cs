using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;
using System.Media;

namespace EntranceApplication
{
    public class DatabaseHelper
    {

        //Instance Varibales
        private string connectionInfo;
        private MySqlConnection connectionToDB;
        private Visitor person;
       

        //Constructor to create Database connection
        public DatabaseHelper()
        {
            connectionInfo = "server=studmysql01.fhict.local;" + "Uid = dbi341965;" + "Database = dbi341965;" + "Pwd = Fontys123;" + "connect timeout = 30;";
            connectionToDB = new MySqlConnection(connectionInfo);

        }
        //Database Opener
        public bool DatabaseConnection()
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
            // Method to close DatabaseConnection to prevent potential attack
            //returns Nothing

            connectionToDB.Close();
        }


        public Visitor TagCheckedIn(string rfidcode)
        {
            person = new Visitor(rfidcode);
            if (DatabaseConnection())
            {
                try
                {
                    string query = "SELECT v.visitor_id, v.FirstName,v.LastName,v.City,v.Country, r.RFID_String, v.EntryFee FROM visitors v, rfidassign r WHERE v.visitor_id = r.visitor_id AND r.RFID_String ='" + person.RfidCode.ToString() + "'";
                    MySqlCommand cmd = null;
                    MySqlDataReader datareader = null;
                    cmd = connectionToDB.CreateCommand();
                    cmd.CommandText = query;
                    datareader = cmd.ExecuteReader();
                    if (datareader.Read())
                    {
                        person.FirstName = datareader["FirstName"].ToString();
                        person.LastName = datareader["LastName"].ToString();
                        person.City = datareader["City"].ToString();
                        person.Country = datareader["Country"].ToString();
                        person.RfidCode = datareader["RFID_String"].ToString();
                        person.ID = Convert.ToInt32(datareader["visitor_id"]);
                        person.EntryFee = datareader["EntryFee"].ToString();
                        
                        CloseDatabase();
                        if (person.EntryFee.ToUpper() == "PAID")
                        {
                            
                            InsertIntoSession(person); // Starts another Method to insert data on Session Table
                           
                        }
                        else
                        {
                            SoundPlayer playUnsucess = new SoundPlayer(@"E:/ICT_Year1/Block3/ProP/WorkBook/GitForProp/ProP/TopUpMoney/error.wav");
                            playUnsucess.Play();
                            MessageBox.Show("Your Entry Fee has not been paid");
                           

                        }

                    }

                }
                catch
                {
                    MessageBox.Show("Cannot Read From Database");
                }

            }

                return person;
            
           
        }


            // insert to Session table
            public void InsertIntoSession(Visitor checkedinperson)
            {

            if (DatabaseConnection() && person.EntryFee.ToUpper() == "PAID")
            {
                try
                {

                    string sessionquery = "SELECT s.Status from session s inner JOIN(SELECT visitor_id, EntryTime, max(EntryTime) as MaxDate FROM session GROUP BY visitor_id)ls on s.visitor_id = ls.visitor_id and s.EntryTime = ls.MaxDate AND s.visitor_id='" + checkedinperson.ID + "'";
                    MySqlCommand RecordCmd = null;
                    MySqlDataReader RecordReader = null;
                    RecordCmd = connectionToDB.CreateCommand();
                    RecordCmd.CommandText = sessionquery;
                    RecordReader = RecordCmd.ExecuteReader();

                    if (RecordReader.Read())
                    {
                        checkedinperson.Status = RecordReader["Status"].ToString();
                        checkedinperson.ID = Convert.ToInt32(person.ID);

                        if (checkedinperson.Status == " " || checkedinperson.Status.ToUpper() == "CHECKEDOUT")
                        {

                            checkedinperson.Status = "CHECKEDIN";
                            SoundPlayer play = new SoundPlayer(@"E:/ICT_Year1/Block3/ProP/WorkBook/GitForProp/ProP/TopUpMoney/Scan.wav");
                            play.Play();
                        }
                        else
                        {
                            
                          
                                checkedinperson.Status = "CHECKEDOUT";
                                SoundPlayer play = new SoundPlayer(@"E:/ICT_Year1/Block3/ProP/WorkBook/GitForProp/ProP/TopUpMoney/success.wav");
                                play.Play();
                           
                        }
                    }
                    else
                    {
                        checkedinperson.Status = "CHECKEDIN";
                        checkedinperson.ID = Convert.ToInt32(person.ID);
                    }
                    RecordReader.Close();
                  //  OwingStatus(person);
                  //  if(OwingStatus(person)==false)
                    { 
                        try
                        {
                            string insertquery = "INSERT INTO SESSION (EntryTime, visitor_id, Status) VALUES ('" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "'," + "'" + checkedinperson.ID.ToString() + "'," + "'" + checkedinperson.Status.ToString() + "')";
                            MySqlCommand sqlcmd = new MySqlCommand(insertquery, connectionToDB);
                            sqlcmd.ExecuteNonQuery();
                        }
                        catch 
                        {
                            MessageBox.Show("Return your lendings");
                        }

                    }



                }
                catch (Exception ex)
                {
                  //  MessageBox.Show(ex.ToString());

                }
                finally
                {
                    CloseDatabase();
                }
            }
            

        }
       
        public bool OwingStatus(Visitor person)
        {
            bool burrowed = false;
            if(DatabaseConnection())
            {
                string query = "SELECT Count(Remarks) as Counter FROM RentalDetails WHERE Remarks ='" + "Burrowed" + "' AND visitor_id='" + person.ID.ToString() + "'";
                MySqlCommand cmd = null;
                MySqlDataReader datareader = null;
                cmd = connectionToDB.CreateCommand();
                cmd.CommandText = query;
                datareader = cmd.ExecuteReader();
                int count = Convert.ToInt32(datareader["Counter"]);
                if(count>0)
                {
                    burrowed = true;
                }
                else
                {
                    burrowed = false;
                }
            }
            return burrowed;
        }


        // Insert METHODS eNDS HERE
    }
}
