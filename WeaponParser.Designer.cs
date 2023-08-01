using System;
using System.Windows.Forms;

namespace CallOfDutyWeaponParser
{
    partial class WeaponParser
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.TransferButton = new System.Windows.Forms.Button();
            this.filtersTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TransferPanel = new System.Windows.Forms.Panel();
            this.OpenFirstFile = new System.Windows.Forms.Button();
            this.OpenSecondFile = new System.Windows.Forms.Button();
            this.SaveFirstFile = new System.Windows.Forms.Button();
            this.SaveSecondFile = new System.Windows.Forms.Button();
            this.Panel1Name = new System.Windows.Forms.Label();
            this.Panel2Name = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new CallOfDutyWeaponParser.CustomFlowLayoutPanel();
            this.flowLayoutPanel1 = new CallOfDutyWeaponParser.CustomFlowLayoutPanel();
            this.menuStrip2.SuspendLayout();
            this.TransferPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(454, 247);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1034, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // TransferButton
            // 
            this.TransferButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TransferButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TransferButton.Location = new System.Drawing.Point(3, 64);
            this.TransferButton.Name = "TransferButton";
            this.TransferButton.Size = new System.Drawing.Size(90, 23);
            this.TransferButton.TabIndex = 5;
            this.TransferButton.Text = "<---Transfer";
            this.TransferButton.UseVisualStyleBackColor = true;
            this.TransferButton.Click += new System.EventHandler(this.TransferButton_Click);
            // 
            // filtersTextBox
            // 
            this.filtersTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filtersTextBox.Location = new System.Drawing.Point(3, 24);
            this.filtersTextBox.Name = "filtersTextBox";
            this.filtersTextBox.Size = new System.Drawing.Size(90, 20);
            this.filtersTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filters (Separated by space)";
            // 
            // TransferPanel
            // 
            this.TransferPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TransferPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TransferPanel.Controls.Add(this.label1);
            this.TransferPanel.Controls.Add(this.TransferButton);
            this.TransferPanel.Controls.Add(this.filtersTextBox);
            this.TransferPanel.Location = new System.Drawing.Point(466, 469);
            this.TransferPanel.MinimumSize = new System.Drawing.Size(100, 4);
            this.TransferPanel.Name = "TransferPanel";
            this.TransferPanel.Size = new System.Drawing.Size(100, 105);
            this.TransferPanel.TabIndex = 8;
            this.TransferPanel.Visible = false;
            // 
            // OpenFirstFile
            // 
            this.OpenFirstFile.ForeColor = System.Drawing.Color.Red;
            this.OpenFirstFile.Location = new System.Drawing.Point(466, 54);
            this.OpenFirstFile.Name = "OpenFirstFile";
            this.OpenFirstFile.Size = new System.Drawing.Size(47, 20);
            this.OpenFirstFile.TabIndex = 9;
            this.OpenFirstFile.Text = "Open...";
            this.OpenFirstFile.UseVisualStyleBackColor = true;
            this.OpenFirstFile.Click += new System.EventHandler(this.OpenFirstFile_Click);
            // 
            // OpenSecondFile
            // 
            this.OpenSecondFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenSecondFile.ForeColor = System.Drawing.Color.Red;
            this.OpenSecondFile.Location = new System.Drawing.Point(516, 54);
            this.OpenSecondFile.Name = "OpenSecondFile";
            this.OpenSecondFile.Size = new System.Drawing.Size(47, 20);
            this.OpenSecondFile.TabIndex = 10;
            this.OpenSecondFile.Text = "Open...";
            this.OpenSecondFile.UseVisualStyleBackColor = true;
            this.OpenSecondFile.Click += new System.EventHandler(this.OpenSecondFile_Click);
            // 
            // SaveFirstFile
            // 
            this.SaveFirstFile.ForeColor = System.Drawing.Color.Red;
            this.SaveFirstFile.Location = new System.Drawing.Point(466, 80);
            this.SaveFirstFile.Name = "SaveFirstFile";
            this.SaveFirstFile.Size = new System.Drawing.Size(47, 20);
            this.SaveFirstFile.TabIndex = 11;
            this.SaveFirstFile.Text = "Save";
            this.SaveFirstFile.UseVisualStyleBackColor = true;
            this.SaveFirstFile.Click += new System.EventHandler(this.SaveFirstFile_Click);
            // 
            // SaveSecondFile
            // 
            this.SaveSecondFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveSecondFile.ForeColor = System.Drawing.Color.Red;
            this.SaveSecondFile.Location = new System.Drawing.Point(516, 80);
            this.SaveSecondFile.Name = "SaveSecondFile";
            this.SaveSecondFile.Size = new System.Drawing.Size(47, 20);
            this.SaveSecondFile.TabIndex = 12;
            this.SaveSecondFile.Text = "Save";
            this.SaveSecondFile.UseVisualStyleBackColor = true;
            this.SaveSecondFile.Click += new System.EventHandler(this.SaveSecondFile_Click);
            // 
            // Panel1Name
            // 
            this.Panel1Name.AutoSize = true;
            this.Panel1Name.Location = new System.Drawing.Point(12, 30);
            this.Panel1Name.Name = "Panel1Name";
            this.Panel1Name.Size = new System.Drawing.Size(64, 13);
            this.Panel1Name.TabIndex = 13;
            this.Panel1Name.Text = "No open file";
            // 
            // Panel2Name
            // 
            this.Panel2Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel2Name.Location = new System.Drawing.Point(569, 30);
            this.Panel2Name.Name = "Panel2Name";
            this.Panel2Name.Size = new System.Drawing.Size(415, 13);
            this.Panel2Name.TabIndex = 14;
            this.Panel2Name.Text = "No open file";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(572, 54);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(450, 520);
            this.flowLayoutPanel2.TabIndex = 1;
            this.flowLayoutPanel2.WrapContents = false;
            this.flowLayoutPanel2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.FlowLayoutPanel2_Scroll);
            this.flowLayoutPanel2.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.FlowLayoutPanel2_ScrollWheel);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 54);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(450, 520);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            this.flowLayoutPanel1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.FlowLayoutPanel1_Scroll);
            this.flowLayoutPanel1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.FlowLayoutPanel1_ScrollWheel);
            // 
            // WeaponParser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 586);
            this.Controls.Add(this.Panel2Name);
            this.Controls.Add(this.Panel1Name);
            this.Controls.Add(this.SaveSecondFile);
            this.Controls.Add(this.SaveFirstFile);
            this.Controls.Add(this.OpenSecondFile);
            this.Controls.Add(this.OpenFirstFile);
            this.Controls.Add(this.TransferPanel);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip2;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(5555, 4000);
            this.MinimumSize = new System.Drawing.Size(1050, 625);
            this.Name = "WeaponParser";
            this.Text = "COD Weapon Parser";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.TransferPanel.ResumeLayout(false);
            this.TransferPanel.PerformLayout();
            this.Resize += WeaponParser_Resize;
            this.ResumeLayout(false);
            this.PerformLayout();


        }

        private void WeaponParser_Resize(object sender, EventArgs e)
        {
            Update();
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private CustomFlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private CustomFlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button TransferButton;
        private System.Windows.Forms.TextBox filtersTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel TransferPanel;
        private System.Windows.Forms.Button OpenFirstFile;
        private System.Windows.Forms.Button OpenSecondFile;
        private System.Windows.Forms.Button SaveFirstFile;
        private System.Windows.Forms.Button SaveSecondFile;
        private Label Panel1Name;
        private Label Panel2Name;
    }
}

