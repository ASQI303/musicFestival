using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidgets;
using Phidgets.Events;
using System.IO;



namespace TopUpMoney
{
    public partial class Form1 : Form
    {
        //Objects


        private RFID ERFID;
        private DatabaseConnector dbconnect;
        private Person visitor;
        private string tagString;


        public Form1()
        {
            InitializeComponent();
            ERFID = new RFID();
            ERFID.Attach += new AttachEventHandler(ShowWhoIsAttached);
            ERFID.Detach += new DetachEventHandler(ShowWhoIsDeattached);
            dbconnect = new DatabaseConnector();
            try
            {
                ERFID.open();
                ERFID.waitForAttachment(3000);
                ERFID.Antenna = true;
                ERFID.LED = true;
            }
            catch (PhidgetException ex)
            {
                MessageBox.Show(ex.ToString() + "Connect the device Properly");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (dbconnect.DatabaseConnection())
            {
                ERFID.Tag += new TagEventHandler(ProcessRFIDTag);
                dbconnect.CloseDatabase();
            }
            else
            {
                MessageBox.Show("Database Connection Failed");
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Methods to be called by events
        public void ShowWhoIsAttached(object sender, AttachEventArgs e)
        {
            richTextBox1.Text = ("Connection Succesfull Please provide your card to scan");
        }

        public void ShowWhoIsDeattached(object sender, DetachEventArgs e)
        {
            MessageBox.Show("RFID Reader with Serial Number" + e.Device.SerialNumber + " has been deattached, Please re-connect it.");
        }

        public void ProcessRFIDTag(object sender, TagEventArgs e)

        {
            richTextBox1.Text = "Your card has been scanned. Thank You";
            tagString = e.Tag.ToString();
            try
            {
                visitor = dbconnect.TagCheckedIn(tagString);
                lblName.Text = (visitor.FirstName + " " + visitor.LastName);
                lblAddress.Text = visitor.Address;
                lblEmail.Text = visitor.Email;
                lblBalance.Text = "€ " + visitor.Balance.ToString();
                lblNewBalance.Text = "------";
                lblrfidnumber.Text = visitor.RFIDCode.ToString();
            }
            catch (Exception ex)
            {
                richTextBox1.Text = ex.Message + Environment.NewLine + "Please scan another card";
                lblName.Text = "Unknown";
                lblAddress.Text = "Unknown";
                lblEmail.Text = "Unknown";
                lblBalance.Text = "Unknown";
                

            }
            finally
            {
                //Always close Database after retriving data
                dbconnect.CloseDatabase();
            }


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ERFID.Antenna = false;
            ERFID.LED = false;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            ERFID.LED = false;
        }

        private void cbxAmount_DropDown(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        /// <summary>
        /// Method to read from file and check if it is correct file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                StreamReader sr = null;
                StreamWriter sw = null;

                try
                {
                    fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.ReadWrite);
                    sr = new StreamReader(fs);
                    sw = new StreamWriter(fs);
                    
                    string line;
                    line = sr.ReadLine();
                    if (line == (visitor.FirstName + " " + visitor.LastName + " " + visitor.Address + " ").ToString())
                    {

                        decimal amount = Decimal.Parse(sr.ReadLine());
                        string pStatus = sr.ReadLine();
                        if (pStatus.ToUpper() == "NOT USED")
                        {
                            //Passes visitor object to database connector class.
                            dbconnect.UpdateBalance(visitor, amount);
                            lblNewBalance.Text = "€ " + (visitor.Balance + amount).ToString();
                            //pStatus = "Used on " + DateTime.Now.ToString();
                            //sw.WriteLine(pStatus);



                        }
                        else
                        {
                            richTextBox1.Text = "This log file has already been used";
                        }
                    }
                    else
                    {
                        richTextBox1.Text = "Please use your own log file";
                    }



                }
                catch (IOException)

                {
                    MessageBox.Show("Something Wrong with IO");
                }
                finally
                {
                    if (fs != null)
                    {
                        fs.Close();
                    }
                }

            }

        }







    }
}
