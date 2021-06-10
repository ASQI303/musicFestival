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
using MySql.Data;
using Phidgets.Events;
using System.IO;

namespace Refund_Application
{
    public partial class refundapplication : Form
    {

        private RFID myrfid;
        private DatabaseHelper dbconnect;
        private Visitor person;
        private string Tagstring;
        

     
        public refundapplication()
        {
            InitializeComponent();
            
            myrfid = new RFID();
            myrfid.Attach += new AttachEventHandler(ShowWhoIsAttached);
            myrfid.Detach += new DetachEventHandler(ShowWhoIsDeattached);
            dbconnect = new DatabaseHelper();
            try
            {
                myrfid.open();
                myrfid.waitForAttachment(3000);
                myrfid.Antenna = true;
                myrfid.LED = true;

            }
            catch (PhidgetException ex)
            {
               lblstatus.Text = (ex.ToString() + " Connect the device properly" + Environment.NewLine);
            }

        }

        private void refundapplication_Load(object sender, EventArgs e)
        {

            if (dbconnect.DatabaseConnection())
            {
                myrfid.Tag += new TagEventHandler(TagProcess);
                dbconnect.CloseDatabase();
            }
            else { 
            lblstatus.Text = "Connection to Database Failed";
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        public void ShowWhoIsAttached(object sender,AttachEventArgs e)
        {
         lblstatus.Text =(myrfid.SerialNumber.ToString() + " is connected successfully" + Environment.NewLine);
        }
        public void ShowWhoIsDeattached(object sender, DetachEventArgs e)
        {
           lblstatus.Text=(myrfid.SerialNumber.ToString() + " has been plugout" + Environment.NewLine);
        }

        public void TagProcess(object sender,TagEventArgs e)
        {
          lblstatus.Text = "Your Card has been Successfully scanned" + Environment.NewLine + "Thank You";
            Tagstring = e.Tag.ToString();
            try
            {
                
                person = dbconnect.TagCheckedIn(Tagstring);
                tbxvisitorsName.Text = person.FirstName + " " + person.LastName;
                tbxAmount.Text = "€ " + person.Balance.ToString();
                tbxRFIDNumber.Text = person.RFIDCode.ToString();
            tbxvisitorsemail.Text = person.Email;
                tbxaddress.Text = person.Address;
                
          }
            catch (AppException ex)
            {
                lblstatus.Text = ex.ToString();
                tbxvisitorsName.Text = "Unknown";
                tbxAmount.Text = "Unknown";
                tbxvisitorsemail.Text = "Unknown";
                tbxaddress.Text = "Unknown";
                tbxRFIDNumber.Text = Tagstring.ToString();
            }
            catch (Exception ex)
            {
                lblstatus.Text =
                     "Please scan another card";
                tbxvisitorsName.Text = "Unknown";
                tbxAmount.Text = "Unknown";
                tbxvisitorsemail.Text = "Unknown";
                tbxaddress.Text = "Unknown";
                tbxRFIDNumber.Text = Tagstring.ToString();

            }
          
            finally
            {
                dbconnect.CloseDatabase();
            }
        }

        private void refundapplication_FormClosed(object sender, FormClosedEventArgs e)
        {
            myrfid.LED = false;
            myrfid.Antenna = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                FileStream fs = null;
                StreamWriter sw = null;
                fs = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                sw = new StreamWriter(fs);
                sw.WriteLine(person.FirstName + " " + person.LastName + "," + person.Address + "," + person.Email + ",€ " + person.Balance.ToString() + "- To be Refunded \n");
            }

        }
    }
}
