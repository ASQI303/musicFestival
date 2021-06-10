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
using System.Data.SqlClient;
namespace EntranceApplication
{
    public partial class entranceapplication : Form
    {
        //Instance objects
        private RFID EventRFID;
        private DatabaseHelper Connectdatabase;
        private string tagString;
        private Visitor person;
       
        public entranceapplication()
        {
            InitializeComponent();
            EventRFID = new RFID();
            EventRFID.Attach += new AttachEventHandler(ShowWhoIsAttached);
            EventRFID.Detach += new DetachEventHandler(ShowWhoIsDeattached);
            Connectdatabase = new DatabaseHelper();
                    try
                    {
                        EventRFID.open();
                        EventRFID.waitForAttachment(3000);
                        EventRFID.Antenna = true;
                        EventRFID.LED = true;
                    }
                    catch (PhidgetException ex)
                    {
                        StatusRichTextBox.AppendText (ex.Message.ToString() + Environment.NewLine);
                        StatusRichTextBox.Text = "Connect the device properly";
                    }

           
        }

        private void entranceapplication_Load(object sender, EventArgs e)
        {
            if(Connectdatabase.DatabaseConnection()) // if connection is true...
            {
                dblabel.Text = " The Device is Ready";
                EventRFID.Tag += new TagEventHandler(ProcessInfo);
                Connectdatabase.CloseDatabase(); // after tag processing,database is closed;
            }
            else
            {
                dblabel.Text = "Database Connection Failed";
                StatusRichTextBox.AppendText("Cannot Process the Tag" + Environment.NewLine);
            }


        }


        private void AmsLogo_Click(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        public void ShowWhoIsAttached(object sender, AttachEventArgs e)
        {
            StatusRichTextBox.Text = "RFID attached, Serial Number" + e.Device.SerialNumber.ToString();
        }

        public void ShowWhoIsDeattached(object sender, DetachEventArgs e)
        {
            StatusRichTextBox.Text = "RFID deattached, Serial Number" + e.Device.SerialNumber.ToString();
            EventRFID.LED = false;
        }

        public void ProcessInfo(object sender, TagEventArgs e )
        {
            tagString = e.Tag.ToString();
            person = Connectdatabase.TagCheckedIn(tagString);
            lblName.Text = person.FirstName + " " + person.LastName;
            lblCity.Text = person.City;
            lblCountry.Text = person.Country;
            lblrfid.Text = person.RfidCode.ToString();
            if (person.EntryFee.ToUpper() =="PAID")
            {
                lblYourstatus.Text = person.Status.ToString();
            }
            else if(person.EntryFee==null)
            {
                lblYourstatus.Text = "-----";
;            }
            
            
        }

       
        private void gbxVisitorsDetails_Enter(object sender, EventArgs e)
        {

        }

        private void entranceapplication_FormClosing(object sender, FormClosingEventArgs e)
        {
            EventRFID.LED = false;
            EventRFID.Antenna = false;

        }
    }
}
