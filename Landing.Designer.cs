namespace MLSApp
{
    partial class Landing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Landing));
            this.lblMLS = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnClientPortal = new System.Windows.Forms.Button();
            this.btnAgentPortal = new System.Windows.Forms.Button();
            this.lblDisclaimer = new System.Windows.Forms.Label();
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
            this.lblMLS.TabIndex = 0;
            this.lblMLS.Text = "Make-believe Listing System";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(195, 218);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(708, 90);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome to the Make-believe Listing System. \r\nPlease select an option below:";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClientPortal
            // 
            this.btnClientPortal.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnClientPortal.FlatAppearance.BorderSize = 3;
            this.btnClientPortal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClientPortal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientPortal.Location = new System.Drawing.Point(253, 350);
            this.btnClientPortal.Name = "btnClientPortal";
            this.btnClientPortal.Size = new System.Drawing.Size(176, 133);
            this.btnClientPortal.TabIndex = 2;
            this.btnClientPortal.Text = "Proceed to Client Portal";
            this.btnClientPortal.UseVisualStyleBackColor = false;
            this.btnClientPortal.Click += new System.EventHandler(this.btnClientPortal_Click);
            // 
            // btnAgentPortal
            // 
            this.btnAgentPortal.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAgentPortal.FlatAppearance.BorderSize = 3;
            this.btnAgentPortal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgentPortal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgentPortal.Location = new System.Drawing.Point(702, 350);
            this.btnAgentPortal.Name = "btnAgentPortal";
            this.btnAgentPortal.Size = new System.Drawing.Size(176, 133);
            this.btnAgentPortal.TabIndex = 3;
            this.btnAgentPortal.Text = "Proceed to Agent Portal";
            this.btnAgentPortal.UseVisualStyleBackColor = false;
            this.btnAgentPortal.Click += new System.EventHandler(this.btnAgentPortal_Click);
            // 
            // lblDisclaimer
            // 
            this.lblDisclaimer.AutoSize = true;
            this.lblDisclaimer.BackColor = System.Drawing.Color.Transparent;
            this.lblDisclaimer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisclaimer.Location = new System.Drawing.Point(146, 757);
            this.lblDisclaimer.Name = "lblDisclaimer";
            this.lblDisclaimer.Size = new System.Drawing.Size(821, 95);
            this.lblDisclaimer.TabIndex = 4;
            this.lblDisclaimer.Text = resources.GetString("lblDisclaimer.Text");
            // 
            // Landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1084, 861);
            this.Controls.Add(this.lblDisclaimer);
            this.Controls.Add(this.btnAgentPortal);
            this.Controls.Add(this.btnClientPortal);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblMLS);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Landing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Landing";
            this.Load += new System.EventHandler(this.Landing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMLS;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnClientPortal;
        private System.Windows.Forms.Button btnAgentPortal;
        private System.Windows.Forms.Label lblDisclaimer;
    }
}

