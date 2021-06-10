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

namespace Rental_items
{
    public partial class Form1 : Form
    {
        private Shop myshop;
        private List<items> selecteditems;
        private string tagString;
        private RFID ERFID;
        private DatabaseHelper Connectdatabase;
        private Visitor person;
        private decimal totalBillAmount;
        
        public Form1()
        {
            InitializeComponent();
            this.myshop = new Shop();
            this.selecteditems = new List<items>();

            ERFID = new RFID();
            ERFID.Attach += new AttachEventHandler(ShowWhoIsAttached);
            ERFID.Detach += new DetachEventHandler(ShowWhoIsDeattached);
            Connectdatabase = new DatabaseHelper();
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

        public void ShowWhoIsAttached(object sender, AttachEventArgs e)
        {
            richTextBox1.Text = ("Connection Succesfull Please proovide your card to scan");
        }

        public void ShowWhoIsDeattached(object sender, DetachEventArgs e)
        {
            MessageBox.Show("RFID Reader with Serial Number" + e.Device.SerialNumber + " has been deattached, Please re-connect it.");
        }
        
        private void button7_Click(object sender, EventArgs e)
        {

            string order = "";
            totalBillAmount = 0;
            foreach (items i in selecteditems)
            {
                order += "Name: " + i.Name + " Price: " + i.Price + "\r\n";
                totalBillAmount += i.Price;
            }
            order += "Total price for items is: " + totalBillAmount;
            MessageBox.Show(order);
            
            label1.Text = "Subtotal:"+ totalBillAmount + "€";
            Connectdatabase.DeductBalance(person, totalBillAmount);
            Connectdatabase.RentingDetails(selecteditems);
            lblpaid.Text = "Paid";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("You have rented a Boat, the price is 100");
            selecteditems.Add(myshop.getitems().Find(x => x.Name == "Boat"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("You have rented a Boat, the price is 3");
            selecteditems.Add(myshop.getitems().Find(x => x.Name == "Light sticker"));
        }

        private void button3_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add("You have rented a Yogo Bat, the price is 4");
            selecteditems.Add(myshop.getitems().Find(x => x.Name == "Yoga bat"));
        }

        private void button4_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add("You have rented a Kite, the price is 10");
            selecteditems.Add(myshop.getitems().Find(x => x.Name == "Kite"));
        }

        private void button6_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add("You have rented some tools for making dumpling, the price is 10");
            selecteditems.Add(myshop.getitems().Find(x => x.Name == "Tools for making dumpling"));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("You have rented a Tent, the price is 20");
            selecteditems.Add(myshop.getitems().Find(x => x.Name == "Tent"));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            selecteditems.Clear();
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            label1.Text = " ";
        }

        private void lblpaid_Click(object sender, EventArgs e)
        {
            
        }

        private void button23_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rental items:\nBoat:  100€ per day\nLight sticker:  3€ per day\nYoga bat:  4€ per day\nKite:  10€ per day\nTools for making dumpling:  10€\nTent:  20€ per day");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Connectdatabase.DatabaseConnection()) // if connection is true...
            {
                label14.Text = " The Device is Ready";
                ERFID.Tag += new TagEventHandler(ProcessInfo);
                Connectdatabase.CloseDatabase(); // after tag processing,database is closed;
            }
            else
            {
                label14.Text = "Database Connection Failed";
                richTextBox1.AppendText("Cannot Process the Tag" + Environment.NewLine);
            }
        }

        public void ProcessInfo(object sender, TagEventArgs e)
        {
            listBox1.Items.Clear();
            label13.Text = null;
            tagString = e.Tag.ToString();
            person = Connectdatabase.TagCheckedIn(tagString);


            label3.Text = person.FirstName + " " + person.LastName;
            label7.Text = person.City;
            label9.Text = person.Country;
            label11.Text = person.RfidCode.ToString();

            Connectdatabase.ReadBalance(person, totalBillAmount);
            label13.Text = "€ " + person.Balance.ToString();

        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            Connectdatabase.ReturnItems(selecteditems);
            lblpaid.Text = " Returned";

        }
    }
}
