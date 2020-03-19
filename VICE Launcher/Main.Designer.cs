/*
 * Created by SharpDevelop.
 * User: s201061936
 * Date: 2/21/2019
 * Time: 11:49 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace VICE_Launcher
{
	partial class Main
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.LogoLabel = new System.Windows.Forms.Label();
            this.PETTitle = new System.Windows.Forms.Label();
            this.LaunchPET = new System.Windows.Forms.Button();
            this.Splitter1 = new System.Windows.Forms.Label();
            this.Splitter2 = new System.Windows.Forms.Label();
            this.LaunchVIC = new System.Windows.Forms.Button();
            this.VICTitle = new System.Windows.Forms.Label();
            this.Splitter3 = new System.Windows.Forms.Label();
            this.LaunchSF = new System.Windows.Forms.Button();
            this.SFTitle = new System.Windows.Forms.Label();
            this.Splitter4 = new System.Windows.Forms.Label();
            this.LaunchOTE = new System.Windows.Forms.Button();
            this.OTETitle = new System.Windows.Forms.Label();
            this.Splitter5 = new System.Windows.Forms.Label();
            this.LaunchPLUS = new System.Windows.Forms.Button();
            this.PLUSTitle = new System.Windows.Forms.Label();
            this.Splitter6 = new System.Windows.Forms.Label();
            this.LaunchSCPU = new System.Windows.Forms.Button();
            this.SCPUTitle = new System.Windows.Forms.Label();
            this.LaunchCBM = new System.Windows.Forms.Button();
            this.CBMTitle = new System.Windows.Forms.Label();
            this.Splitter7 = new System.Windows.Forms.Label();
            this.LaunchSFDTV = new System.Windows.Forms.Button();
            this.LaunchSFSC = new System.Windows.Forms.Button();
            this.LaunchCBMFXZ = new System.Windows.Forms.Button();
            this.Splitter8 = new System.Windows.Forms.Label();
            this.LaunchSID = new System.Windows.Forms.Button();
            this.RepoLink = new System.Windows.Forms.LinkLabel();
            this.LaunchPETCAT = new System.Windows.Forms.Button();
            this.LaunchCDRIVE = new System.Windows.Forms.Button();
            this.ModeWarn = new System.Windows.Forms.Label();
            this.CMode = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Extras = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoLabel
            // 
            this.LogoLabel.ForeColor = System.Drawing.Color.Silver;
            this.LogoLabel.Location = new System.Drawing.Point(84, 412);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(64, 15);
            this.LogoLabel.TabIndex = 7;
            this.LogoLabel.Text = "Version 2.1";
            // 
            // PETTitle
            // 
            this.PETTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.PETTitle.Location = new System.Drawing.Point(217, 35);
            this.PETTitle.Name = "PETTitle";
            this.PETTitle.Size = new System.Drawing.Size(171, 15);
            this.PETTitle.TabIndex = 9;
            this.PETTitle.Text = "Commodore PET";
            // 
            // LaunchPET
            // 
            this.LaunchPET.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LaunchPET.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LaunchPET.Location = new System.Drawing.Point(218, 53);
            this.LaunchPET.Name = "LaunchPET";
            this.LaunchPET.Size = new System.Drawing.Size(297, 23);
            this.LaunchPET.TabIndex = 10;
            this.LaunchPET.Text = "Launch Vice PET";
            this.LaunchPET.UseVisualStyleBackColor = true;
            this.LaunchPET.Click += new System.EventHandler(this.LaunchPET_Click);
            // 
            // Splitter1
            // 
            this.Splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Splitter1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Splitter1.ForeColor = System.Drawing.SystemColors.Control;
            this.Splitter1.Location = new System.Drawing.Point(212, 84);
            this.Splitter1.Name = "Splitter1";
            this.Splitter1.Size = new System.Drawing.Size(309, 1);
            this.Splitter1.TabIndex = 11;
            // 
            // Splitter2
            // 
            this.Splitter2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Splitter2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Splitter2.ForeColor = System.Drawing.SystemColors.Control;
            this.Splitter2.Location = new System.Drawing.Point(212, 140);
            this.Splitter2.Name = "Splitter2";
            this.Splitter2.Size = new System.Drawing.Size(309, 1);
            this.Splitter2.TabIndex = 14;
            // 
            // LaunchVIC
            // 
            this.LaunchVIC.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LaunchVIC.Location = new System.Drawing.Point(218, 109);
            this.LaunchVIC.Name = "LaunchVIC";
            this.LaunchVIC.Size = new System.Drawing.Size(297, 23);
            this.LaunchVIC.TabIndex = 13;
            this.LaunchVIC.Text = "Launch Vice VIC";
            this.LaunchVIC.UseVisualStyleBackColor = true;
            this.LaunchVIC.Click += new System.EventHandler(this.LaunchVIC_Click);
            // 
            // VICTitle
            // 
            this.VICTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.VICTitle.Location = new System.Drawing.Point(217, 91);
            this.VICTitle.Name = "VICTitle";
            this.VICTitle.Size = new System.Drawing.Size(171, 15);
            this.VICTitle.TabIndex = 12;
            this.VICTitle.Text = "Commodore VIC";
            // 
            // Splitter3
            // 
            this.Splitter3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Splitter3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Splitter3.ForeColor = System.Drawing.SystemColors.Control;
            this.Splitter3.Location = new System.Drawing.Point(212, 197);
            this.Splitter3.Name = "Splitter3";
            this.Splitter3.Size = new System.Drawing.Size(309, 1);
            this.Splitter3.TabIndex = 17;
            // 
            // LaunchSF
            // 
            this.LaunchSF.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LaunchSF.Location = new System.Drawing.Point(218, 166);
            this.LaunchSF.Name = "LaunchSF";
            this.LaunchSF.Size = new System.Drawing.Size(90, 23);
            this.LaunchSF.TabIndex = 16;
            this.LaunchSF.Text = "Vice 64";
            this.LaunchSF.UseVisualStyleBackColor = true;
            this.LaunchSF.Click += new System.EventHandler(this.LaunchSF_Click);
            // 
            // SFTitle
            // 
            this.SFTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.SFTitle.Location = new System.Drawing.Point(217, 148);
            this.SFTitle.Name = "SFTitle";
            this.SFTitle.Size = new System.Drawing.Size(171, 15);
            this.SFTitle.TabIndex = 15;
            this.SFTitle.Text = "Commodore 64";
            // 
            // Splitter4
            // 
            this.Splitter4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Splitter4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Splitter4.ForeColor = System.Drawing.SystemColors.Control;
            this.Splitter4.Location = new System.Drawing.Point(212, 256);
            this.Splitter4.Name = "Splitter4";
            this.Splitter4.Size = new System.Drawing.Size(309, 1);
            this.Splitter4.TabIndex = 20;
            // 
            // LaunchOTE
            // 
            this.LaunchOTE.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LaunchOTE.Location = new System.Drawing.Point(218, 225);
            this.LaunchOTE.Name = "LaunchOTE";
            this.LaunchOTE.Size = new System.Drawing.Size(297, 23);
            this.LaunchOTE.TabIndex = 19;
            this.LaunchOTE.Text = "Launch Vice 128";
            this.LaunchOTE.UseVisualStyleBackColor = true;
            this.LaunchOTE.Click += new System.EventHandler(this.LaunchOTE_Click);
            // 
            // OTETitle
            // 
            this.OTETitle.ForeColor = System.Drawing.SystemColors.Control;
            this.OTETitle.Location = new System.Drawing.Point(217, 207);
            this.OTETitle.Name = "OTETitle";
            this.OTETitle.Size = new System.Drawing.Size(171, 15);
            this.OTETitle.TabIndex = 18;
            this.OTETitle.Text = "Commodore 128";
            // 
            // Splitter5
            // 
            this.Splitter5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Splitter5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Splitter5.ForeColor = System.Drawing.SystemColors.Control;
            this.Splitter5.Location = new System.Drawing.Point(212, 312);
            this.Splitter5.Name = "Splitter5";
            this.Splitter5.Size = new System.Drawing.Size(309, 1);
            this.Splitter5.TabIndex = 23;
            // 
            // LaunchPLUS
            // 
            this.LaunchPLUS.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LaunchPLUS.Location = new System.Drawing.Point(218, 281);
            this.LaunchPLUS.Name = "LaunchPLUS";
            this.LaunchPLUS.Size = new System.Drawing.Size(297, 23);
            this.LaunchPLUS.TabIndex = 22;
            this.LaunchPLUS.Text = "Launch Vice Plus-4";
            this.LaunchPLUS.UseVisualStyleBackColor = true;
            this.LaunchPLUS.Click += new System.EventHandler(this.LaunchPLUS_Click);
            // 
            // PLUSTitle
            // 
            this.PLUSTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.PLUSTitle.Location = new System.Drawing.Point(217, 263);
            this.PLUSTitle.Name = "PLUSTitle";
            this.PLUSTitle.Size = new System.Drawing.Size(171, 15);
            this.PLUSTitle.TabIndex = 21;
            this.PLUSTitle.Text = "Commodore Plus-4";
            // 
            // Splitter6
            // 
            this.Splitter6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Splitter6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Splitter6.ForeColor = System.Drawing.SystemColors.Control;
            this.Splitter6.Location = new System.Drawing.Point(212, 372);
            this.Splitter6.Name = "Splitter6";
            this.Splitter6.Size = new System.Drawing.Size(309, 1);
            this.Splitter6.TabIndex = 26;
            // 
            // LaunchSCPU
            // 
            this.LaunchSCPU.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LaunchSCPU.Location = new System.Drawing.Point(218, 341);
            this.LaunchSCPU.Name = "LaunchSCPU";
            this.LaunchSCPU.Size = new System.Drawing.Size(297, 23);
            this.LaunchSCPU.TabIndex = 25;
            this.LaunchSCPU.Text = "Launch Vice 16";
            this.LaunchSCPU.UseVisualStyleBackColor = true;
            this.LaunchSCPU.Click += new System.EventHandler(this.LaunchSCPU_Click);
            // 
            // SCPUTitle
            // 
            this.SCPUTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.SCPUTitle.Location = new System.Drawing.Point(217, 323);
            this.SCPUTitle.Name = "SCPUTitle";
            this.SCPUTitle.Size = new System.Drawing.Size(171, 15);
            this.SCPUTitle.TabIndex = 24;
            this.SCPUTitle.Text = "Commodore 16 (SCPU)";
            // 
            // LaunchCBM
            // 
            this.LaunchCBM.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LaunchCBM.Location = new System.Drawing.Point(218, 399);
            this.LaunchCBM.Name = "LaunchCBM";
            this.LaunchCBM.Size = new System.Drawing.Size(147, 23);
            this.LaunchCBM.TabIndex = 28;
            this.LaunchCBM.Text = "Launch Vice CBM-II";
            this.LaunchCBM.UseVisualStyleBackColor = true;
            this.LaunchCBM.Click += new System.EventHandler(this.LaunchCBM_Click);
            // 
            // CBMTitle
            // 
            this.CBMTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.CBMTitle.Location = new System.Drawing.Point(217, 381);
            this.CBMTitle.Name = "CBMTitle";
            this.CBMTitle.Size = new System.Drawing.Size(171, 15);
            this.CBMTitle.TabIndex = 27;
            this.CBMTitle.Text = "Commodore CBM-II";
            // 
            // Splitter7
            // 
            this.Splitter7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Splitter7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Splitter7.ForeColor = System.Drawing.SystemColors.Control;
            this.Splitter7.Location = new System.Drawing.Point(202, 10);
            this.Splitter7.Name = "Splitter7";
            this.Splitter7.Size = new System.Drawing.Size(1, 415);
            this.Splitter7.TabIndex = 29;
            // 
            // LaunchSFDTV
            // 
            this.LaunchSFDTV.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LaunchSFDTV.Location = new System.Drawing.Point(314, 166);
            this.LaunchSFDTV.Name = "LaunchSFDTV";
            this.LaunchSFDTV.Size = new System.Drawing.Size(105, 23);
            this.LaunchSFDTV.TabIndex = 30;
            this.LaunchSFDTV.Text = "Vice 64 DTV";
            this.LaunchSFDTV.UseVisualStyleBackColor = true;
            this.LaunchSFDTV.Click += new System.EventHandler(this.LaunchSFDTV_Click);
            // 
            // LaunchSFSC
            // 
            this.LaunchSFSC.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LaunchSFSC.Location = new System.Drawing.Point(425, 166);
            this.LaunchSFSC.Name = "LaunchSFSC";
            this.LaunchSFSC.Size = new System.Drawing.Size(90, 23);
            this.LaunchSFSC.TabIndex = 31;
            this.LaunchSFSC.Text = "Vice 64 SC";
            this.LaunchSFSC.UseVisualStyleBackColor = true;
            this.LaunchSFSC.Click += new System.EventHandler(this.LaunchSFSC_Click);
            // 
            // LaunchCBMFXZ
            // 
            this.LaunchCBMFXZ.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LaunchCBMFXZ.Location = new System.Drawing.Point(371, 399);
            this.LaunchCBMFXZ.Name = "LaunchCBMFXZ";
            this.LaunchCBMFXZ.Size = new System.Drawing.Size(144, 23);
            this.LaunchCBMFXZ.TabIndex = 32;
            this.LaunchCBMFXZ.Text = "Launch Vice CBM-II (5x0)";
            this.LaunchCBMFXZ.UseVisualStyleBackColor = true;
            this.LaunchCBMFXZ.Click += new System.EventHandler(this.LaunchCBMFXZ_Click);
            // 
            // Splitter8
            // 
            this.Splitter8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Splitter8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Splitter8.ForeColor = System.Drawing.SystemColors.Control;
            this.Splitter8.Location = new System.Drawing.Point(11, 83);
            this.Splitter8.Name = "Splitter8";
            this.Splitter8.Size = new System.Drawing.Size(180, 1);
            this.Splitter8.TabIndex = 33;
            // 
            // LaunchSID
            // 
            this.LaunchSID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LaunchSID.Location = new System.Drawing.Point(11, 119);
            this.LaunchSID.Name = "LaunchSID";
            this.LaunchSID.Size = new System.Drawing.Size(180, 23);
            this.LaunchSID.TabIndex = 35;
            this.LaunchSID.Text = "Vice SID File Player";
            this.LaunchSID.UseVisualStyleBackColor = true;
            this.LaunchSID.Click += new System.EventHandler(this.LaunchSID_Click);
            // 
            // RepoLink
            // 
            this.RepoLink.ActiveLinkColor = System.Drawing.Color.Silver;
            this.RepoLink.AutoSize = true;
            this.RepoLink.LinkColor = System.Drawing.Color.Silver;
            this.RepoLink.Location = new System.Drawing.Point(12, 412);
            this.RepoLink.Name = "RepoLink";
            this.RepoLink.Size = new System.Drawing.Size(66, 13);
            this.RepoLink.TabIndex = 38;
            this.RepoLink.TabStop = true;
            this.RepoLink.Text = "Github Page";
            this.RepoLink.VisitedLinkColor = System.Drawing.Color.Silver;
            this.RepoLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RepoLink_LinkClicked);
            // 
            // LaunchPETCAT
            // 
            this.LaunchPETCAT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LaunchPETCAT.Location = new System.Drawing.Point(11, 148);
            this.LaunchPETCAT.Name = "LaunchPETCAT";
            this.LaunchPETCAT.Size = new System.Drawing.Size(180, 23);
            this.LaunchPETCAT.TabIndex = 39;
            this.LaunchPETCAT.Text = "Vice PETCAT";
            this.LaunchPETCAT.UseVisualStyleBackColor = true;
            this.LaunchPETCAT.Click += new System.EventHandler(this.LaunchPETCAT_Click);
            // 
            // LaunchCDRIVE
            // 
            this.LaunchCDRIVE.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LaunchCDRIVE.Location = new System.Drawing.Point(11, 177);
            this.LaunchCDRIVE.Name = "LaunchCDRIVE";
            this.LaunchCDRIVE.Size = new System.Drawing.Size(180, 23);
            this.LaunchCDRIVE.TabIndex = 40;
            this.LaunchCDRIVE.Text = "Vice C1541";
            this.LaunchCDRIVE.UseVisualStyleBackColor = true;
            this.LaunchCDRIVE.Click += new System.EventHandler(this.LaunchCDRIVE_Click);
            // 
            // ModeWarn
            // 
            this.ModeWarn.AutoSize = true;
            this.ModeWarn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ModeWarn.Location = new System.Drawing.Point(343, 8);
            this.ModeWarn.Name = "ModeWarn";
            this.ModeWarn.Size = new System.Drawing.Size(181, 13);
            this.ModeWarn.TabIndex = 41;
            this.ModeWarn.Text = "Could not detect some parts of VICE.";
            this.ModeWarn.Visible = false;
            // 
            // CMode
            // 
            this.CMode.AutoSize = true;
            this.CMode.ForeColor = System.Drawing.SystemColors.Control;
            this.CMode.Location = new System.Drawing.Point(216, 9);
            this.CMode.Name = "CMode";
            this.CMode.Size = new System.Drawing.Size(64, 13);
            this.CMode.TabIndex = 42;
            this.CMode.Text = "Core Modes";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(212, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 1);
            this.label3.TabIndex = 43;
            // 
            // Extras
            // 
            this.Extras.AutoSize = true;
            this.Extras.ForeColor = System.Drawing.SystemColors.Control;
            this.Extras.Location = new System.Drawing.Point(10, 90);
            this.Extras.Name = "Extras";
            this.Extras.Size = new System.Drawing.Size(36, 13);
            this.Extras.TabIndex = 44;
            this.Extras.Text = "Extras";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(11, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 1);
            this.label5.TabIndex = 45;
            // 
            // Logo
            // 
            this.Logo.Image = global::VICE_Launcher.Properties.Resources.logo;
            this.Logo.Location = new System.Drawing.Point(8, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(186, 63);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Logo.TabIndex = 3;
            this.Logo.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(531, 434);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Extras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ModeWarn);
            this.Controls.Add(this.CMode);
            this.Controls.Add(this.LaunchCDRIVE);
            this.Controls.Add(this.LaunchPETCAT);
            this.Controls.Add(this.RepoLink);
            this.Controls.Add(this.LaunchSID);
            this.Controls.Add(this.Splitter8);
            this.Controls.Add(this.LaunchCBMFXZ);
            this.Controls.Add(this.LaunchSFSC);
            this.Controls.Add(this.LaunchSFDTV);
            this.Controls.Add(this.Splitter7);
            this.Controls.Add(this.LaunchCBM);
            this.Controls.Add(this.CBMTitle);
            this.Controls.Add(this.Splitter6);
            this.Controls.Add(this.LaunchSCPU);
            this.Controls.Add(this.SCPUTitle);
            this.Controls.Add(this.Splitter5);
            this.Controls.Add(this.LaunchPLUS);
            this.Controls.Add(this.PLUSTitle);
            this.Controls.Add(this.Splitter4);
            this.Controls.Add(this.LaunchOTE);
            this.Controls.Add(this.OTETitle);
            this.Controls.Add(this.Splitter3);
            this.Controls.Add(this.LaunchSF);
            this.Controls.Add(this.SFTitle);
            this.Controls.Add(this.Splitter2);
            this.Controls.Add(this.LaunchVIC);
            this.Controls.Add(this.VICTitle);
            this.Controls.Add(this.Splitter1);
            this.Controls.Add(this.LaunchPET);
            this.Controls.Add(this.PETTitle);
            this.Controls.Add(this.LogoLabel);
            this.Controls.Add(this.Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "VICE Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Label LogoLabel;
		private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label PETTitle;
        private System.Windows.Forms.Button LaunchPET;
        private System.Windows.Forms.Label Splitter1;
        private System.Windows.Forms.Label Splitter2;
        private System.Windows.Forms.Button LaunchVIC;
        private System.Windows.Forms.Label VICTitle;
        private System.Windows.Forms.Label Splitter3;
        private System.Windows.Forms.Button LaunchSF;
        private System.Windows.Forms.Label SFTitle;
        private System.Windows.Forms.Label Splitter4;
        private System.Windows.Forms.Button LaunchOTE;
        private System.Windows.Forms.Label OTETitle;
        private System.Windows.Forms.Label Splitter5;
        private System.Windows.Forms.Button LaunchPLUS;
        private System.Windows.Forms.Label PLUSTitle;
        private System.Windows.Forms.Label Splitter6;
        private System.Windows.Forms.Button LaunchSCPU;
        private System.Windows.Forms.Label SCPUTitle;
        private System.Windows.Forms.Button LaunchCBM;
        private System.Windows.Forms.Label CBMTitle;
        private System.Windows.Forms.Label Splitter7;
        private System.Windows.Forms.Button LaunchSFDTV;
        private System.Windows.Forms.Button LaunchSFSC;
        private System.Windows.Forms.Button LaunchCBMFXZ;
        private System.Windows.Forms.Label Splitter8;
        private System.Windows.Forms.Button LaunchSID;
        private System.Windows.Forms.LinkLabel RepoLink;
        private System.Windows.Forms.Button LaunchPETCAT;
        private System.Windows.Forms.Button LaunchCDRIVE;
        private System.Windows.Forms.Label ModeWarn;
        private System.Windows.Forms.Label CMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Extras;
        private System.Windows.Forms.Label label5;
    }
}
