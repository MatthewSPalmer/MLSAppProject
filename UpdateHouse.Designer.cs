namespace MLSApp
{
    partial class UpdateHouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateHouse));
            this.lblMLS = new System.Windows.Forms.Label();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.pictureBoxHouse = new System.Windows.Forms.PictureBox();
            this.groupBoxDescription = new System.Windows.Forms.GroupBox();
            this.richTextDescription = new System.Windows.Forms.RichTextBox();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.txtBath = new System.Windows.Forms.TextBox();
            this.txtBed = new System.Windows.Forms.TextBox();
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.lblZip = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblBath = new System.Windows.Forms.Label();
            this.lblBed = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnUpdateHouseSubmit = new System.Windows.Forms.Button();
            this.btnRemovePicture = new System.Windows.Forms.Button();
            this.openPictureFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHouse)).BeginInit();
            this.groupBoxDescription.SuspendLayout();
            this.groupBoxDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMLS
            // 
            this.lblMLS.AutoSize = true;
            this.lblMLS.BackColor = System.Drawing.Color.Transparent;
            this.lblMLS.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMLS.Location = new System.Drawing.Point(333, 45);
            this.lblMLS.Name = "lblMLS";
            this.lblMLS.Size = new System.Drawing.Size(673, 65);
            this.lblMLS.TabIndex = 22;
            this.lblMLS.Text = "Make-believe Listing System";
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCloseForm.FlatAppearance.BorderSize = 3;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCloseForm.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm.Location = new System.Drawing.Point(80, 765);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(291, 70);
            this.btnCloseForm.TabIndex = 40;
            this.btnCloseForm.Text = "Go Back";
            this.btnCloseForm.UseVisualStyleBackColor = false;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.BackColor = System.Drawing.Color.Transparent;
            this.lblFileName.Location = new System.Drawing.Point(36, 473);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(79, 30);
            this.lblFileName.TabIndex = 44;
            this.lblFileName.Text = "Picture";
            // 
            // pictureBoxHouse
            // 
            this.pictureBoxHouse.Location = new System.Drawing.Point(41, 508);
            this.pictureBoxHouse.Name = "pictureBoxHouse";
            this.pictureBoxHouse.Size = new System.Drawing.Size(389, 183);
            this.pictureBoxHouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHouse.TabIndex = 43;
            this.pictureBoxHouse.TabStop = false;
            // 
            // groupBoxDescription
            // 
            this.groupBoxDescription.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxDescription.Controls.Add(this.richTextDescription);
            this.groupBoxDescription.Location = new System.Drawing.Point(449, 473);
            this.groupBoxDescription.Name = "groupBoxDescription";
            this.groupBoxDescription.Size = new System.Drawing.Size(602, 218);
            this.groupBoxDescription.TabIndex = 42;
            this.groupBoxDescription.TabStop = false;
            this.groupBoxDescription.Text = "Description";
            // 
            // richTextDescription
            // 
            this.richTextDescription.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.richTextDescription.Location = new System.Drawing.Point(6, 35);
            this.richTextDescription.Name = "richTextDescription";
            this.richTextDescription.Size = new System.Drawing.Size(590, 177);
            this.richTextDescription.TabIndex = 0;
            this.richTextDescription.Text = "";
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxDetails.Controls.Add(this.btnRemovePicture);
            this.groupBoxDetails.Controls.Add(this.txtBath);
            this.groupBoxDetails.Controls.Add(this.txtBed);
            this.groupBoxDetails.Controls.Add(this.btnAddPicture);
            this.groupBoxDetails.Controls.Add(this.lblZip);
            this.groupBoxDetails.Controls.Add(this.txtZip);
            this.groupBoxDetails.Controls.Add(this.comboBoxState);
            this.groupBoxDetails.Controls.Add(this.lblState);
            this.groupBoxDetails.Controls.Add(this.lblCity);
            this.groupBoxDetails.Controls.Add(this.txtCity);
            this.groupBoxDetails.Controls.Add(this.lblStreet);
            this.groupBoxDetails.Controls.Add(this.txtStreet);
            this.groupBoxDetails.Controls.Add(this.lblBath);
            this.groupBoxDetails.Controls.Add(this.lblBed);
            this.groupBoxDetails.Controls.Add(this.lblArea);
            this.groupBoxDetails.Controls.Add(this.txtArea);
            this.groupBoxDetails.Controls.Add(this.lblPrice);
            this.groupBoxDetails.Controls.Add(this.txtPrice);
            this.groupBoxDetails.Location = new System.Drawing.Point(41, 210);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(1010, 247);
            this.groupBoxDetails.TabIndex = 41;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Details";
            // 
            // txtBath
            // 
            this.txtBath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.txtBath.Location = new System.Drawing.Point(372, 130);
            this.txtBath.Name = "txtBath";
            this.txtBath.Size = new System.Drawing.Size(96, 36);
            this.txtBath.TabIndex = 3;
            this.txtBath.TextChanged += new System.EventHandler(this.txtBath_TextChanged);
            // 
            // txtBed
            // 
            this.txtBed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.txtBed.Location = new System.Drawing.Point(372, 55);
            this.txtBed.Name = "txtBed";
            this.txtBed.Size = new System.Drawing.Size(96, 36);
            this.txtBed.TabIndex = 2;
            this.txtBed.TextChanged += new System.EventHandler(this.txtBed_TextChanged);
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAddPicture.FlatAppearance.BorderSize = 3;
            this.btnAddPicture.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddPicture.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPicture.Location = new System.Drawing.Point(25, 188);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(191, 45);
            this.btnAddPicture.TabIndex = 9;
            this.btnAddPicture.Text = "Add Picture";
            this.btnAddPicture.UseVisualStyleBackColor = false;
            this.btnAddPicture.Visible = false;
            this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.BackColor = System.Drawing.Color.Transparent;
            this.lblZip.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZip.Location = new System.Drawing.Point(674, 188);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(72, 45);
            this.lblZip.TabIndex = 45;
            this.lblZip.Text = "Zip:";
            // 
            // txtZip
            // 
            this.txtZip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.txtZip.Location = new System.Drawing.Point(776, 197);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(146, 36);
            this.txtZip.TabIndex = 7;
            this.txtZip.TextChanged += new System.EventHandler(this.txtZip_TextChanged);
            // 
            // comboBoxState
            // 
            this.comboBoxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxState.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.comboBoxState.Location = new System.Drawing.Point(576, 197);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(76, 38);
            this.comboBoxState.TabIndex = 6;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.BackColor = System.Drawing.Color.Transparent;
            this.lblState.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(474, 190);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(98, 45);
            this.lblState.TabIndex = 43;
            this.lblState.Text = "State:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(474, 121);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(81, 45);
            this.lblCity.TabIndex = 41;
            this.lblCity.Text = "City:";
            // 
            // txtCity
            // 
            this.txtCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.txtCity.Location = new System.Drawing.Point(576, 130);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(428, 36);
            this.txtCity.TabIndex = 5;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.BackColor = System.Drawing.Color.Transparent;
            this.lblStreet.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(474, 46);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(110, 45);
            this.lblStreet.TabIndex = 39;
            this.lblStreet.Text = "Street:";
            // 
            // txtStreet
            // 
            this.txtStreet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.txtStreet.Location = new System.Drawing.Point(590, 55);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(414, 36);
            this.txtStreet.TabIndex = 4;
            // 
            // lblBath
            // 
            this.lblBath.AutoSize = true;
            this.lblBath.BackColor = System.Drawing.Color.Transparent;
            this.lblBath.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBath.Location = new System.Drawing.Point(285, 121);
            this.lblBath.Name = "lblBath";
            this.lblBath.Size = new System.Drawing.Size(90, 45);
            this.lblBath.TabIndex = 36;
            this.lblBath.Text = "Bath:";
            // 
            // lblBed
            // 
            this.lblBed.AutoSize = true;
            this.lblBed.BackColor = System.Drawing.Color.Transparent;
            this.lblBed.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBed.Location = new System.Drawing.Point(285, 46);
            this.lblBed.Name = "lblBed";
            this.lblBed.Size = new System.Drawing.Size(81, 45);
            this.lblBed.TabIndex = 35;
            this.lblBed.Text = "Bed:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.BackColor = System.Drawing.Color.Transparent;
            this.lblArea.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(17, 121);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(92, 45);
            this.lblArea.TabIndex = 33;
            this.lblArea.Text = "Area:";
            // 
            // txtArea
            // 
            this.txtArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.txtArea.Location = new System.Drawing.Point(119, 130);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(146, 36);
            this.txtArea.TabIndex = 1;
            this.txtArea.TextChanged += new System.EventHandler(this.txtArea_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(17, 46);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(96, 45);
            this.lblPrice.TabIndex = 15;
            this.lblPrice.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.txtPrice.Location = new System.Drawing.Point(119, 55);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(146, 36);
            this.txtPrice.TabIndex = 0;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // btnUpdateHouseSubmit
            // 
            this.btnUpdateHouseSubmit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnUpdateHouseSubmit.FlatAppearance.BorderSize = 3;
            this.btnUpdateHouseSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateHouseSubmit.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateHouseSubmit.Location = new System.Drawing.Point(390, 765);
            this.btnUpdateHouseSubmit.Name = "btnUpdateHouseSubmit";
            this.btnUpdateHouseSubmit.Size = new System.Drawing.Size(291, 70);
            this.btnUpdateHouseSubmit.TabIndex = 0;
            this.btnUpdateHouseSubmit.Text = "Update MLS";
            this.btnUpdateHouseSubmit.UseVisualStyleBackColor = false;
            this.btnUpdateHouseSubmit.Click += new System.EventHandler(this.btnUpdateHouseSubmit_Click);
            // 
            // btnRemovePicture
            // 
            this.btnRemovePicture.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnRemovePicture.FlatAppearance.BorderSize = 3;
            this.btnRemovePicture.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemovePicture.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovePicture.Location = new System.Drawing.Point(241, 188);
            this.btnRemovePicture.Name = "btnRemovePicture";
            this.btnRemovePicture.Size = new System.Drawing.Size(191, 45);
            this.btnRemovePicture.TabIndex = 8;
            this.btnRemovePicture.Text = "Remove Picture";
            this.btnRemovePicture.UseVisualStyleBackColor = false;
            this.btnRemovePicture.Click += new System.EventHandler(this.btnRemovePicture_Click);
            // 
            // openPictureFileDialog
            // 
            this.openPictureFileDialog.FileName = "openFileDialog1";
            this.openPictureFileDialog.Filter = "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif|All files|*.*";
            this.openPictureFileDialog.FilterIndex = 0;
            this.openPictureFileDialog.InitialDirectory = "C:\\HousePictures";
            // 
            // UpdateHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1084, 861);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.pictureBoxHouse);
            this.Controls.Add(this.groupBoxDescription);
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.btnUpdateHouseSubmit);
            this.Controls.Add(this.lblMLS);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "UpdateHouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Listing";
            this.Load += new System.EventHandler(this.UpdateHouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHouse)).EndInit();
            this.groupBoxDescription.ResumeLayout(false);
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMLS;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.PictureBox pictureBoxHouse;
        private System.Windows.Forms.GroupBox groupBoxDescription;
        private System.Windows.Forms.RichTextBox richTextDescription;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.TextBox txtBath;
        private System.Windows.Forms.TextBox txtBed;
        private System.Windows.Forms.Button btnAddPicture;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblBath;
        private System.Windows.Forms.Label lblBed;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnUpdateHouseSubmit;
        private System.Windows.Forms.Button btnRemovePicture;
        private System.Windows.Forms.OpenFileDialog openPictureFileDialog;
    }
}