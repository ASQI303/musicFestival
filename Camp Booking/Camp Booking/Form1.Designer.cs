namespace Camp_Booking
{
    partial class BookCamping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookCamping));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.lbxGroupMembers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxGroupMemberGate = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblGroupLName = new System.Windows.Forms.Label();
            this.lblRfidnumber = new System.Windows.Forms.Label();
            this.lblSiteNumber = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblcheckinout = new System.Windows.Forms.Label();
            this.lblWelcomeforCamping = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.White;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(743, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(125, 94);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // lbxGroupMembers
            // 
            this.lbxGroupMembers.FormattingEnabled = true;
            this.lbxGroupMembers.Location = new System.Drawing.Point(25, 251);
            this.lbxGroupMembers.Name = "lbxGroupMembers";
            this.lbxGroupMembers.Size = new System.Drawing.Size(182, 147);
            this.lbxGroupMembers.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Group Members";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(683, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Members at Gate";
            // 
            // lbxGroupMemberGate
            // 
            this.lbxGroupMemberGate.FormattingEnabled = true;
            this.lbxGroupMemberGate.Location = new System.Drawing.Point(686, 251);
            this.lbxGroupMemberGate.Name = "lbxGroupMemberGate";
            this.lbxGroupMemberGate.Size = new System.Drawing.Size(182, 147);
            this.lbxGroupMemberGate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Group Leader Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblSiteNumber);
            this.groupBox1.Controls.Add(this.lblRfidnumber);
            this.groupBox1.Controls.Add(this.lblGroupLName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(271, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 179);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "RFID Number :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Site Number :";
            // 
            // lblGroupLName
            // 
            this.lblGroupLName.AutoSize = true;
            this.lblGroupLName.BackColor = System.Drawing.Color.Transparent;
            this.lblGroupLName.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupLName.ForeColor = System.Drawing.Color.White;
            this.lblGroupLName.Location = new System.Drawing.Point(169, 16);
            this.lblGroupLName.Name = "lblGroupLName";
            this.lblGroupLName.Size = new System.Drawing.Size(103, 16);
            this.lblGroupLName.TabIndex = 8;
            this.lblGroupLName.Text = "Y Chaudhary";
            // 
            // lblRfidnumber
            // 
            this.lblRfidnumber.AutoSize = true;
            this.lblRfidnumber.BackColor = System.Drawing.Color.Transparent;
            this.lblRfidnumber.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRfidnumber.ForeColor = System.Drawing.Color.White;
            this.lblRfidnumber.Location = new System.Drawing.Point(169, 49);
            this.lblRfidnumber.Name = "lblRfidnumber";
            this.lblRfidnumber.Size = new System.Drawing.Size(96, 16);
            this.lblRfidnumber.TabIndex = 9;
            this.lblRfidnumber.Text = "0987654321";
            // 
            // lblSiteNumber
            // 
            this.lblSiteNumber.AutoSize = true;
            this.lblSiteNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblSiteNumber.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiteNumber.ForeColor = System.Drawing.Color.White;
            this.lblSiteNumber.Location = new System.Drawing.Point(169, 77);
            this.lblSiteNumber.Name = "lblSiteNumber";
            this.lblSiteNumber.Size = new System.Drawing.Size(34, 16);
            this.lblSiteNumber.TabIndex = 10;
            this.lblSiteNumber.Text = "001";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(22, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Status:";
            // 
            // lblcheckinout
            // 
            this.lblcheckinout.AutoSize = true;
            this.lblcheckinout.BackColor = System.Drawing.Color.Transparent;
            this.lblcheckinout.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcheckinout.ForeColor = System.Drawing.Color.White;
            this.lblcheckinout.Location = new System.Drawing.Point(95, 447);
            this.lblcheckinout.Name = "lblcheckinout";
            this.lblcheckinout.Size = new System.Drawing.Size(183, 18);
            this.lblcheckinout.TabIndex = 8;
            this.lblcheckinout.Text = "CheckedIn/Checkout";
            // 
            // lblWelcomeforCamping
            // 
            this.lblWelcomeforCamping.AutoSize = true;
            this.lblWelcomeforCamping.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcomeforCamping.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeforCamping.ForeColor = System.Drawing.Color.Transparent;
            this.lblWelcomeforCamping.Location = new System.Drawing.Point(25, 33);
            this.lblWelcomeforCamping.Name = "lblWelcomeforCamping";
            this.lblWelcomeforCamping.Size = new System.Drawing.Size(258, 25);
            this.lblWelcomeforCamping.TabIndex = 9;
            this.lblWelcomeforCamping.Text = "Welcome to Camping Site";
            this.lblWelcomeforCamping.Click += new System.EventHandler(this.lblWelcomeforCamping_Click);
            // 
            // BookCamping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(892, 495);
            this.Controls.Add(this.lblWelcomeforCamping);
            this.Controls.Add(this.lblcheckinout);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbxGroupMemberGate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxGroupMembers);
            this.Controls.Add(this.Logo);
            this.Name = "BookCamping";
            this.Text = "Camping";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.ListBox lbxGroupMembers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxGroupMemberGate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSiteNumber;
        private System.Windows.Forms.Label lblRfidnumber;
        private System.Windows.Forms.Label lblGroupLName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblcheckinout;
        private System.Windows.Forms.Label lblWelcomeforCamping;
    }
}

