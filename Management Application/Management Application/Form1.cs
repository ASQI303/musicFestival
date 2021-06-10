using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Application
{
    public partial class Form1 : Form
    {

        private DatabaseConnector dbconnect;
        private Entrance ent;
        private Sales sale;
        private TopUp topup;
        private string infoMessage;
        private bool checking;
        public Form1()
        {
            InitializeComponent();
            dbconnect = new DatabaseConnector();
        }
        //Method to declare timer and assign Event
        private void Form1_Load(object sender, EventArgs e)
        {
            Timer timer1 = new Timer();
            timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Tick += new System.EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

       //Method to assign timer's work
        private void timer1_Tick(object sender, EventArgs e)
        {
            AutoRefreshEntranceInfo();
            dbconnect.CloseDatabase();

            AutoRefreshTopUpInfo();
            dbconnect.CloseDatabase();

            AutoRefreshSalesInfo();
            dbconnect.CloseDatabase();
            NetProfit();

        }

        //Method to Refresh Data
        
        public void AutoRefreshEntranceInfo()
        {
            ent = new Entrance();
            ent = dbconnect.EntranceInfo(out checking, out infoMessage);
            if(checking)
            {
                lbltotalNoOfVisitors.Text = ent.TotalNrOfVisitors.ToString();
                lbltotalchekin.Text = ent.TotalNrofCheckedInVisitors.ToString();
                lbltotalcheckedout.Text = ent.TotalNrOfVisitorsCheckedOut.ToString();
                lbltotalearned.Text = "€ " + ent.TotalEarnedFromEntrance(ent.TotalNrOfVisitors).ToString();
            }
            else
            {
                MessageBox.Show(infoMessage);
            }
          
           

        }

        public void AutoRefreshSalesInfo()
        {
            sale = new Sales();
            sale = dbconnect.SalesInfo(out checking, out infoMessage);
            if(checking)
            {
                lbltotalNoOfBuyers.Text = sale.TotalNrOfVisitorBuyFood.ToString();
                lbltotalsale.Text = "€ " + sale.TotalEarnedFromFood.ToString();
            }
            else
            {
                MessageBox.Show(infoMessage);
            }

        }
        public void AutoRefreshTopUpInfo()
        {
            topup = new TopUp();
            topup = dbconnect.TopUpInfo(out checking, out infoMessage);
            if(checking)
            {
                lbltotalTopUppers.Text =topup.TotalNumberOfVisitorToppingUp.ToString();
                lbltotaltopup.Text = "€ " + topup.TotalTopUpAmount.ToString();
                lbltotalrefund.Text = "€ " + topup.TotalToBeRefunded.ToString();
            }
            else
            {
                MessageBox.Show(infoMessage);
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        public void NetProfit()
        {
            lblnetprofit.Text = "€ " + (ent.TotalEarnedFromEntrance(ent.TotalNrOfVisitors)+topup.TotalTopUpAmount - topup.TotalToBeRefunded+sale.TotalEarnedFromFood).ToString();
        }
    }
}
