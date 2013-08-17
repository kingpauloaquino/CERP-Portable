using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.WindowsCE.Forms;
using BCD.net;

namespace windows_ce
{
    public partial class frmScanner : Form
    {
        #region
        // Create an instance of MsgWindow, a derived MessageWindow class.
        MsgWindow MsgWin;

        const byte SCAN_MESSAGE = 0x1A;
        const byte SCAN_KEYDOWN = 0x1B;
        const byte SCAN_KEYUP = 0x1C;
        const byte SCAN_GOTBARCODE = 0x1D;

        public BCD.net.CBScanner BScanner = new BCD.net.CBScanner();

        public bool bContMode;   //K04232009++
        private long buzzer_pb_ms;

        private void InitPara()
        {
            //this.BScanner.AppControlBarcode(0x3);
            //this.BScanner.StartBarcodeScan();
            this.BScanner.InitBarcode();
        }

        private void DeInitPara()
        {
            this.BScanner.CloseBarcode();
            //this.BScanner.AppControlBarcode(0x1);
            //this.BScanner.StopBarcodeScan();
        }

        private void scantest_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyValue == SCAN_MESSAGE)
            //{
            //    this.textBox1.Text = null;
            //    this.textBox2.Text = null;
            //    this.textBox1.Focus();
            //    this.BScanner.StartBarcodeScan();
            //}
        }

        private void scantest_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyValue == SCAN_MESSAGE)
            //{
            //    this.BScanner.StopBarcodeScan();
            //    this.textBox1.Text = this.BScanner.GetPrefix() + this.BScanner.GetBarcodeData() + this.BScanner.GetSuffix();
            //    this.textBox2.Text = this.BScanner.GetBarcodeType();
            //}
        }
        public void SendMSG(byte x)
        {
            switch (x)
            {
                case SCAN_KEYDOWN:
                    //this.textBox1.Text = null;
                    //this.textBox1.Focus();
                    //this.BScanner.StartBarcodeScan();
                    break;

                case SCAN_KEYUP:
                    //this.BScanner.StopBarcodeScan();
                    break;

                case SCAN_GOTBARCODE:
                    //this.textBox1.Text = this.BScanner.GetPrefix() + this.BScanner.GetBarcodeData() + this.BScanner.GetSuffix();
                    string bar_code = this.BScanner.GetBarcodeData();
                    this.textBox1.Text = bar_code;
                    config.Barcode = bar_code;
                    //K04232009++ start
                    /*
                    if (bContMode)
                    {
                        this.timer1.Enabled = true;
                        this.BScanner.StartBarcodeScan();
                    }
                    */
                    //K04232009++ end
                    break;
            }
        }

        #endregion

        string formName = string.Empty;
        private string FormName { get; set; }

        public frmScanner(string name)
        {
            InitializeComponent();
            this.MsgWin = new MsgWindow(this);
            FormName = name;
        }

        private void frmScanner_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 70);
            InitPara();
            bContMode = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            config.Barcode = textBox1.Text.Trim();
            switch(FormName)
            {
                case "Stock":
                    frmGet_Stock get_stock = new frmGet_Stock();
                    get_stock.Show();
                    break;
                case "Deliveries":
                    frmGet_Deliveries get_Deliveries = new frmGet_Deliveries();
                    get_Deliveries.Show();
                    break;
                case "MateialIssuance":
                    frmGetMaterialIssuance2 get_MaterialIssuance = new frmGetMaterialIssuance2();
                    get_MaterialIssuance.Show();
                    break;
            }

            this.Dispose();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}