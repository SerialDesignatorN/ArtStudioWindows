using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Mainpaint
{
    public partial class Updater : Form
    {
        public Updater()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label2.Text = "Checking for updates... in DiscordRPC.dll";
            label2.Text = "Checking for updates... fetching remote from server";
            label2.Text = "Checking for updates... fetching remote from wix.com";
            label2.Text = "Checking for updates... fetching remote from github.com";
            label2.Text = "Checking for updates... Visiting repository ArtStudioProSuite";
            label2.Text = "Checking for updates... Checking new commits";
            label2.Text = "Checking for updates... Checking code changes (0%)";
            label2.Text = "Checking for updates... Checking code changes (25%)";
            label2.Text = "Checking for updates... Checking code changes (50%)";
            label2.Text = "Checking for updates... Checking code changes (62%)";
            label2.Text = "Checking for updates... Checking code changes (78%)";
            label2.Text = "Checking for updates... Checking code changes (85%)";
            label2.Text = "Checking for updates... Checking code changes (100%)";
            label2.Text = "Checking for updates... Finishing up...";
            label2.Text = "A new update is available! Click here to start update!";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            listBox1.Visible = true;
            label2.Visible = false;
            progressBar1.Value = 0;
            listBox1.Items.Add("DOWNLOAD - Form1.cs");
            progressBar1.Value = 4;
            progressBar1.Value = 8;
            progressBar1.Value = 17;
            listBox1.Items.Add("DOWNLOAD - Form1. Designer.cs");
            progressBar1.Value = 19;
            Thread.Sleep(4500);
            listBox1.Items.Add("DOWNLOAD - EffectWindows.nupkg");
            progressBar1.Value = 25;
            progressBar1.Value = 37;
            progressBar1.Value = 45;
            Thread.Sleep(7000);
            listBox1.Items.Add("DOWNLOAD - MiscellaniousForms.nupkg");
            progressBar1.Value = 56;
            Thread.Sleep(3500);
            progressBar1.Value = 64;
            progressBar1.Value = 69;
            listBox1.Items.Add("DOWNLOAD - Resources.zip");
            progressBar1.Value = 78;
            Thread.Sleep(4200);
            progressBar1.Value = 82;
            Thread.Sleep(3400);
            progressBar1.Value = 96;
            progressBar1.Value = 100;
            Thread.Sleep(4200);
            progressBar1.Value = 0;
            listBox1.Items.Add("INSTALL - Form1.cs");
            progressBar1.Value = 4;
            progressBar1.Value = 8;
            progressBar1.Value = 17;
            listBox1.Items.Add("INSTALL - Form1. Designer.cs");
            progressBar1.Value = 19;
            Thread.Sleep(4500);
            listBox1.Items.Add("INSTALL - EffectWindows.nupkg");
            progressBar1.Value = 25;
            progressBar1.Value = 37;
            progressBar1.Value = 45;
            Thread.Sleep(7000);
            listBox1.Items.Add("INSTALL - MiscellaniousForms.nupkg");
            progressBar1.Value = 56;
            Thread.Sleep(3500);
            progressBar1.Value = 64;
            progressBar1.Value = 69;
            listBox1.Items.Add("INSTALL - Resources.zip");
            progressBar1.Value = 78;
            Thread.Sleep(4200);
            progressBar1.Value = 82;
            Thread.Sleep(3400);
            progressBar1.Value = 96;
            progressBar1.Value = 100;
            label2.Visible = true;
            label2.Text = "Update done! :)";
        }
    }
}
