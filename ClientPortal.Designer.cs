namespace MLSApp
{
    partial class ClientPortal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientPortal));
            this.lblMLS = new System.Windows.Forms.Label();
            this.richTextDescription = new System.Windows.Forms.RichTextBox();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.lblMLSNum = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblBath = new System.Windows.Forms.Label();
            this.lblBed = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.dataGridHouseListings = new System.Windows.Forms.DataGridView();
            this.lblCurrentListings = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.btnFilterSave = new System.Windows.Forms.Button();
            this.btnFilterClear = new System.Windows.Forms.Button();
            this.btnFilterApply = new System.Windows.Forms.Button();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.comboBoxBath = new System.Windows.Forms.ComboBox();
            this.comboBoxBed = new System.Windows.Forms.ComboBox();
            this.comboBoxArea = new System.Windows.Forms.ComboBox();
            this.comboBoxPrice = new System.Windows.Forms.ComboBox();
            this.lblFilterCity = new System.Windows.Forms.Label();
            this.lblFilterBath = new System.Windows.Forms.Label();
            this.lblFilterBed = new System.Windows.Forms.Label();
            this.lblFilterArea = new System.Windows.Forms.Label();
            this.lblFilterPrice = new System.Windows.Forms.Label();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.txtMLS = new System.Windows.Forms.TextBox();
            this.btnSearchMLS = new System.Windows.Forms.Button();
            this.lblSearchMLS = new System.Windows.Forms.Label();
            this.btnShowMap = new System.Windows.Forms.Button();
            this.btnShowAgent = new System.Windows.Forms.Button();
            this.pictureBoxHouse = new System.Windows.Forms.PictureBox();
            this.btnSaveSelected = new System.Windows.Forms.Button();
            this.btnAgentLogin = new System.Windows.Forms.Button();
            this.groupBoxDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHouseListings)).BeginInit();
            this.groupBoxFilter.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHouse)).BeginInit();
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
            // richTextDescription
            // 
            this.richTextDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.richTextDescription.Location = new System.Drawing.Point(599, 205);
            this.richTextDescription.Name = "richTextDescription";
            this.richTextDescription.ReadOnly = true;
            this.richTextDescription.Size = new System.Drawing.Size(473, 285);
            this.richTextDescription.TabIndex = 9;
            this.richTextDescription.Text = "Select a listing to view description and details.";
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxDetails.Controls.Add(this.btnSaveSelected);
            this.groupBoxDetails.Controls.Add(this.lblMLSNum);
            this.groupBoxDetails.Controls.Add(this.lblAddress);
            this.groupBoxDetails.Controls.Add(this.lblBath);
            this.groupBoxDetails.Controls.Add(this.lblBed);
            this.groupBoxDetails.Controls.Add(this.lblArea);
            this.groupBoxDetails.Controls.Add(this.lblPrice);
            this.groupBoxDetails.Location = new System.Drawing.Point(12, 496);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(824, 105);
            this.groupBoxDetails.TabIndex = 54;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Details";
            this.groupBoxDetails.Visible = false;
            // 
            // lblMLSNum
            // 
            this.lblMLSNum.AutoSize = true;
            this.lblMLSNum.BackColor = System.Drawing.Color.Transparent;
            this.lblMLSNum.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMLSNum.Location = new System.Drawing.Point(6, 20);
            this.lblMLSNum.Name = "lblMLSNum";
            this.lblMLSNum.Size = new System.Drawing.Size(101, 38);
            this.lblMLSNum.TabIndex = 40;
            this.lblMLSNum.Text = "MLS #:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(6, 63);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(122, 38);
            this.lblAddress.TabIndex = 39;
            this.lblAddress.Text = "Address:";
            // 
            // lblBath
            // 
            this.lblBath.AutoSize = true;
            this.lblBath.BackColor = System.Drawing.Color.Transparent;
            this.lblBath.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBath.Location = new System.Drawing.Point(629, 20);
            this.lblBath.Name = "lblBath";
            this.lblBath.Size = new System.Drawing.Size(78, 38);
            this.lblBath.TabIndex = 36;
            this.lblBath.Text = "Bath:";
            // 
            // lblBed
            // 
            this.lblBed.AutoSize = true;
            this.lblBed.BackColor = System.Drawing.Color.Transparent;
            this.lblBed.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBed.Location = new System.Drawing.Point(521, 20);
            this.lblBed.Name = "lblBed";
            this.lblBed.Size = new System.Drawing.Size(70, 38);
            this.lblBed.TabIndex = 35;
            this.lblBed.Text = "Bed:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.BackColor = System.Drawing.Color.Transparent;
            this.lblArea.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(356, 20);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(80, 38);
            this.lblArea.TabIndex = 33;
            this.lblArea.Text = "Area:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(138, 20);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(84, 38);
            this.lblPrice.TabIndex = 15;
            this.lblPrice.Text = "Price:";
            // 
            // dataGridHouseListings
            // 
            this.dataGridHouseListings.AllowUserToAddRows = false;
            this.dataGridHouseListings.AllowUserToDeleteRows = false;
            this.dataGridHouseListings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridHouseListings.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridHouseListings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHouseListings.Location = new System.Drawing.Point(12, 205);
            this.dataGridHouseListings.Name = "dataGridHouseListings";
            this.dataGridHouseListings.ReadOnly = true;
            this.dataGridHouseListings.RowHeadersWidth = 15;
            this.dataGridHouseListings.Size = new System.Drawing.Size(581, 285);
            this.dataGridHouseListings.TabIndex = 52;
            this.dataGridHouseListings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridHouseListings_CellContentClick);
            // 
            // lblCurrentListings
            // 
            this.lblCurrentListings.AutoSize = true;
            this.lblCurrentListings.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentListings.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentListings.Location = new System.Drawing.Point(166, 157);
            this.lblCurrentListings.Name = "lblCurrentListings";
            this.lblCurrentListings.Size = new System.Drawing.Size(242, 45);
            this.lblCurrentListings.TabIndex = 51;
            this.lblCurrentListings.Text = "Current Listings";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(754, 157);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(182, 45);
            this.lblDescription.TabIndex = 55;
            this.lblDescription.Text = "Description";
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxFilter.Controls.Add(this.btnFilterSave);
            this.groupBoxFilter.Controls.Add(this.btnFilterClear);
            this.groupBoxFilter.Controls.Add(this.btnFilterApply);
            this.groupBoxFilter.Controls.Add(this.comboBoxCity);
            this.groupBoxFilter.Controls.Add(this.comboBoxBath);
            this.groupBoxFilter.Controls.Add(this.comboBoxBed);
            this.groupBoxFilter.Controls.Add(this.comboBoxArea);
            this.groupBoxFilter.Controls.Add(this.comboBoxPrice);
            this.groupBoxFilter.Controls.Add(this.lblFilterCity);
            this.groupBoxFilter.Controls.Add(this.lblFilterBath);
            this.groupBoxFilter.Controls.Add(this.lblFilterBed);
            this.groupBoxFilter.Controls.Add(this.lblFilterArea);
            this.groupBoxFilter.Controls.Add(this.lblFilterPrice);
            this.groupBoxFilter.Location = new System.Drawing.Point(12, 607);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(441, 252);
            this.groupBoxFilter.TabIndex = 55;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Filter";
            // 
            // btnFilterSave
            // 
            this.btnFilterSave.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnFilterSave.FlatAppearance.BorderSize = 3;
            this.btnFilterSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFilterSave.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterSave.Location = new System.Drawing.Point(310, 160);
            this.btnFilterSave.Name = "btnFilterSave";
            this.btnFilterSave.Size = new System.Drawing.Size(112, 58);
            this.btnFilterSave.TabIndex = 58;
            this.btnFilterSave.Text = "Save List";
            this.btnFilterSave.UseVisualStyleBackColor = false;
            this.btnFilterSave.Visible = false;
            this.btnFilterSave.Click += new System.EventHandler(this.btnFilterSave_Click);
            // 
            // btnFilterClear
            // 
            this.btnFilterClear.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnFilterClear.FlatAppearance.BorderSize = 3;
            this.btnFilterClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFilterClear.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterClear.Location = new System.Drawing.Point(310, 90);
            this.btnFilterClear.Name = "btnFilterClear";
            this.btnFilterClear.Size = new System.Drawing.Size(112, 58);
            this.btnFilterClear.TabIndex = 57;
            this.btnFilterClear.Text = "Clear";
            this.btnFilterClear.UseVisualStyleBackColor = false;
            this.btnFilterClear.Click += new System.EventHandler(this.btnFilterClear_Click);
            // 
            // btnFilterApply
            // 
            this.btnFilterApply.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnFilterApply.FlatAppearance.BorderSize = 3;
            this.btnFilterApply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFilterApply.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterApply.Location = new System.Drawing.Point(310, 20);
            this.btnFilterApply.Name = "btnFilterApply";
            this.btnFilterApply.Size = new System.Drawing.Size(112, 58);
            this.btnFilterApply.TabIndex = 56;
            this.btnFilterApply.Text = "Apply";
            this.btnFilterApply.UseVisualStyleBackColor = false;
            this.btnFilterApply.Click += new System.EventHandler(this.btnFilterApply_Click);
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(90, 205);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(204, 45);
            this.comboBoxCity.TabIndex = 44;
            // 
            // comboBoxBath
            // 
            this.comboBoxBath.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.comboBoxBath.FormattingEnabled = true;
            this.comboBoxBath.Items.AddRange(new object[] {
            "All",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBoxBath.Location = new System.Drawing.Point(90, 160);
            this.comboBoxBath.Name = "comboBoxBath";
            this.comboBoxBath.Size = new System.Drawing.Size(204, 45);
            this.comboBoxBath.TabIndex = 43;
            // 
            // comboBoxBed
            // 
            this.comboBoxBed.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.comboBoxBed.FormattingEnabled = true;
            this.comboBoxBed.Items.AddRange(new object[] {
            "All",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBoxBed.Location = new System.Drawing.Point(90, 115);
            this.comboBoxBed.Name = "comboBoxBed";
            this.comboBoxBed.Size = new System.Drawing.Size(204, 45);
            this.comboBoxBed.TabIndex = 42;
            // 
            // comboBoxArea
            // 
            this.comboBoxArea.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.comboBoxArea.FormattingEnabled = true;
            this.comboBoxArea.Items.AddRange(new object[] {
            "All",
            "< 1500",
            "1500 - 2000",
            "2000 - 2500",
            "2500 - 3000",
            "3000 - 3250",
            "> 3250"});
            this.comboBoxArea.Location = new System.Drawing.Point(90, 70);
            this.comboBoxArea.Name = "comboBoxArea";
            this.comboBoxArea.Size = new System.Drawing.Size(204, 45);
            this.comboBoxArea.TabIndex = 41;
            // 
            // comboBoxPrice
            // 
            this.comboBoxPrice.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.comboBoxPrice.FormattingEnabled = true;
            this.comboBoxPrice.Items.AddRange(new object[] {
            "All",
            "< $350K",
            "$350K - $400K",
            "$400K - $450K",
            "$450K - $500K",
            "$500K - $550K",
            "$550K - $600K",
            "> $600K"});
            this.comboBoxPrice.Location = new System.Drawing.Point(90, 25);
            this.comboBoxPrice.Name = "comboBoxPrice";
            this.comboBoxPrice.Size = new System.Drawing.Size(204, 45);
            this.comboBoxPrice.TabIndex = 40;
            // 
            // lblFilterCity
            // 
            this.lblFilterCity.AutoSize = true;
            this.lblFilterCity.BackColor = System.Drawing.Color.Transparent;
            this.lblFilterCity.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterCity.Location = new System.Drawing.Point(6, 205);
            this.lblFilterCity.Name = "lblFilterCity";
            this.lblFilterCity.Size = new System.Drawing.Size(72, 40);
            this.lblFilterCity.TabIndex = 39;
            this.lblFilterCity.Text = "City:";
            // 
            // lblFilterBath
            // 
            this.lblFilterBath.AutoSize = true;
            this.lblFilterBath.BackColor = System.Drawing.Color.Transparent;
            this.lblFilterBath.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterBath.Location = new System.Drawing.Point(6, 160);
            this.lblFilterBath.Name = "lblFilterBath";
            this.lblFilterBath.Size = new System.Drawing.Size(81, 40);
            this.lblFilterBath.TabIndex = 36;
            this.lblFilterBath.Text = "Bath:";
            // 
            // lblFilterBed
            // 
            this.lblFilterBed.AutoSize = true;
            this.lblFilterBed.BackColor = System.Drawing.Color.Transparent;
            this.lblFilterBed.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterBed.Location = new System.Drawing.Point(6, 115);
            this.lblFilterBed.Name = "lblFilterBed";
            this.lblFilterBed.Size = new System.Drawing.Size(72, 40);
            this.lblFilterBed.TabIndex = 35;
            this.lblFilterBed.Text = "Bed:";
            // 
            // lblFilterArea
            // 
            this.lblFilterArea.AutoSize = true;
            this.lblFilterArea.BackColor = System.Drawing.Color.Transparent;
            this.lblFilterArea.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterArea.Location = new System.Drawing.Point(6, 70);
            this.lblFilterArea.Name = "lblFilterArea";
            this.lblFilterArea.Size = new System.Drawing.Size(82, 40);
            this.lblFilterArea.TabIndex = 33;
            this.lblFilterArea.Text = "Area:";
            // 
            // lblFilterPrice
            // 
            this.lblFilterPrice.AutoSize = true;
            this.lblFilterPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblFilterPrice.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterPrice.Location = new System.Drawing.Point(6, 27);
            this.lblFilterPrice.Name = "lblFilterPrice";
            this.lblFilterPrice.Size = new System.Drawing.Size(84, 40);
            this.lblFilterPrice.TabIndex = 15;
            this.lblFilterPrice.Text = "Price:";
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxSearch.Controls.Add(this.txtMLS);
            this.groupBoxSearch.Controls.Add(this.btnSearchMLS);
            this.groupBoxSearch.Controls.Add(this.lblSearchMLS);
            this.groupBoxSearch.Location = new System.Drawing.Point(459, 607);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(134, 177);
            this.groupBoxSearch.TabIndex = 59;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search";
            // 
            // txtMLS
            // 
            this.txtMLS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.txtMLS.Location = new System.Drawing.Point(11, 59);
            this.txtMLS.Name = "txtMLS";
            this.txtMLS.Size = new System.Drawing.Size(109, 36);
            this.txtMLS.TabIndex = 60;
            this.txtMLS.TextChanged += new System.EventHandler(this.txtMLS_TextChanged);
            // 
            // btnSearchMLS
            // 
            this.btnSearchMLS.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSearchMLS.FlatAppearance.BorderSize = 3;
            this.btnSearchMLS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchMLS.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMLS.Location = new System.Drawing.Point(8, 109);
            this.btnSearchMLS.Name = "btnSearchMLS";
            this.btnSearchMLS.Size = new System.Drawing.Size(112, 58);
            this.btnSearchMLS.TabIndex = 60;
            this.btnSearchMLS.Text = "Search";
            this.btnSearchMLS.UseVisualStyleBackColor = false;
            this.btnSearchMLS.Click += new System.EventHandler(this.btnSearchMLS_Click);
            // 
            // lblSearchMLS
            // 
            this.lblSearchMLS.AutoSize = true;
            this.lblSearchMLS.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchMLS.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchMLS.Location = new System.Drawing.Point(6, 31);
            this.lblSearchMLS.Name = "lblSearchMLS";
            this.lblSearchMLS.Size = new System.Drawing.Size(117, 25);
            this.lblSearchMLS.TabIndex = 15;
            this.lblSearchMLS.Text = "Enter MLS #:";
            // 
            // btnShowMap
            // 
            this.btnShowMap.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnShowMap.FlatAppearance.BorderSize = 3;
            this.btnShowMap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowMap.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowMap.Location = new System.Drawing.Point(842, 509);
            this.btnShowMap.Name = "btnShowMap";
            this.btnShowMap.Size = new System.Drawing.Size(112, 92);
            this.btnShowMap.TabIndex = 61;
            this.btnShowMap.Text = "View On Map";
            this.btnShowMap.UseVisualStyleBackColor = false;
            this.btnShowMap.Visible = false;
            this.btnShowMap.Click += new System.EventHandler(this.btnShowMap_Click);
            // 
            // btnShowAgent
            // 
            this.btnShowAgent.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnShowAgent.FlatAppearance.BorderSize = 3;
            this.btnShowAgent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowAgent.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAgent.Location = new System.Drawing.Point(960, 509);
            this.btnShowAgent.Name = "btnShowAgent";
            this.btnShowAgent.Size = new System.Drawing.Size(112, 92);
            this.btnShowAgent.TabIndex = 62;
            this.btnShowAgent.Text = "View Agent";
            this.btnShowAgent.UseVisualStyleBackColor = false;
            this.btnShowAgent.Visible = false;
            this.btnShowAgent.Click += new System.EventHandler(this.btnShowAgent_Click);
            // 
            // pictureBoxHouse
            // 
            this.pictureBoxHouse.Location = new System.Drawing.Point(599, 608);
            this.pictureBoxHouse.Name = "pictureBoxHouse";
            this.pictureBoxHouse.Size = new System.Drawing.Size(473, 241);
            this.pictureBoxHouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHouse.TabIndex = 63;
            this.pictureBoxHouse.TabStop = false;
            // 
            // btnSaveSelected
            // 
            this.btnSaveSelected.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSaveSelected.FlatAppearance.BorderSize = 3;
            this.btnSaveSelected.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveSelected.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSelected.Location = new System.Drawing.Point(743, 27);
            this.btnSaveSelected.Name = "btnSaveSelected";
            this.btnSaveSelected.Size = new System.Drawing.Size(75, 64);
            this.btnSaveSelected.TabIndex = 61;
            this.btnSaveSelected.Text = "Save";
            this.btnSaveSelected.UseVisualStyleBackColor = false;
            this.btnSaveSelected.Click += new System.EventHandler(this.btnSaveSelected_Click);
            // 
            // btnAgentLogin
            // 
            this.btnAgentLogin.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAgentLogin.FlatAppearance.BorderSize = 3;
            this.btnAgentLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgentLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgentLogin.Location = new System.Drawing.Point(467, 812);
            this.btnAgentLogin.Name = "btnAgentLogin";
            this.btnAgentLogin.Size = new System.Drawing.Size(112, 40);
            this.btnAgentLogin.TabIndex = 61;
            this.btnAgentLogin.Text = "Agent Login";
            this.btnAgentLogin.UseVisualStyleBackColor = false;
            this.btnAgentLogin.Click += new System.EventHandler(this.btnAgentLogin_Click);
            // 
            // ClientPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1084, 861);
            this.Controls.Add(this.btnAgentLogin);
            this.Controls.Add(this.pictureBoxHouse);
            this.Controls.Add(this.btnShowAgent);
            this.Controls.Add(this.btnShowMap);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.groupBoxFilter);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.richTextDescription);
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.dataGridHouseListings);
            this.Controls.Add(this.lblCurrentListings);
            this.Controls.Add(this.lblMLS);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "ClientPortal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client Portal";
            this.Load += new System.EventHandler(this.ClientPortal_Load);
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHouseListings)).EndInit();
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMLS;
        private System.Windows.Forms.RichTextBox richTextDescription;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.Label lblMLSNum;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblBath;
        private System.Windows.Forms.Label lblBed;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.DataGridView dataGridHouseListings;
        private System.Windows.Forms.Label lblCurrentListings;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.Label lblFilterCity;
        private System.Windows.Forms.Label lblFilterBath;
        private System.Windows.Forms.Label lblFilterBed;
        private System.Windows.Forms.Label lblFilterArea;
        private System.Windows.Forms.Label lblFilterPrice;
        private System.Windows.Forms.ComboBox comboBoxPrice;
        private System.Windows.Forms.Button btnFilterSave;
        private System.Windows.Forms.Button btnFilterClear;
        private System.Windows.Forms.Button btnFilterApply;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.ComboBox comboBoxBath;
        private System.Windows.Forms.ComboBox comboBoxBed;
        private System.Windows.Forms.ComboBox comboBoxArea;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Label lblSearchMLS;
        private System.Windows.Forms.TextBox txtMLS;
        private System.Windows.Forms.Button btnSearchMLS;
        private System.Windows.Forms.Button btnShowMap;
        private System.Windows.Forms.Button btnShowAgent;
        private System.Windows.Forms.PictureBox pictureBoxHouse;
        private System.Windows.Forms.Button btnSaveSelected;
        private System.Windows.Forms.Button btnAgentLogin;
    }
}