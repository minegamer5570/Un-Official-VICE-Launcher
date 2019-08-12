namespace VICE_Launcher
{
    partial class About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.okButton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.RepoLink = new System.Windows.Forms.LinkLabel();
            this.Author = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(348, 203);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(3, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(214, 33);
            this.Title.TabIndex = 25;
            this.Title.Text = "Vice Launcher";
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.ForeColor = System.Drawing.SystemColors.Control;
            this.Version.Location = new System.Drawing.Point(12, 42);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(60, 13);
            this.Version.TabIndex = 27;
            this.Version.Text = "Version 2.0";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.ForeColor = System.Drawing.SystemColors.Control;
            this.Description.Location = new System.Drawing.Point(12, 76);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(398, 117);
            this.Description.TabIndex = 28;
            this.Description.Text = resources.GetString("Description.Text");
            // 
            // RepoLink
            // 
            this.RepoLink.ActiveLinkColor = System.Drawing.Color.Silver;
            this.RepoLink.AutoSize = true;
            this.RepoLink.LinkColor = System.Drawing.Color.Silver;
            this.RepoLink.Location = new System.Drawing.Point(12, 213);
            this.RepoLink.Name = "RepoLink";
            this.RepoLink.Size = new System.Drawing.Size(66, 13);
            this.RepoLink.TabIndex = 40;
            this.RepoLink.TabStop = true;
            this.RepoLink.Text = "Github Page";
            this.RepoLink.VisitedLinkColor = System.Drawing.Color.Silver;
            this.RepoLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RepoLink_LinkClicked);
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.ForeColor = System.Drawing.Color.Silver;
            this.Author.Location = new System.Drawing.Point(84, 213);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(256, 13);
            this.Author.TabIndex = 41;
            this.Author.Text = "Vice Launcher 2.0 - Developed by Liam Hogan 2019";
            // 
            // About
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(435, 235);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.RepoLink);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "About - Vice Launcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.LinkLabel RepoLink;
        private System.Windows.Forms.Label Author;
    }
}
