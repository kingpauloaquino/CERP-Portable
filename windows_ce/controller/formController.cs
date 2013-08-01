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

namespace windows_ce
{
    public class MsgWindow : MessageWindow
    {
        public const int WM_APP = 0x8000;
        public const int WM_USER = 0x0400;      //20090601 sdk++
        public const int WM_COMMAND = 0x0111;   //20090601 sdk++

        IntPtr IDM_RESUME = new IntPtr(WM_USER + 110);   //20090601 sdk++
        IntPtr IDM_SUSPEND = new IntPtr(WM_USER + 111);  //20090601 sdk++

        // Create an instance of the form.
        private frmScanner msgform;

        // Save a reference to the form so it can
        // be notified when messages are received.
        public MsgWindow(frmScanner msgform)
        {
            this.msgform = msgform;
        }

        // Override the default WndProc behavior to examine messages.
        protected override void WndProc(ref Message msg)
        {
            switch (msg.Msg)
            {
                case WM_APP:
                    this.msgform.SendMSG((byte)msg.WParam);
                    break;
                case WM_COMMAND:
                    break;
            }
            // Call the base WndProc method
            // to process any messages not handled.
            base.WndProc(ref msg);
        }
    }
}
