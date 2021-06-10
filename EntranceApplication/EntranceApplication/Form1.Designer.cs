namespace EntranceApplication
{
    partial class entranceapplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(entranceapplication));
            this.LogoNextDeveloper = new System.Windows.Forms.PictureBox();
            this.StatusRichTextBox = new System.Windows.Forms.RichTextBox();
            this.gbxVisitorsDetails = new System.Windows.Forms.GroupBox();
            this.lblYourstatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblrfid = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dblabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogoNextDeveloper)).BeginInit();
            this.gbxVisitorsDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoNextDeveloper
            // 
            this.LogoNextDeveloper.BackColor = System.Drawing.Color.Transparent;
            this.LogoNextDeveloper.Image = ((System.Drawing.Image)(resources.GetObject("LogoNextDeveloper.Image")));
            this.LogoNextDeveloper.Location = new System.Drawing.Point(571, 315);
            this.LogoNextDeveloper.Name = "LogoNextDeveloper";
            this.LogoNextDeveloper.Size = new System.Drawing.Size(149, 93);
            this.LogoNextDeveloper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoNextDeveloper.TabIndex = 0;
            this.LogoNextDeveloper.TabStop = false;
            // 
            // StatusRichTextBox
            // 
            this.StatusRichTextBox.Location = new System.Drawing.Point(57, 315);
            this.StatusRichTextBox.Name = "StatusRichTextBox";
            this.StatusRichTextBox.Size = new System.Drawing.Size(469, 96);
            this.StatusRichTextBox.TabIndex = 1;
            this.StatusRichTextBox.Text = "";
            // 
            // gbxVisitorsDetails
            // 
            this.gbxVisitorsDetails.Controls.Add(this.lblYourstatus);
            this.gbxVisitorsDetails.Controls.Add(this.label5);
            this.gbxVisitorsDetails.Controls.Add(this.lblrfid);
            this.gbxVisitorsDetails.Controls.Add(this.label4);
            this.gbxVisitorsDetails.Controls.Add(this.lblCountry);
            this.gbxVisitorsDetails.Controls.Add(this.label3);
            this.gbxVisitorsDetails.Controls.Add(this.lblCity);
            this.gbxVisitorsDetails.Controls.Add(this.lblName);
            this.gbxVisitorsDetails.Controls.Add(this.address);
            this.gbxVisitorsDetails.Controls.Add(this.name);
            this.gbxVisitorsDetails.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxVisitorsDetails.ForeColor = System.Drawing.Color.DarkGreen;
            this.gbxVisitorsDetails.Location = new System.Drawing.Point(426, 12);
            this.gbxVisitorsDetails.Name = "gbxVisitorsDetails";
            this.gbxVisitorsDetails.Size = new System.Drawing.Size(303, 175);
            this.gbxVisitorsDetails.TabIndex = 3;
            this.gbxVisitorsDetails.TabStop = false;
            this.gbxVisitorsDetails.Text = "Visitors Details";
            this.gbxVisitorsDetails.Enter += new System.EventHandler(this.gbxVisitorsDetails_Enter);
            // 
            // lblYourstatus
            // 
            this.lblYourstatus.AutoSize = true;
            this.lblYourstatus.Location = new System.Drawing.Point(94, 130);
            this.lblYourstatus.Name = "lblYourstatus";
            this.lblYourstatus.Size = new System.Drawing.Size(94, 19);
            this.lblYourstatus.TabIndex = 9;
            this.lblYourstatus.Text = "Your Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Status :";
            // 
            // lblrfid
            // 
            this.lblrfid.AutoSize = true;
            this.lblrfid.Location = new System.Drawing.Point(94, 102);
            this.lblrfid.Name = "lblrfid";
            this.lblrfid.Size = new System.Drawing.Size(115, 19);
            this.lblrfid.TabIndex = 7;
            this.lblrfid.Text = "Your RFID Tag";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "RFID :";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(94, 76);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(107, 19);
            this.lblCountry.TabIndex = 5;
            this.lblCountry.Text = "Your Country";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Country :";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(94, 51);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(76, 19);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "Your City";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(94, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 19);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Your Name";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(7, 51);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(45, 19);
            this.address.TabIndex = 1;
            this.address.Text = "City :";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(7, 29);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(59, 19);
            this.name.TabIndex = 0;
            this.name.Text = "Name :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(251, 188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 103);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(92, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Asian Music Safari";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Welcome to ";
            // 
            // dblabel
            // 
            this.dblabel.AutoSize = true;
            this.dblabel.BackColor = System.Drawing.Color.Transparent;
            this.dblabel.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dblabel.ForeColor = System.Drawing.Color.White;
            this.dblabel.Location = new System.Drawing.Point(53, 289);
            this.dblabel.Name = "dblabel";
            this.dblabel.Size = new System.Drawing.Size(65, 23);
            this.dblabel.TabIndex = 7;
            this.dblabel.Text = "Status";
            // 
            // entranceapplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(741, 436);
            this.Controls.Add(this.dblabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbxVisitorsDetails);
            this.Controls.Add(this.StatusRichTextBox);
            this.Controls.Add(this.LogoNextDeveloper);
            this.ForeColor = System.Drawing.Color.IndianRed;
            this.MaximizeBox = false;
            this.Name = "entranceapplication";
            this.Text = "Welcome to AMS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.entranceapplication_FormClosing);
            this.Load += new System.EventHandler(this.entranceapplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoNextDeveloper)).EndInit();
            this.gbxVisitorsDetails.ResumeLayout(false);
            this.gbxVisitorsDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoNextDeveloper;
        private System.Windows.Forms.RichTextBox StatusRichTextBox;
        private System.Windows.Forms.GroupBox gbxVisitorsDetails;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dblabel;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblrfid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblYourstatus;
    }
}

