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

			if (!File.Exists("xpet.exe")) {
                LaunchPET.Enabled = false;
                ModeWarn.Visible = true;
			}

			if (!File.Exists("xvic.exe")) {
                LaunchVIC.Enabled = false;
                ModeWarn.Visible = true;
            }

			if (!File.Exists("x64.exe")) {
                LaunchSF.Enabled = false;
                ModeWarn.Visible = true;
            }

			if (!File.Exists("x64dtv.exe")) {
                LaunchSFDTV.Enabled = false;
                ModeWarn.Visible = true;
            }
			
			if (!File.Exists("x64sc.exe")) {
                LaunchSFSC.Enabled = false;
                ModeWarn.Visible = true;
            }
			
			if (!File.Exists("x128.exe")) {
                LaunchOTE.Enabled = false;
                ModeWarn.Visible = true;
            }
			
			if (!File.Exists("xplus4.exe")) {
                LaunchPLUS.Enabled = false;
                ModeWarn.Visible = true;
            }
			
			if (!File.Exists("xscpu64.exe")) {
                LaunchSCPU.Enabled = false;
                ModeWarn.Visible = true;
            }
			
			if (!File.Exists("xcbm2.exe")) {
                LaunchCBM.Enabled = false;
                ModeWarn.Visible = true;
            }
			
			if (!File.Exists("xcbm5x0.exe")) {
                LaunchCBMFXZ.Enabled = false;
                ModeWarn.Visible = true;
            }
			
			if (!File.Exists("vsid.exe")) {
                LaunchSID.Enabled = false;
                ModeWarn.Visible = true;
            }

            if (!File.Exists("petcat.exe"))
            {
                LaunchPETCAT.Enabled = false;
                ModeWarn.Visible = true;
            }

            if (!File.Exists("c1541.exe"))
            {
                LaunchCDRIVE.Enabled = false;
                ModeWarn.Visible = true;
            }
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