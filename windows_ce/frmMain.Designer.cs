namespace windows_ce
{
    partial class frmMain
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnDeliveries = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 28);
            this.label5.Text = "Home";
            // 
            // btnDetails
            // 
            this.btnDetails.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular);
            this.btnDetails.Location = new System.Drawing.Point(24, 46);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(190, 45);
            this.btnDetails.TabIndex = 8;
            this.btnDetails.Text = "Details";
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnDeliveries
            // 
            this.btnDeliveries.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular);
            this.btnDeliveries.Location = new System.Drawing.Point(24, 97);
            this.btnDeliveries.Name = "btnDeliveries";
            this.btnDeliveries.Size = new System.Drawing.Size(190, 45);
            this.btnDeliveries.TabIndex = 9;
            this.btnDeliveries.Text = "Deliveries";
            this.btnDeliveries.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular);
            this.button3.Location = new System.Drawing.Point(24, 148);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 45);
            this.button3.TabIndex = 10;
            this.button3.Text = "Settings";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular);
            this.button4.Location = new System.Drawing.Point(24, 199);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(190, 45);
            this.button4.TabIndex = 11;
            this.button4.Text = "Logout";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(238, 269);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnDeliveries);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.label5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Portable";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnDeliveries;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}