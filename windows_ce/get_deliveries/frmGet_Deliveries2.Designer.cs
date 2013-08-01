namespace windows_ce
{
    partial class frmGet_Deliveries2
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
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblDevDate = new System.Windows.Forms.Label();
            this.lblPo = new System.Windows.Forms.Label();
            this.btnReceive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btnClose.Location = new System.Drawing.Point(3, 233);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 33);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.dataGrid1.Location = new System.Drawing.Point(1, 72);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(235, 155);
            this.dataGrid1.TabIndex = 19;
            // 
            // lblSupplier
            // 
            this.lblSupplier.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.lblSupplier.Location = new System.Drawing.Point(3, 47);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(232, 20);
            this.lblSupplier.Text = "label1";
            // 
            // lblDevDate
            // 
            this.lblDevDate.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.lblDevDate.Location = new System.Drawing.Point(3, 27);
            this.lblDevDate.Name = "lblDevDate";
            this.lblDevDate.Size = new System.Drawing.Size(232, 20);
            this.lblDevDate.Text = "label1";
            // 
            // lblPo
            // 
            this.lblPo.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.lblPo.Location = new System.Drawing.Point(3, 7);
            this.lblPo.Name = "lblPo";
            this.lblPo.Size = new System.Drawing.Size(232, 20);
            this.lblPo.Text = "label1";
            // 
            // btnReceive
            // 
            this.btnReceive.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btnReceive.Location = new System.Drawing.Point(143, 233);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(92, 33);
            this.btnReceive.TabIndex = 23;
            this.btnReceive.Text = "Receive";
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // frmGet_Deliveries2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(238, 269);
            this.ControlBox = false;
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.lblDevDate);
            this.Controls.Add(this.lblPo);
            this.Controls.Add(this.btnClose);
            this.Name = "frmGet_Deliveries2";
            this.Text = "List Deliveries";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblDevDate;
        private System.Windows.Forms.Label lblPo;
        private System.Windows.Forms.Button btnReceive;

    }
}