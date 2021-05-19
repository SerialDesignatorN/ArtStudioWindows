using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mainpaint
{
    public partial class PhoneConnect : Form
    {
        public PhoneConnect()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://apkpure.com/art-studio-pro/com.artstd.pro");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
