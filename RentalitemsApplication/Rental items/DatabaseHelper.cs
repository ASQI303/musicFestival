using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;

namespace Rental_items
{
    class DatabaseHelper
    {
        private string connectionInfo;
        private MySqlConnection connectionToDB;
        private Visitor person;
        private Shop myshopping;
        List<RentalRecords> Owe = new List<RentalRecords>();
        private bool owing;


        //Constructor to create Database connection
        public DatabaseHelper()
        {
            connectionInfo = "server=studmysql01.fhict.local;" + "Uid = dbi341965;" + "Database = dbi341965;" + "Pwd = Fontys123;" + "connect timeout = 30;";
            connectionToDB = new MySqlConnection(connectionInfo);

        }

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
                    string query = "SELECT v.visitor_id, v.FirstName,v.LastName,v.City,v.Country, r.RFID_String FROM visitors v, rfidassign r WHERE v.visitor_id = r.visitor_id AND r.RFID_String ='" + person.RfidCode.ToString() + "'";
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
                        CloseDatabase();
                    }

                }
                catch
                {
                    MessageBox.Show("Cannot Read From Database");
                }

            }
            return person;
        }

        //Method to read from Database
        public void ReadBalance(Visitor person, decimal amount)
        {
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
                        RecordRead.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("cannot find record");
                }
            }

            DeductBalance(person, amount);
        }

        /// <summary>
        /// ReadBalance --> Method to read available Balance from Database
        /// </summary>
        /// <param name="person"></param>
        /// <param name="amount"></param>

        public void DeductBalance(Visitor person, decimal amount)
        {
            //check for database connection

            if (DatabaseConnection())
            {

                person.NewBalance = person.Balance - amount;
                if (person.NewBalance > 0)
                {



                    try
                    {
                        string insertquery = "INSERT into balance (TopUpAmount, TopupTime, visitor_ID, Balance, Remarks) VALUES('-" + amount.ToString() + "','" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "'," + "'" + person.ID.ToString() + "'," + "'" + person.NewBalance.ToString() + "','RENT'" + ")";

                        MySqlCommand sqlcmd = new MySqlCommand(insertquery, connectionToDB);
                        sqlcmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());

                    }
                    finally
                    {
                        CloseDatabase();
                    }
                }
                else
                {
                    MessageBox.Show("Your Balance is low");
                }
            }
        }


        //all Methods Ends Here


        //public List<RentalRecords> CheckPreviousBurrowing(Visitor person, out bool owing)
        //{

        //    string Readquery = "SELECT ItemName, Remarks FROM RentalDetails WHERE REmarks ='Burrowed" + "' AND visitor_id ='" + person.ID.ToString() + "'";
        //    if (DatabaseConnection())
        //    {
        //        MySqlCommand cmd = null;
        //        MySqlDataReader datareader = null;
        //        cmd = connectionToDB.CreateCommand();
        //        cmd.CommandText = Readquery;
        //        datareader = cmd.ExecuteReader();
        //        while (datareader.Read())
        //        {
        //            string status = datareader["Remarks"].ToString();
        //            string namelabel = datareader["ItemName"].ToString();
        //            if (status == "Burrowed")
        //            {
        //                Owe.Add(new RentalRecords(namelabel, status));
        //                this.owing = true;
        //            } 
                    
                           
        //        }
                
                

        //    }
        //    else
        //    {
        //        this.owing = false;
        //    }
        //    owing = this.owing;
        //    return Owe;


        //}
        public void RentingDetails(List<items> selecteditems)
        {
          //  CheckPreviousBurrowing(person, out owing);
            List<items> temp = selecteditems;
            

            foreach (items i in temp)
            {
                //foreach (RentalRecords rr in Owe)
                //{
                //    if (owing == false || rr.ItemName.ToUpper() != i.Name.ToUpper())
                //    {

                        if (DatabaseConnection())
                        {


                            try
                            {
                                string query = "INSERT INTO RentalDetails(visitor_id,ItemName, RentalDate, Remarks)VALUES('" + person.ID.ToString() + "','" + i.Name + "','" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "'," + "'Burrowed " + "')";
                                MySqlCommand sqlcmd = new MySqlCommand(query, connectionToDB);
                                sqlcmd.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                            finally
                            {
                                CloseDatabase();

                            }
                        }
                //    }
                //    else
                //    {
                //        MessageBox.Show("Already Burrowed");
                //    }
                //}
            }
            selecteditems.Clear();
            //Owe.Clear();
        }



        public void ReturnItems(List<items> selecteditems)
        {
            foreach (items i in selecteditems)
            {
                if (DatabaseConnection())
                {
                    string update = "UPDATE RentalDetails SET ReturnDate ='" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "', Remarks=" + "'RETURNED' " + " WHERE visitor_id ='" + person.ID.ToString() + "' AND ItemName ='" + i.Name.ToString() + "'";
                    try
                    {
                        MySqlCommand sqlcmd = new MySqlCommand(update, connectionToDB);
                        sqlcmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        CloseDatabase();

                    }
                }

            }
            selecteditems.Clear();
        }


    }
}
