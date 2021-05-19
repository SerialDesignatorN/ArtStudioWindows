using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mainpaint.Other
{
    public partial class infoForm : Form
    {
        public infoForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/kaitoujokercodes/ArtStudioProSuite");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Updater updt = new Updater();
            updt.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://paypal.me/ZIsnomo");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://osu.ppy.sh/oauth/authorize?client_id=4306&redirect_uri=https://zeanfender119.wixsite.com/artstudio/api-callback-osulogin&response_type=code&state=");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:zeanfender11@gmail.com");
        }
    }
}
