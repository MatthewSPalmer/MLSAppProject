namespace MLSApp
{
    partial class AgentPortal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgentPortal));
            this.lblMLS = new System.Windows.Forms.Label();
            this.lblAgentListings = new System.Windows.Forms.Label();
            this.btnUpdateAgent = new System.Windows.Forms.Button();
            this.txtCurrentAgentName = new System.Windows.Forms.TextBox();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.dataGridAgentListings = new System.Windows.Forms.DataGridView();
            this.btnAddHouse = new System.Windows.Forms.Button();
            this.groupBoxDescription = new System.Windows.Forms.GroupBox();
            this.richTextDescription = new System.Windows.Forms.RichTextBox();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.lblMLSNum = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblBath = new System.Windows.Forms.Label();
            this.lblBed = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnUpdateHouse = new System.Windows.Forms.Button();
            this.btnRemoveHouse = new System.Windows.Forms.Button();
            this.btnChangeAgent = new System.Windows.Forms.Button();
            this.btnClientPortal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAgentListings)).BeginInit();
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
            this.lblMLS.TabIndex = 1;
            this.lblMLS.Text = "Make-believe Listing System";
            // 
            // lblAgentListings
            // 
            this.lblAgentListings.AutoSize = true;
            this.lblAgentListings.BackColor = System.Drawing.Color.Transparent;
            this.lblAgentListings.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgentListings.Location = new System.Drawing.Point(336, 155);
            this.lblAgentListings.Name = "lblAgentListings";
            this.lblAgentListings.Size = new System.Drawing.Size(314, 45);
            this.lblAgentListings.TabIndex = 2;
            this.lblAgentListings.Text = "Your Current Listings";
            // 
            // btnUpdateAgent
            // 
            this.btnUpdateAgent.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnUpdateAgent.FlatAppearance.BorderSize = 3;
            this.btnUpdateAgent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateAgent.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAgent.Location = new System.Drawing.Point(435, 816);
            this.btnUpdateAgent.Name = "btnUpdateAgent";
            this.btnUpdateAgent.Size = new System.Drawing.Size(190, 41);
            this.btnUpdateAgent.TabIndex = 3;
            this.btnUpdateAgent.Text = "Update Agent";
            this.btnUpdateAgent.UseVisualStyleBackColor = false;
            this.btnUpdateAgent.Click += new System.EventHandler(this.btnUpdateAgent_Click);
            // 
            // txtCurrentAgentName
            // 
            this.txtCurrentAgentName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCurrentAgentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.txtCurrentAgentName.Location = new System.Drawing.Point(800, 822);
            this.txtCurrentAgentName.Name = "txtCurrentAgentName";
            this.txtCurrentAgentName.ReadOnly = true;
            this.txtCurrentAgentName.Size = new System.Drawing.Size(272, 29);
            this.txtCurrentAgentName.TabIndex = 8;
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentUser.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUser.Location = new System.Drawing.Point(639, 821);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(155, 30);
            this.lblCurrentUser.TabIndex = 9;
            this.lblCurrentUser.Text = "Current Agent:";
            // 
            // dataGridAgentListings
            // 
            this.dataGridAgentListings.AllowUserToAddRows = false;
            this.dataGridAgentListings.AllowUserToDeleteRows = false;
            this.dataGridAgentListings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridAgentListings.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridAgentListings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAgentListings.Location = new System.Drawing.Point(43, 203);
            this.dataGridAgentListings.Name = "dataGridAgentListings";
            this.dataGridAgentListings.ReadOnly = true;
            this.dataGridAgentListings.Size = new System.Drawing.Size(825, 328);
            this.dataGridAgentListings.TabIndex = 10;
            this.dataGridAgentListings.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAgentListings_CellClick);
            // 
            // btnAddHouse
            // 
            this.btnAddHouse.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAddHouse.FlatAppearance.BorderSize = 3;
            this.btnAddHouse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddHouse.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHouse.Location = new System.Drawing.Point(895, 203);
            this.btnAddHouse.Name = "btnAddHouse";
            this.btnAddHouse.Size = new System.Drawing.Size(152, 70);
            this.btnAddHouse.TabIndex = 33;
            this.btnAddHouse.Text = "Add New Listing";
            this.btnAddHouse.UseVisualStyleBackColor = false;
            this.btnAddHouse.Click += new System.EventHandler(this.btnAddHouse_Click);
            // 
            // groupBoxDescription
            // 
            this.groupBoxDescription.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxDescription.Controls.Add(this.richTextDescription);
            this.groupBoxDescription.Location = new System.Drawing.Point(36, 641);
            this.groupBoxDescription.Name = "groupBoxDescription";
            this.groupBoxDescription.Size = new System.Drawing.Size(1017, 158);
            this.groupBoxDescription.TabIndex = 46;
            this.groupBoxDescription.TabStop = false;
            this.groupBoxDescription.Text = "Description";
            this.groupBoxDescription.Visible = false;
            // 
            // richTextDescription
            // 
            this.richTextDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.richTextDescription.Location = new System.Drawing.Point(6, 27);
            this.richTextDescription.Name = "richTextDescription";
            this.richTextDescription.ReadOnly = true;
            this.richTextDescription.Size = new System.Drawing.Size(1005, 125);
            this.richTextDescription.TabIndex = 9;
            this.richTextDescription.Text = "";
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxDetails.Controls.Add(this.lblMLSNum);
            this.groupBoxDetails.Controls.Add(this.lblAddress);
            this.groupBoxDetails.Controls.Add(this.lblBath);
            this.groupBoxDetails.Controls.Add(this.lblBed);
            this.groupBoxDetails.Controls.Add(this.lblArea);
            this.groupBoxDetails.Controls.Add(this.lblPrice);
            this.groupBoxDetails.Location = new System.Drawing.Point(43, 537);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(1010, 105);
            this.groupBoxDetails.TabIndex = 45;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Details";
            this.groupBoxDetails.Visible = false;
            // 
            // lblMLSNum
            // 
            this.lblMLSNum.AutoSize = true;
            this.lblMLSNum.BackColor = System.Drawing.Color.Transparent;
            this.lblMLSNum.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMLSNum.Location = new System.Drawing.Point(6, 20);
            this.lblMLSNum.Name = "lblMLSNum";
            this.lblMLSNum.Size = new System.Drawing.Size(116, 45);
            this.lblMLSNum.TabIndex = 40;
            this.lblMLSNum.Text = "MLS #:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(6, 63);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(142, 45);
            this.lblAddress.TabIndex = 39;
            this.lblAddress.Text = "Address:";
            // 
            // lblBath
            // 
            this.lblBath.AutoSize = true;
            this.lblBath.BackColor = System.Drawing.Color.Transparent;
            this.lblBath.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBath.Location = new System.Drawing.Point(844, 20);
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
            this.lblBed.Location = new System.Drawing.Point(685, 20);
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
            this.lblArea.Location = new System.Drawing.Point(462, 20);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(92, 45);
            this.lblArea.TabIndex = 33;
            this.lblArea.Text = "Area:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(198, 20);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(96, 45);
            this.lblPrice.TabIndex = 15;
            this.lblPrice.Text = "Price:";
            // 
            // btnUpdateHouse
            // 
            this.btnUpdateHouse.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnUpdateHouse.FlatAppearance.BorderSize = 3;
            this.btnUpdateHouse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateHouse.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateHouse.Location = new System.Drawing.Point(895, 290);
            this.btnUpdateHouse.Name = "btnUpdateHouse";
            this.btnUpdateHouse.Size = new System.Drawing.Size(152, 70);
            this.btnUpdateHouse.TabIndex = 49;
            this.btnUpdateHouse.Text = "Update Listing";
            this.btnUpdateHouse.UseVisualStyleBackColor = false;
            this.btnUpdateHouse.Visible = false;
            this.btnUpdateHouse.Click += new System.EventHandler(this.btnUpdateHouse_Click);
            // 
            // btnRemoveHouse
            // 
            this.btnRemoveHouse.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnRemoveHouse.FlatAppearance.BorderSize = 3;
            this.btnRemoveHouse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveHouse.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveHouse.Location = new System.Drawing.Point(895, 377);
            this.btnRemoveHouse.Name = "btnRemoveHouse";
            this.btnRemoveHouse.Size = new System.Drawing.Size(152, 70);
            this.btnRemoveHouse.TabIndex = 50;
            this.btnRemoveHouse.Text = "Remove Listing";
            this.btnRemoveHouse.UseVisualStyleBackColor = false;
            this.btnRemoveHouse.Visible = false;
            this.btnRemoveHouse.Click += new System.EventHandler(this.btnRemoveHouse_Click);
            // 
            // btnChangeAgent
            // 
            this.btnChangeAgent.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnChangeAgent.FlatAppearance.BorderSize = 3;
            this.btnChangeAgent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeAgent.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeAgent.Location = new System.Drawing.Point(238, 816);
            this.btnChangeAgent.Name = "btnChangeAgent";
            this.btnChangeAgent.Size = new System.Drawing.Size(190, 41);
            this.btnChangeAgent.TabIndex = 51;
            this.btnChangeAgent.Text = "Change Agent";
            this.btnChangeAgent.UseVisualStyleBackColor = false;
            this.btnChangeAgent.Click += new System.EventHandler(this.btnChangeAgent_Click);
            // 
            // btnClientPortal
            // 
            this.btnClientPortal.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnClientPortal.FlatAppearance.BorderSize = 3;
            this.btnClientPortal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClientPortal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientPortal.Location = new System.Drawing.Point(42, 816);
            this.btnClientPortal.Name = "btnClientPortal";
            this.btnClientPortal.Size = new System.Drawing.Size(190, 41);
            this.btnClientPortal.TabIndex = 52;
            this.btnClientPortal.Text = "Client Portal";
            this.btnClientPortal.UseVisualStyleBackColor = false;
            this.btnClientPortal.Click += new System.EventHandler(this.btnClientPortal_Click);
            // 
            // AgentPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1084, 861);
            this.Controls.Add(this.btnClientPortal);
            this.Controls.Add(this.btnChangeAgent);
            this.Controls.Add(this.btnRemoveHouse);
            this.Controls.Add(this.btnUpdateHouse);
            this.Controls.Add(this.groupBoxDescription);
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.btnAddHouse);
            this.Controls.Add(this.dataGridAgentListings);
            this.Controls.Add(this.lblCurrentUser);
            this.Controls.Add(this.txtCurrentAgentName);
            this.Controls.Add(this.btnUpdateAgent);
            this.Controls.Add(this.lblAgentListings);
            this.Controls.Add(this.lblMLS);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "AgentPortal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agent Portal";
            this.Load += new System.EventHandler(this.AgentPortal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAgentListings)).EndInit();
            this.groupBoxDescription.ResumeLayout(false);
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMLS;
        private System.Windows.Forms.Label lblAgentListings;
        private System.Windows.Forms.Button btnUpdateAgent;
        private System.Windows.Forms.TextBox txtCurrentAgentName;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.DataGridView dataGridAgentListings;
        private System.Windows.Forms.Button btnAddHouse;
        private System.Windows.Forms.GroupBox groupBoxDescription;
        private System.Windows.Forms.RichTextBox richTextDescription;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblBath;
        private System.Windows.Forms.Label lblBed;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblMLSNum;
        private System.Windows.Forms.Button btnUpdateHouse;
        private System.Windows.Forms.Button btnRemoveHouse;
        private System.Windows.Forms.Button btnChangeAgent;
        private System.Windows.Forms.Button btnClientPortal;
    }
}