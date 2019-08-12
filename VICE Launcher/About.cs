using System;
using System.Windows.Forms;

namespace VICE_Launcher
{
    partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void RepoLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Kiddo9000/UnOfficial-VICE-Launcher/");
        }
    }
}
