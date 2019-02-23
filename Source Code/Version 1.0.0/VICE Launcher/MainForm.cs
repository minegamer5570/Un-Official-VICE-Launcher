// VICE Launcher
// NOT OFFICIAL
// Created by Liam Hogan
// Version 1.0 Open-Source

using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace VICE_Launcher
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			if (File.Exists("xpet.exe")) {
    			
			}
			else {
				string message = "Couldn't find the Commodore PET executable. Make sure the launcher executable is in the same directory as your VICE 3.1 installation.";
                string caption = "Error!";
				MessageBoxButtons buttons = MessageBoxButtons.OK;
				DialogResult result;
				result = MessageBox.Show(message, caption, buttons);
				Environment.Exit(1);
			}
			if (File.Exists("xvic.exe")) {
    			
			}
			else {
				string message = "Couldn't find the Commodore VIC executable. Make sure the launcher executable is in the same directory as your VICE 3.1 installation.";
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
				string message = "Couldn't find the Commodore 64 executable. Make sure the launcher executable is in the same directory as your VICE 3.1 installation.";
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
				string message = "Couldn't find the Commodore 64 DTV executable. Make sure the launcher executable is in the same directory as your VICE 3.1 installation.";
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
				string message = "Couldn't find the Commodore 64 SC executable. Make sure the launcher executable is in the same directory as your VICE 3.1 installation.";
                string caption = "Error!";
				MessageBoxButtons buttons = MessageBoxButtons.OK;
				DialogResult result;
				result = MessageBox.Show(message, caption, buttons);
				Environment.Exit(1);
			}
			if (File.Exists("x128.exe")) {
    			
			}
			else {
				string message = "Couldn't find the Commodore 128 executable. Make sure the launcher executable is in the same directory as your VICE 3.1 installation.";
                string caption = "Error!";
				MessageBoxButtons buttons = MessageBoxButtons.OK;
				DialogResult result;
				result = MessageBox.Show(message, caption, buttons);
				Environment.Exit(1);
			}
			if (File.Exists("xplus4.exe")) {
    			
			}
			else {
				string message = "Couldn't find the Commodore Plus4 executable. Make sure the launcher executable is in the same directory as your VICE 3.1 installation.";
                string caption = "Error!";
				MessageBoxButtons buttons = MessageBoxButtons.OK;
				DialogResult result;
				result = MessageBox.Show(message, caption, buttons);
				Environment.Exit(1);
			}
			if (File.Exists("xscpu64.exe")) {
    			
			}
			else {
				string message = "Couldn't find the Commodore SCPU 64 executable. Make sure the launcher executable is in the same directory as your VICE 3.1 installation.";
                string caption = "Error!";
				MessageBoxButtons buttons = MessageBoxButtons.OK;
				DialogResult result;
				result = MessageBox.Show(message, caption, buttons);
				Environment.Exit(1);
			}
			if (File.Exists("xcbm2.exe")) {
    			
			}
			else {
				string message = "Couldn't find the CBM II executable. Make sure the launcher executable is in the same directory as your VICE 3.1 installation.";
                string caption = "Error!";
				MessageBoxButtons buttons = MessageBoxButtons.OK;
				DialogResult result;
				result = MessageBox.Show(message, caption, buttons);
				Environment.Exit(1);
			}
			if (File.Exists("xcbm5x0.exe")) {
    			
			}
			else {
				string message = "Couldn't find the CBM II (5x0) executable. Make sure the launcher executable is in the same directory as your VICE 3.1 installation.";
                string caption = "Error!";
				MessageBoxButtons buttons = MessageBoxButtons.OK;
				DialogResult result;
				result = MessageBox.Show(message, caption, buttons);
				Environment.Exit(1);
			}
			if (File.Exists("vsid.exe")) {
    			
			}
			else {
				string message = "Couldn't find the Commodore SID Player executable. Make sure the launcher executable is in the same directory as your VICE 3.1 installation.";
                string caption = "Error!";
				MessageBoxButtons buttons = MessageBoxButtons.OK;
				DialogResult result;
				result = MessageBox.Show(message, caption, buttons);
				Environment.Exit(1);
			}
		}
		void Button1Click(object sender, EventArgs e)
		{
    		if(comboBox1.SelectedItem == "Commodore PET"){
				try{
					System.Diagnostics.Process.Start("xpet.exe");
				} catch {
					string message = "Could not start VICE in Commodore PET mode. Has the executable been modified since startup?";
                	string caption = "Error!";
					MessageBoxButtons buttons = MessageBoxButtons.OK;
					DialogResult result;
					result = MessageBox.Show(message, caption, buttons);
				}
    		}
    		else if(comboBox1.SelectedItem == "Commodore VIC"){
				try{
					System.Diagnostics.Process.Start("xvic.exe");
				} catch {
					string message = "Could not start VICE in Commodore VIC mode. Has the executable been modified since startup?";
                	string caption = "Error!";
					MessageBoxButtons buttons = MessageBoxButtons.OK;
					DialogResult result;
					result = MessageBox.Show(message, caption, buttons);
				}
    		}
			else if(comboBox1.SelectedItem == "Commodore 64"){
				try{
					System.Diagnostics.Process.Start("x64.exe");
				} catch {
					string message = "Could not start VICE in Commodore 64 mode. Has the executable been modified since startup?";
                	string caption = "Error!";
					MessageBoxButtons buttons = MessageBoxButtons.OK;
					DialogResult result;
					result = MessageBox.Show(message, caption, buttons);
				}
    		}
			else if(comboBox1.SelectedItem == "Commodore 64 DTV"){
				try{
					System.Diagnostics.Process.Start("x64dtv.exe");
				} catch {
					string message = "Could not start VICE in Commodore 64 DTV mode. Has the executable been modified since startup?";
                	string caption = "Error!";
					MessageBoxButtons buttons = MessageBoxButtons.OK;
					DialogResult result;
					result = MessageBox.Show(message, caption, buttons);
				}
    		}
			else if(comboBox1.SelectedItem == "Commodore 64 SC"){
				try{
					System.Diagnostics.Process.Start("x64sc.exe");
				} catch {
					string message = "Could not start VICE in Commodore 64 SC mode. Has the executable been modified since startup?";
                	string caption = "Error!";
					MessageBoxButtons buttons = MessageBoxButtons.OK;
					DialogResult result;
					result = MessageBox.Show(message, caption, buttons);
				}
    		}
			else if(comboBox1.SelectedItem == "Commodore 128"){
				try{
					System.Diagnostics.Process.Start("x128.exe");
				} catch {
					string message = "Could not start VICE in Commodore 128 mode. Has the executable been modified since startup?";
                	string caption = "Error!";
					MessageBoxButtons buttons = MessageBoxButtons.OK;
					DialogResult result;
					result = MessageBox.Show(message, caption, buttons);
				}
    		}
			else if(comboBox1.SelectedItem == "Commodore Plus4"){
				try{
					System.Diagnostics.Process.Start("xplus4.exe");
				} catch {
					string message = "Could not start VICE in Commodore Plus4 mode. Has the executable been modified since startup?";
                	string caption = "Error!";
					MessageBoxButtons buttons = MessageBoxButtons.OK;
					DialogResult result;
					result = MessageBox.Show(message, caption, buttons);
				}
    		}
			else if(comboBox1.SelectedItem == "Commodore SCPU (C16)"){
				try{
					System.Diagnostics.Process.Start("xscpu64.exe");
				} catch {
					string message = "Could not start VICE in Commodore SCPU (C16) mode. Has the executable been modified since startup?";
                	string caption = "Error!";
					MessageBoxButtons buttons = MessageBoxButtons.OK;
					DialogResult result;
					result = MessageBox.Show(message, caption, buttons);
				}
    		}
			else if(comboBox1.SelectedItem == "CBM II"){
				try{
					System.Diagnostics.Process.Start("xcbm2.exe");
				} catch {
					string message = "Could not start VICE in Commodore CBM II mode. Has the executable been modified since startup?";
                	string caption = "Error!";
					MessageBoxButtons buttons = MessageBoxButtons.OK;
					DialogResult result;
					result = MessageBox.Show(message, caption, buttons);
				}
    		}
			else if(comboBox1.SelectedItem == "CBM II (5x0)"){
				try{
					System.Diagnostics.Process.Start("xcbm5x0.exe");
				} catch {
					string message = "Could not start VICE in Commodore CBM II (5x0) mode. Has the executable been modified since startup?";
                	string caption = "Error!";
					MessageBoxButtons buttons = MessageBoxButtons.OK;
					DialogResult result;
					result = MessageBox.Show(message, caption, buttons);
				}
    		}
			else if(comboBox1.SelectedItem == "SID Player"){
				try{
					System.Diagnostics.Process.Start("vsid.exe");
				} catch {
					string message = "Could not start VICE in SID Player mode. Has the executable been modified since startup?";
                	string caption = "Error!";
					MessageBoxButtons buttons = MessageBoxButtons.OK;
					DialogResult result;
					result = MessageBox.Show(message, caption, buttons);
				}
    		}
    		else {
        		string message = "Please select an emulator mode to use!";
                string caption = "Select Valid Mode!";
				MessageBoxButtons buttons = MessageBoxButtons.OK;
				DialogResult result;
				result = MessageBox.Show(message, caption, buttons);
    		}
		}
	}
}