namespace Management_Application
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltotalNoOfBuyers = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbltotalsale = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.lbltotalTopUppers = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbltotaltopup = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbltotalrefund = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltotalNoOfVisitors = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltotalearned = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltotalchekin = new System.Windows.Forms.Label();
            this.totalchekedout = new System.Windows.Forms.Label();
            this.lbltotalcheckedout = new System.Windows.Forms.Label();
            this.tab_control = new System.Windows.Forms.TabControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblnetprofit = new System.Windows.Forms.Label();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tab_control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lbltotalsale);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.lbltotalNoOfBuyers);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(370, 253);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sales";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total Number of Buyers :";
            // 
            // lbltotalNoOfBuyers
            // 
            this.lbltotalNoOfBuyers.AutoSize = true;
            this.lbltotalNoOfBuyers.Location = new System.Drawing.Point(146, 75);
            this.lbltotalNoOfBuyers.Name = "lbltotalNoOfBuyers";
            this.lbltotalNoOfBuyers.Size = new System.Drawing.Size(0, 13);
            this.lbltotalNoOfBuyers.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Total Sale : ";
            // 
            // lbltotalsale
            // 
            this.lbltotalsale.AutoSize = true;
            this.lbltotalsale.Location = new System.Drawing.Point(146, 110);
            this.lbltotalsale.Name = "lbltotalsale";
            this.lbltotalsale.Size = new System.Drawing.Size(0, 13);
            this.lbltotalsale.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbltotalrefund);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.lbltotaltopup);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.lbltotalTopUppers);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(370, 253);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "TopUp";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nr. of Visitors Topping Up :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbltotalTopUppers
            // 
            this.lbltotalTopUppers.AutoSize = true;
            this.lbltotalTopUppers.Location = new System.Drawing.Point(177, 51);
            this.lbltotalTopUppers.Name = "lbltotalTopUppers";
            this.lbltotalTopUppers.Size = new System.Drawing.Size(0, 13);
            this.lbltotalTopUppers.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Total TopUp Amount : ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // lbltotaltopup
            // 
            this.lbltotaltopup.AutoSize = true;
            this.lbltotaltopup.Location = new System.Drawing.Point(177, 82);
            this.lbltotaltopup.Name = "lbltotaltopup";
            this.lbltotaltopup.Size = new System.Drawing.Size(0, 13);
            this.lbltotaltopup.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Total Amount To be Refunded  : ";
            // 
            // lbltotalrefund
            // 
            this.lbltotalrefund.AutoSize = true;
            this.lbltotalrefund.Location = new System.Drawing.Point(177, 123);
            this.lbltotalrefund.Name = "lbltotalrefund";
            this.lbltotalrefund.Size = new System.Drawing.Size(0, 13);
            this.lbltotalrefund.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbltotalcheckedout);
            this.tabPage1.Controls.Add(this.totalchekedout);
            this.tabPage1.Controls.Add(this.lbltotalchekin);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lbltotalearned);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lbltotalNoOfVisitors);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(370, 253);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Entrance";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Number Of Visitors :";
            // 
            // lbltotalNoOfVisitors
            // 
            this.lbltotalNoOfVisitors.AutoSize = true;
            this.lbltotalNoOfVisitors.Location = new System.Drawing.Point(161, 51);
            this.lbltotalNoOfVisitors.Name = "lbltotalNoOfVisitors";
            this.lbltotalNoOfVisitors.Size = new System.Drawing.Size(0, 13);
            this.lbltotalNoOfVisitors.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total Earned From Entrance : ";
            // 
            // lbltotalearned
            // 
            this.lbltotalearned.AutoSize = true;
            this.lbltotalearned.Location = new System.Drawing.Point(161, 139);
            this.lbltotalearned.Name = "lbltotalearned";
            this.lbltotalearned.Size = new System.Drawing.Size(0, 13);
            this.lbltotalearned.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nr. Of CheckedIn Visitors :";
            // 
            // lbltotalchekin
            // 
            this.lbltotalchekin.AutoSize = true;
            this.lbltotalchekin.Location = new System.Drawing.Point(161, 78);
            this.lbltotalchekin.Name = "lbltotalchekin";
            this.lbltotalchekin.Size = new System.Drawing.Size(0, 13);
            this.lbltotalchekin.TabIndex = 8;
            // 
            // totalchekedout
            // 
            this.totalchekedout.AutoSize = true;
            this.totalchekedout.Location = new System.Drawing.Point(6, 107);
            this.totalchekedout.Name = "totalchekedout";
            this.totalchekedout.Size = new System.Drawing.Size(126, 13);
            this.totalchekedout.TabIndex = 9;
            this.totalchekedout.Text = "Nr. Of Checkout Visitors :";
            // 
            // lbltotalcheckedout
            // 
            this.lbltotalcheckedout.AutoSize = true;
            this.lbltotalcheckedout.Location = new System.Drawing.Point(161, 107);
            this.lbltotalcheckedout.Name = "lbltotalcheckedout";
            this.lbltotalcheckedout.Size = new System.Drawing.Size(0, 13);
            this.lbltotalcheckedout.TabIndex = 10;
            // 
            // tab_control
            // 
            this.tab_control.Controls.Add(this.tabPage1);
            this.tab_control.Controls.Add(this.tabPage2);
            this.tab_control.Controls.Add(this.tabPage3);
            this.tab_control.Location = new System.Drawing.Point(13, 12);
            this.tab_control.Name = "tab_control";
            this.tab_control.SelectedIndex = 0;
            this.tab_control.Size = new System.Drawing.Size(378, 279);
            this.tab_control.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(432, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 91);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(432, 196);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(110, 91);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Net Profit :";
            // 
            // lblnetprofit
            // 
            this.lblnetprofit.AutoSize = true;
            this.lblnetprofit.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnetprofit.Location = new System.Drawing.Point(87, 309);
            this.lblnetprofit.Name = "lblnetprofit";
            this.lblnetprofit.Size = new System.Drawing.Size(43, 15);
            this.lblnetprofit.TabIndex = 4;
            this.lblnetprofit.Text = "******";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(579, 334);
            this.Controls.Add(this.lblnetprofit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tab_control);
            this.Name = "Form1";
            this.Text = "Overview of Event";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tab_control.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lbltotalsale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbltotalNoOfBuyers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbltotalrefund;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbltotaltopup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbltotalTopUppers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lbltotalcheckedout;
        private System.Windows.Forms.Label totalchekedout;
        private System.Windows.Forms.Label lbltotalchekin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltotalearned;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltotalNoOfVisitors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tab_control;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblnetprofit;
    }
}

