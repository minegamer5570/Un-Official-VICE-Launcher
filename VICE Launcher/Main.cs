// VICE Launcher
// Created by Liam Hogan
// Version 2.0 Open-Source

using System;
using System.IO;
using System.Windows.Forms;

namespace VICE_Launcher
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
			if (File.Exists("xpet.exe")) {
    			
			}
			else {
				string message = "Warning! Your Vice installation could not be detected! Make sure this executable is in the same folder as Vice. If it is, then your copy of Vice may be damaged. \n\n Error: MEPE1";
                string caption = "Error!";
				MessageBoxButtons buttons = MessageBoxButtons.OK;
				DialogResult result;
				result = MessageBox.Show(message, caption, buttons);
				Environment.Exit(1);
			}
			if (File.Exists("xvic.exe")) {
    			
			}
			else {
				string message = "Warning! Your Vice installation could not be detected! Make sure this executable is in the same folder as Vice. If it is, then your copy of Vice may be damaged. \n\n Error: MEVI1";
                string caption = "Error!";
				MessageBoxButtons buttons = MessageBoxButtons.OK;
				DialogResult result;
				result = MessageBox.Show(message, caption, buttons);
				Environment.Exit(1);
			}
			InitializeComponent();
			if (File.Exists("x64.exe")) {
    			
			}
			else {
				string message = "Warning! Your Vice installation could not be detected! Make sure this executable is in the same folder as Vice. If it is, then your copy of Vice may be damaged. \n\n Error: MESF1";
                string caption = "Error!";
				MessageBoxButtons buttons = MessageBoxButtons.OK;
				DialogResult result;
				result = MessageBox.Show(message, caption, buttons);
				Environment.Exit(1);
			}
			InitializeComponent();
			if (File.Exists("x64dtv.exe")) {
    			
			}
			else {
				string message = "Warning! Your Vice installation could not be detected! Make sure this executable is in the same folder as Vice. If it is, then your copy of Vice may be damaged. \n\n Error: MESF2";
                string caption = "Error!";
				MessageBoxButtons buttons = MessageBoxButtons.OK;
				DialogResult result;
				result = MessageBox.Show(message, caption, buttons);
				Environment.Exit(1);
			}
			InitializeComponent();
			if (File.Exists("x64sc.exe")) {
    			
			}
			else {
				string message = "Warning! Your Vice installation could not be detected! Make sure this executable is in the same folder as Vice. If it is, then your copy of Vice may be damaged. \n\n Error: MESF3";
                string caption = "Error!";
				MessageBoxButtons buttons = MessageBoxButtons.OK;
				DialogResult result;
				result = MessageBox.Show(message, caption, buttons);
				Environment.Exit(1);
			}
			if (File.Exists("x128.exe")) {
    			
			}
			else {
				string message = "Warning! Your Vice installation could not be detected! Make sure this executable is in the same folder as Vice. If it is, then your copy of Vice may be damaged. \n\n Error: MEOT1";
                string caption = "Error!";
				MessageBoxButtons buttons = MessageBoxButtons.OK;
				DialogResult result;
				result = MessageBox.Show(message, caption, buttons);
				Environment.Exit(1);
			}
			if (File.Exists("xplus4.exe")) {
    			
			}
			else {
				string message = "Warning! Your Vice installation could not be detected! Make sure this executable is in the same folder as Vice. If it is, then your copy of Vice may be damaged. \n\n Error: MEPL1";
                string caption = "Error!";
				MessageBoxButtons buttons = MessageBoxButtons.OK;
				DialogResult result;
				result = MessageBox.Show(message, caption, buttons);
				Environment.Exit(1);
			}
			if (File.Exists("xscpu64.exe")) {
    			
			}
			else {
				string message = "Warning! Your Vice installation could not be detected! Make sure this executable is in the same folder as Vice. If it is, then your copy of Vice may be damaged. \n\n Error: MESC1";
                string caption = "Error!";
				MessageBoxButtons buttons = MessageBoxButtons.OK;
				DialogResult result;
				result = MessageBox.Show(message, caption, buttons);
				Environment.Exit(1);
			}
			if (File.Exists("xcbm2.exe")) {
    			
			}
			else {
				string message = "Warning! Your Vice installation could not be detected! Make sure this executable is in the same folder as Vice. If it is, then your copy of Vice may be damaged. \n\n Error: MECB1";
                string caption = "Error!";
				MessageBoxButtons buttons = MessageBoxButtons.OK;
				DialogResult result;
				result = MessageBox.Show(message, caption, buttons);
				Environment.Exit(1);
			}
			if (File.Exists("xcbm5x0.exe")) {
    			
			}
			else {
				string message = "Warning! Your Vice installation could not be detected! Make sure this executable is in the same folder as Vice. If it is, then your copy of Vice may be damaged. \n\n Error: MECB2";
                string caption = "Error!";
				MessageBoxButtons buttons = MessageBoxButtons.OK;
				DialogResult result;
				result = MessageBox.Show(message, caption, buttons);
				Environment.Exit(1);
			}
			if (File.Exists("vsid.exe")) {
    			
			}
			else {
				string message = "Warning! Your Vice installation could not be detected! Make sure this executable is in the same folder as Vice. If it is, then your copy of Vice may be damaged. \n\n Error: MESI1";
                string caption = "Error!";
				MessageBoxButtons buttons = MessageBoxButtons.OK;
				DialogResult result;
				result = MessageBox.Show(message, caption, buttons);
				Environment.Exit(1);
			}
        }

        private void AboutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            About aboutform = new About();
            aboutform.Show();
        }

        private void LaunchPET_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("xpet.exe");
        }

        private void LaunchVIC_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("xvic.exe");
        }

        private void LaunchSF_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("x64.exe");
        }

        private void LaunchSFDTV_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("x64dtv.exe");
        }

        private void LaunchSFSC_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("x64sc.exe");
        }

        private void LaunchOTE_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("x128.exe");
        }

        private void LaunchPLUS_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("xplus4.exe");
        }

        private void LaunchSCPU_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("xscpu64.exe");
        }

        private void LaunchCBM_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("xcbm2.exe");
        }

        private void LaunchCBMFXZ_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("xcbm5x0.exe");
        }

        private void LaunchSID_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("vsid.exe");
        }

        private void RepoLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Kiddo9000/UnOfficial-VICE-Launcher/");
        }

        private void LaunchPETCAT_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("petcat.exe");
        }

        private void LaunchCDRIVE_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("c1541.exe");
        }
    }
}