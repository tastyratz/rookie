﻿
using AndroidSideloader.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace AndroidSideloader
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_combo = new SergeUtils.EasyCompletionComboBox();
            this.startsideloadbutton = new System.Windows.Forms.Button();
            this.devicesbutton = new System.Windows.Forms.Button();
            this.obbcopybutton = new System.Windows.Forms.Button();
            this.backupbutton = new System.Windows.Forms.Button();
            this.restorebutton = new System.Windows.Forms.Button();
            this.getApkButton = new System.Windows.Forms.Button();
            this.uninstallAppButton = new System.Windows.Forms.Button();
            this.pullAppToDesktopBtn = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.copyBulkObbButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.verLabel = new System.Windows.Forms.Label();
            this.ULLabel = new System.Windows.Forms.Label();
            this.ULGif = new System.Windows.Forms.PictureBox();
            this.BatteryLbl = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.downloadingLabel = new System.Windows.Forms.Label();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.otherContainer = new System.Windows.Forms.Panel();
            this.InstallQUset = new System.Windows.Forms.Button();
            this.removeQUSetting = new System.Windows.Forms.Button();
            this.QuestOptionsButton = new System.Windows.Forms.Button();
            this.ADBWirelessDisable = new System.Windows.Forms.Button();
            this.ADBWirelessEnable = new System.Windows.Forms.Button();
            this.otherDrop = new System.Windows.Forms.Button();
            this.backupContainer = new System.Windows.Forms.Panel();
            this.backupDrop = new System.Windows.Forms.Button();
            this.sideloadContainer = new System.Windows.Forms.Panel();
            this.UpdateGamesButton = new System.Windows.Forms.Button();
            this.listApkButton = new System.Windows.Forms.Button();
            this.sideloadDrop = new System.Windows.Forms.Button();
            this.diskLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.etaLabel = new System.Windows.Forms.Label();
            this.freeDisclaimer = new System.Windows.Forms.Label();
            this.gamesQueListBox = new System.Windows.Forms.ListBox();
            this.devicesComboBox = new System.Windows.Forms.ComboBox();
            this.remotesList = new System.Windows.Forms.ComboBox();
            this.gamesListView = new System.Windows.Forms.ListView();
            this.GameNameIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReleaseNameIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PackageNameIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VersionCodeIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReleaseAPKPathIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VersionNameIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.gamesQueueLabel = new System.Windows.Forms.Label();
            this.ProgressText = new System.Windows.Forms.Label();
            this.notesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.DragDropLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUpdateAvailable = new System.Windows.Forms.Label();
            this.lblUpToDate = new System.Windows.Forms.Label();
            this.lblMirror = new System.Windows.Forms.Label();
            this.EnterInstallBox = new System.Windows.Forms.CheckBox();
            this.ADBcommandbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lblNeedsDonate = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gamesPictureBox = new System.Windows.Forms.PictureBox();
            this.MountButton = new AndroidSideloader.RoundButton();
            this.downloadInstallGameButton = new AndroidSideloader.RoundButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ULGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.otherContainer.SuspendLayout();
            this.backupContainer.SuspendLayout();
            this.sideloadContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // m_combo
            // 
            this.m_combo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.m_combo.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.m_combo.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.m_combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_combo.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.m_combo.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.m_combo.Location = new System.Drawing.Point(224, 9);
            this.m_combo.Name = "m_combo";
            this.m_combo.Size = new System.Drawing.Size(374, 26);
            this.m_combo.TabIndex = 0;
            this.m_combo.Text = "Select an Installed App to Uninstall or Share...";
            // 
            // startsideloadbutton
            // 
            this.startsideloadbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.startsideloadbutton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.startsideloadbutton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.startsideloadbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.startsideloadbutton.FlatAppearance.BorderSize = 0;
            this.startsideloadbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startsideloadbutton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.startsideloadbutton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.startsideloadbutton.Location = new System.Drawing.Point(0, 140);
            this.startsideloadbutton.Name = "startsideloadbutton";
            this.startsideloadbutton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.startsideloadbutton.Size = new System.Drawing.Size(221, 28);
            this.startsideloadbutton.TabIndex = 5;
            this.startsideloadbutton.Text = "Sideload APK";
            this.startsideloadbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startsideloadbutton.UseVisualStyleBackColor = false;
            this.startsideloadbutton.Click += new System.EventHandler(this.startsideloadbutton_Click);
            // 
            // devicesbutton
            // 
            this.devicesbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.devicesbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.devicesbutton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.devicesbutton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.devicesbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.devicesbutton.FlatAppearance.BorderSize = 0;
            this.devicesbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.devicesbutton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.devicesbutton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.devicesbutton.Location = new System.Drawing.Point(0, 0);
            this.devicesbutton.Name = "devicesbutton";
            this.devicesbutton.Size = new System.Drawing.Size(221, 28);
            this.devicesbutton.TabIndex = 0;
            this.devicesbutton.Text = "RECONNECT DEVICE";
            this.devicesbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.devicesbutton.UseVisualStyleBackColor = false;
            this.devicesbutton.Click += new System.EventHandler(this.devicesbutton_Click);
            // 
            // obbcopybutton
            // 
            this.obbcopybutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.obbcopybutton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.obbcopybutton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.obbcopybutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.obbcopybutton.FlatAppearance.BorderSize = 0;
            this.obbcopybutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.obbcopybutton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.obbcopybutton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.obbcopybutton.Location = new System.Drawing.Point(0, 0);
            this.obbcopybutton.Name = "obbcopybutton";
            this.obbcopybutton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.obbcopybutton.Size = new System.Drawing.Size(221, 28);
            this.obbcopybutton.TabIndex = 0;
            this.obbcopybutton.Text = "Copy OBB";
            this.obbcopybutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.obbcopybutton.UseVisualStyleBackColor = false;
            this.obbcopybutton.Click += new System.EventHandler(this.obbcopybutton_Click);
            // 
            // backupbutton
            // 
            this.backupbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.backupbutton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.backupbutton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.backupbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.backupbutton.FlatAppearance.BorderSize = 0;
            this.backupbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backupbutton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.backupbutton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.backupbutton.Location = new System.Drawing.Point(0, 28);
            this.backupbutton.Name = "backupbutton";
            this.backupbutton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.backupbutton.Size = new System.Drawing.Size(221, 28);
            this.backupbutton.TabIndex = 1;
            this.backupbutton.Text = "Backup Gamedata";
            this.backupbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backupbutton.UseVisualStyleBackColor = false;
            this.backupbutton.Click += new System.EventHandler(this.backupbutton_Click);
            // 
            // restorebutton
            // 
            this.restorebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.restorebutton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.restorebutton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.restorebutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.restorebutton.FlatAppearance.BorderSize = 0;
            this.restorebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restorebutton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.restorebutton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.restorebutton.Location = new System.Drawing.Point(0, 0);
            this.restorebutton.Name = "restorebutton";
            this.restorebutton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.restorebutton.Size = new System.Drawing.Size(221, 28);
            this.restorebutton.TabIndex = 0;
            this.restorebutton.Text = "Restore Gamedata";
            this.restorebutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.restorebutton.UseVisualStyleBackColor = false;
            this.restorebutton.Click += new System.EventHandler(this.restorebutton_Click);
            // 
            // getApkButton
            // 
            this.getApkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.getApkButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.getApkButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.getApkButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.getApkButton.FlatAppearance.BorderSize = 0;
            this.getApkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getApkButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.getApkButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.getApkButton.Location = new System.Drawing.Point(0, 56);
            this.getApkButton.Name = "getApkButton";
            this.getApkButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.getApkButton.Size = new System.Drawing.Size(221, 28);
            this.getApkButton.TabIndex = 2;
            this.getApkButton.Text = "Share Selected App";
            this.getApkButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.getApkButton.UseVisualStyleBackColor = false;
            this.getApkButton.Click += new System.EventHandler(this.getApkButton_Click);
            // 
            // uninstallAppButton
            // 
            this.uninstallAppButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.uninstallAppButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.uninstallAppButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.uninstallAppButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.uninstallAppButton.FlatAppearance.BorderSize = 0;
            this.uninstallAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uninstallAppButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.uninstallAppButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.uninstallAppButton.Location = new System.Drawing.Point(0, 84);
            this.uninstallAppButton.Name = "uninstallAppButton";
            this.uninstallAppButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uninstallAppButton.Size = new System.Drawing.Size(221, 28);
            this.uninstallAppButton.TabIndex = 3;
            this.uninstallAppButton.Text = "Uninstall Selected App";
            this.uninstallAppButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uninstallAppButton.UseVisualStyleBackColor = false;
            this.uninstallAppButton.Click += new System.EventHandler(this.uninstallAppButton_Click);
            // 
            // pullAppToDesktopBtn
            // 
            this.pullAppToDesktopBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.pullAppToDesktopBtn.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pullAppToDesktopBtn.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pullAppToDesktopBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pullAppToDesktopBtn.FlatAppearance.BorderSize = 0;
            this.pullAppToDesktopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pullAppToDesktopBtn.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.pullAppToDesktopBtn.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.pullAppToDesktopBtn.Location = new System.Drawing.Point(0, 112);
            this.pullAppToDesktopBtn.Name = "pullAppToDesktopBtn";
            this.pullAppToDesktopBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.pullAppToDesktopBtn.Size = new System.Drawing.Size(221, 28);
            this.pullAppToDesktopBtn.TabIndex = 4;
            this.pullAppToDesktopBtn.Text = "Pull App To Desktop";
            this.pullAppToDesktopBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pullAppToDesktopBtn.UseVisualStyleBackColor = false;
            this.pullAppToDesktopBtn.Click += new System.EventHandler(this.pullAppToDesktopBtn_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.progressBar.ForeColor = System.Drawing.Color.Purple;
            this.progressBar.Location = new System.Drawing.Point(224, 436);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(426, 13);
            this.progressBar.TabIndex = 7;
            // 
            // copyBulkObbButton
            // 
            this.copyBulkObbButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.copyBulkObbButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.copyBulkObbButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.copyBulkObbButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.copyBulkObbButton.FlatAppearance.BorderSize = 0;
            this.copyBulkObbButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyBulkObbButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.copyBulkObbButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.copyBulkObbButton.Location = new System.Drawing.Point(0, 28);
            this.copyBulkObbButton.Name = "copyBulkObbButton";
            this.copyBulkObbButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.copyBulkObbButton.Size = new System.Drawing.Size(221, 28);
            this.copyBulkObbButton.TabIndex = 1;
            this.copyBulkObbButton.Text = "Recursive Copy OBB";
            this.copyBulkObbButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.copyBulkObbButton.UseVisualStyleBackColor = false;
            this.copyBulkObbButton.Click += new System.EventHandler(this.copyBulkObbButton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.verLabel);
            this.panel1.Controls.Add(this.ULLabel);
            this.panel1.Controls.Add(this.ULGif);
            this.panel1.Controls.Add(this.BatteryLbl);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.downloadingLabel);
            this.panel1.Controls.Add(this.aboutBtn);
            this.panel1.Controls.Add(this.settingsButton);
            this.panel1.Controls.Add(this.otherContainer);
            this.panel1.Controls.Add(this.otherDrop);
            this.panel1.Controls.Add(this.backupContainer);
            this.panel1.Controls.Add(this.backupDrop);
            this.panel1.Controls.Add(this.sideloadContainer);
            this.panel1.Controls.Add(this.sideloadDrop);
            this.panel1.Controls.Add(this.devicesbutton);
            this.panel1.Controls.Add(this.diskLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 721);
            this.panel1.TabIndex = 73;
            // 
            // verLabel
            // 
            this.verLabel.AutoSize = true;
            this.verLabel.BackColor = System.Drawing.Color.Transparent;
            this.verLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.verLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.verLabel.Location = new System.Drawing.Point(3, 699);
            this.verLabel.Name = "verLabel";
            this.verLabel.Size = new System.Drawing.Size(0, 20);
            this.verLabel.TabIndex = 88;
            // 
            // ULLabel
            // 
            this.ULLabel.AutoSize = true;
            this.ULLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ULLabel.ForeColor = System.Drawing.Color.Snow;
            this.ULLabel.Location = new System.Drawing.Point(154, 683);
            this.ULLabel.Name = "ULLabel";
            this.ULLabel.Size = new System.Drawing.Size(64, 13);
            this.ULLabel.TabIndex = 87;
            this.ULLabel.Text = "Uploading";
            this.ULLabel.Visible = false;
            // 
            // ULGif
            // 
            this.ULGif.Enabled = false;
            this.ULGif.Location = new System.Drawing.Point(178, 699);
            this.ULGif.Name = "ULGif";
            this.ULGif.Size = new System.Drawing.Size(34, 17);
            this.ULGif.TabIndex = 86;
            this.ULGif.TabStop = false;
            this.ULGif.Visible = false;
            // 
            // BatteryLbl
            // 
            this.BatteryLbl.AutoSize = true;
            this.BatteryLbl.BackColor = System.Drawing.Color.Transparent;
            this.BatteryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatteryLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BatteryLbl.Location = new System.Drawing.Point(167, 602);
            this.BatteryLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BatteryLbl.Name = "BatteryLbl";
            this.BatteryLbl.Size = new System.Drawing.Size(0, 13);
            this.BatteryLbl.TabIndex = 84;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::AndroidSideloader.Properties.Resources.battery11;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox5.Location = new System.Drawing.Point(163, 596);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(55, 29);
            this.pictureBox5.TabIndex = 85;
            this.pictureBox5.TabStop = false;
            // 
            // downloadingLabel
            // 
            this.downloadingLabel.AutoSize = true;
            this.downloadingLabel.BackColor = System.Drawing.SystemColors.WindowText;
            this.downloadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.downloadingLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.downloadingLabel.Location = new System.Drawing.Point(-3, 688);
            this.downloadingLabel.Name = "downloadingLabel";
            this.downloadingLabel.Size = new System.Drawing.Size(0, 18);
            this.downloadingLabel.TabIndex = 83;
            // 
            // aboutBtn
            // 
            this.aboutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.aboutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutBtn.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.aboutBtn.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.aboutBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.aboutBtn.FlatAppearance.BorderSize = 0;
            this.aboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutBtn.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.aboutBtn.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.aboutBtn.Location = new System.Drawing.Point(0, 563);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(221, 28);
            this.aboutBtn.TabIndex = 5;
            this.aboutBtn.Text = " ?   ABOUT";
            this.aboutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutBtn.UseVisualStyleBackColor = false;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.settingsButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.settingsButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.settingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.Location = new System.Drawing.Point(0, 535);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(221, 28);
            this.settingsButton.TabIndex = 4;
            this.settingsButton.Text = "⚙ SETTINGS";
            this.settingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // otherContainer
            // 
            this.otherContainer.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.otherContainer.Controls.Add(this.InstallQUset);
            this.otherContainer.Controls.Add(this.removeQUSetting);
            this.otherContainer.Controls.Add(this.QuestOptionsButton);
            this.otherContainer.Controls.Add(this.ADBWirelessDisable);
            this.otherContainer.Controls.Add(this.ADBWirelessEnable);
            this.otherContainer.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.otherContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.otherContainer.Location = new System.Drawing.Point(0, 394);
            this.otherContainer.Margin = new System.Windows.Forms.Padding(2);
            this.otherContainer.Name = "otherContainer";
            this.otherContainer.Size = new System.Drawing.Size(221, 141);
            this.otherContainer.TabIndex = 80;
            // 
            // InstallQUset
            // 
            this.InstallQUset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.InstallQUset.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InstallQUset.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InstallQUset.Dock = System.Windows.Forms.DockStyle.Top;
            this.InstallQUset.FlatAppearance.BorderSize = 0;
            this.InstallQUset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InstallQUset.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.InstallQUset.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.InstallQUset.Location = new System.Drawing.Point(0, 112);
            this.InstallQUset.Name = "InstallQUset";
            this.InstallQUset.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.InstallQUset.Size = new System.Drawing.Size(221, 28);
            this.InstallQUset.TabIndex = 5;
            this.InstallQUset.Text = "Install QU Setting";
            this.InstallQUset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InstallQUset.UseVisualStyleBackColor = false;
            this.InstallQUset.Click += new System.EventHandler(this.InstallQUset_Click);
            // 
            // removeQUSetting
            // 
            this.removeQUSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.removeQUSetting.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.removeQUSetting.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.removeQUSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.removeQUSetting.FlatAppearance.BorderSize = 0;
            this.removeQUSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeQUSetting.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.removeQUSetting.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.removeQUSetting.Location = new System.Drawing.Point(0, 84);
            this.removeQUSetting.Name = "removeQUSetting";
            this.removeQUSetting.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.removeQUSetting.Size = new System.Drawing.Size(221, 28);
            this.removeQUSetting.TabIndex = 4;
            this.removeQUSetting.Text = "Remove QU Setting";
            this.removeQUSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeQUSetting.UseVisualStyleBackColor = false;
            this.removeQUSetting.Click += new System.EventHandler(this.removeQUSetting_Click);
            // 
            // QuestOptionsButton
            // 
            this.QuestOptionsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.QuestOptionsButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.QuestOptionsButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.QuestOptionsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.QuestOptionsButton.FlatAppearance.BorderSize = 0;
            this.QuestOptionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuestOptionsButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.QuestOptionsButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.QuestOptionsButton.Location = new System.Drawing.Point(0, 56);
            this.QuestOptionsButton.Name = "QuestOptionsButton";
            this.QuestOptionsButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.QuestOptionsButton.Size = new System.Drawing.Size(221, 28);
            this.QuestOptionsButton.TabIndex = 2;
            this.QuestOptionsButton.Text = "Quest Options";
            this.QuestOptionsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.QuestOptionsButton.UseVisualStyleBackColor = false;
            this.QuestOptionsButton.Click += new System.EventHandler(this.QuestOptionsButton_Click);
            // 
            // ADBWirelessDisable
            // 
            this.ADBWirelessDisable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ADBWirelessDisable.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ADBWirelessDisable.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ADBWirelessDisable.Dock = System.Windows.Forms.DockStyle.Top;
            this.ADBWirelessDisable.FlatAppearance.BorderSize = 0;
            this.ADBWirelessDisable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ADBWirelessDisable.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.ADBWirelessDisable.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.ADBWirelessDisable.Location = new System.Drawing.Point(0, 28);
            this.ADBWirelessDisable.Name = "ADBWirelessDisable";
            this.ADBWirelessDisable.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ADBWirelessDisable.Size = new System.Drawing.Size(221, 28);
            this.ADBWirelessDisable.TabIndex = 1;
            this.ADBWirelessDisable.Text = "Disable Wireless ADB";
            this.ADBWirelessDisable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ADBWirelessDisable.UseVisualStyleBackColor = false;
            this.ADBWirelessDisable.Click += new System.EventHandler(this.ADBWirelessDisable_Click);
            // 
            // ADBWirelessEnable
            // 
            this.ADBWirelessEnable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ADBWirelessEnable.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ADBWirelessEnable.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ADBWirelessEnable.Dock = System.Windows.Forms.DockStyle.Top;
            this.ADBWirelessEnable.FlatAppearance.BorderSize = 0;
            this.ADBWirelessEnable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ADBWirelessEnable.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.ADBWirelessEnable.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.ADBWirelessEnable.Location = new System.Drawing.Point(0, 0);
            this.ADBWirelessEnable.Name = "ADBWirelessEnable";
            this.ADBWirelessEnable.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ADBWirelessEnable.Size = new System.Drawing.Size(221, 28);
            this.ADBWirelessEnable.TabIndex = 0;
            this.ADBWirelessEnable.Text = "Enable  Wireless ADB";
            this.ADBWirelessEnable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ADBWirelessEnable.UseVisualStyleBackColor = false;
            this.ADBWirelessEnable.Click += new System.EventHandler(this.ADBWirelessEnable_Click);
            // 
            // otherDrop
            // 
            this.otherDrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.otherDrop.BackgroundImage = global::AndroidSideloader.Properties.Resources.pattern_herringbone_2_1_3_0_0_90_1__000000_1c1c1c;
            this.otherDrop.Cursor = System.Windows.Forms.Cursors.Default;
            this.otherDrop.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.otherDrop.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.otherDrop.Dock = System.Windows.Forms.DockStyle.Top;
            this.otherDrop.FlatAppearance.BorderSize = 0;
            this.otherDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.otherDrop.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.otherDrop.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.otherDrop.Location = new System.Drawing.Point(0, 366);
            this.otherDrop.Margin = new System.Windows.Forms.Padding(2);
            this.otherDrop.Name = "otherDrop";
            this.otherDrop.Size = new System.Drawing.Size(221, 28);
            this.otherDrop.TabIndex = 3;
            this.otherDrop.Text = "▶ OTHER ◀";
            this.otherDrop.UseVisualStyleBackColor = false;
            this.otherDrop.Click += new System.EventHandler(this.otherDrop_Click);
            // 
            // backupContainer
            // 
            this.backupContainer.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.backupContainer.Controls.Add(this.backupbutton);
            this.backupContainer.Controls.Add(this.restorebutton);
            this.backupContainer.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.backupContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.backupContainer.Location = new System.Drawing.Point(0, 310);
            this.backupContainer.Margin = new System.Windows.Forms.Padding(2);
            this.backupContainer.Name = "backupContainer";
            this.backupContainer.Size = new System.Drawing.Size(221, 56);
            this.backupContainer.TabIndex = 76;
            // 
            // backupDrop
            // 
            this.backupDrop.BackColor = global::AndroidSideloader.Properties.Settings.Default.ButtonColor;
            this.backupDrop.BackgroundImage = global::AndroidSideloader.Properties.Resources.pattern_herringbone_2_1_3_0_0_90_1__000000_1c1c1c;
            this.backupDrop.Cursor = System.Windows.Forms.Cursors.Default;
            this.backupDrop.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.backupDrop.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.backupDrop.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.backupDrop.Dock = System.Windows.Forms.DockStyle.Top;
            this.backupDrop.FlatAppearance.BorderSize = 0;
            this.backupDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backupDrop.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.backupDrop.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.backupDrop.Location = new System.Drawing.Point(0, 282);
            this.backupDrop.Margin = new System.Windows.Forms.Padding(2);
            this.backupDrop.Name = "backupDrop";
            this.backupDrop.Size = new System.Drawing.Size(221, 28);
            this.backupDrop.TabIndex = 2;
            this.backupDrop.Text = "▶ BACKUP / RESTORE ◀";
            this.backupDrop.UseVisualStyleBackColor = false;
            this.backupDrop.Click += new System.EventHandler(this.backupDrop_Click);
            // 
            // sideloadContainer
            // 
            this.sideloadContainer.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.sideloadContainer.Controls.Add(this.UpdateGamesButton);
            this.sideloadContainer.Controls.Add(this.listApkButton);
            this.sideloadContainer.Controls.Add(this.startsideloadbutton);
            this.sideloadContainer.Controls.Add(this.pullAppToDesktopBtn);
            this.sideloadContainer.Controls.Add(this.uninstallAppButton);
            this.sideloadContainer.Controls.Add(this.getApkButton);
            this.sideloadContainer.Controls.Add(this.copyBulkObbButton);
            this.sideloadContainer.Controls.Add(this.obbcopybutton);
            this.sideloadContainer.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.sideloadContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideloadContainer.Location = new System.Drawing.Point(0, 56);
            this.sideloadContainer.Margin = new System.Windows.Forms.Padding(2);
            this.sideloadContainer.Name = "sideloadContainer";
            this.sideloadContainer.Size = new System.Drawing.Size(221, 226);
            this.sideloadContainer.TabIndex = 74;
            // 
            // UpdateGamesButton
            // 
            this.UpdateGamesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.UpdateGamesButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.UpdateGamesButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.UpdateGamesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpdateGamesButton.FlatAppearance.BorderSize = 0;
            this.UpdateGamesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateGamesButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.UpdateGamesButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.UpdateGamesButton.Location = new System.Drawing.Point(0, 196);
            this.UpdateGamesButton.Name = "UpdateGamesButton";
            this.UpdateGamesButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.UpdateGamesButton.Size = new System.Drawing.Size(221, 29);
            this.UpdateGamesButton.TabIndex = 7;
            this.UpdateGamesButton.Text = "Refresh Update List";
            this.UpdateGamesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateGamesButton.UseVisualStyleBackColor = false;
            this.UpdateGamesButton.Click += new System.EventHandler(this.UpdateGamesButton_Click);
            // 
            // listApkButton
            // 
            this.listApkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.listApkButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.listApkButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.listApkButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.listApkButton.FlatAppearance.BorderSize = 0;
            this.listApkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listApkButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.listApkButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.listApkButton.Location = new System.Drawing.Point(0, 168);
            this.listApkButton.Name = "listApkButton";
            this.listApkButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.listApkButton.Size = new System.Drawing.Size(221, 28);
            this.listApkButton.TabIndex = 6;
            this.listApkButton.Text = "Refresh All";
            this.listApkButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listApkButton.UseVisualStyleBackColor = false;
            this.listApkButton.Click += new System.EventHandler(this.listApkButton_Click);
            // 
            // sideloadDrop
            // 
            this.sideloadDrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.sideloadDrop.BackgroundImage = global::AndroidSideloader.Properties.Resources.pattern_herringbone_2_1_3_0_0_90_1__000000_1c1c1c;
            this.sideloadDrop.Cursor = System.Windows.Forms.Cursors.Default;
            this.sideloadDrop.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.sideloadDrop.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.sideloadDrop.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideloadDrop.FlatAppearance.BorderSize = 0;
            this.sideloadDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideloadDrop.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.sideloadDrop.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.sideloadDrop.Location = new System.Drawing.Point(0, 28);
            this.sideloadDrop.Margin = new System.Windows.Forms.Padding(2);
            this.sideloadDrop.Name = "sideloadDrop";
            this.sideloadDrop.Size = new System.Drawing.Size(221, 28);
            this.sideloadDrop.TabIndex = 1;
            this.sideloadDrop.Text = "▶ SIDELOAD ◀";
            this.sideloadDrop.UseVisualStyleBackColor = false;
            this.sideloadDrop.Click += new System.EventHandler(this.sideloadContainer_Click);
            // 
            // diskLabel
            // 
            this.diskLabel.AutoSize = true;
            this.diskLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.diskLabel.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.diskLabel.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.diskLabel.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.diskLabel.Location = new System.Drawing.Point(4, 597);
            this.diskLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.diskLabel.Name = "diskLabel";
            this.diskLabel.Size = new System.Drawing.Size(77, 18);
            this.diskLabel.TabIndex = 7;
            this.diskLabel.Text = "Disk Label";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.BackColor = System.Drawing.Color.Transparent;
            this.speedLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.speedLabel.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.speedLabel.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.speedLabel.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.speedLabel.Location = new System.Drawing.Point(225, 452);
            this.speedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(149, 18);
            this.speedLabel.TabIndex = 76;
            this.speedLabel.Text = "DLS: Speed in MBPS";
            // 
            // etaLabel
            // 
            this.etaLabel.AutoSize = true;
            this.etaLabel.BackColor = System.Drawing.Color.Transparent;
            this.etaLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.etaLabel.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.etaLabel.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.etaLabel.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.etaLabel.Location = new System.Drawing.Point(502, 452);
            this.etaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.etaLabel.Name = "etaLabel";
            this.etaLabel.Size = new System.Drawing.Size(148, 18);
            this.etaLabel.TabIndex = 75;
            this.etaLabel.Text = "ETA: HH:MM:SS Left";
            // 
            // freeDisclaimer
            // 
            this.freeDisclaimer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.freeDisclaimer.AutoSize = true;
            this.freeDisclaimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.freeDisclaimer.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.freeDisclaimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freeDisclaimer.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.freeDisclaimer.Location = new System.Drawing.Point(289, 556);
            this.freeDisclaimer.Name = "freeDisclaimer";
            this.freeDisclaimer.Size = new System.Drawing.Size(246, 40);
            this.freeDisclaimer.TabIndex = 79;
            this.freeDisclaimer.Text = "This app is FREE!! \r\nClick here to go to the github.";
            this.freeDisclaimer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.freeDisclaimer.Click += new System.EventHandler(this.freeDisclaimer_Click);
            // 
            // gamesQueListBox
            // 
            this.gamesQueListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gamesQueListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gamesQueListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gamesQueListBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.gamesQueListBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.gamesQueListBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.gamesQueListBox.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.gamesQueListBox.FormattingEnabled = true;
            this.gamesQueListBox.ItemHeight = 18;
            this.gamesQueListBox.Location = new System.Drawing.Point(601, 475);
            this.gamesQueListBox.Margin = new System.Windows.Forms.Padding(2);
            this.gamesQueListBox.Name = "gamesQueListBox";
            this.gamesQueListBox.Size = new System.Drawing.Size(421, 128);
            this.gamesQueListBox.TabIndex = 9;
            this.gamesQueListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gamesQueListBox_MouseClick);
            this.gamesQueListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.gamesQueListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            // 
            // devicesComboBox
            // 
            this.devicesComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.devicesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.devicesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.devicesComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.devicesComboBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.devicesComboBox.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.devicesComboBox.FormattingEnabled = true;
            this.devicesComboBox.Location = new System.Drawing.Point(224, 39);
            this.devicesComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.devicesComboBox.Name = "devicesComboBox";
            this.devicesComboBox.Size = new System.Drawing.Size(164, 26);
            this.devicesComboBox.TabIndex = 1;
            this.devicesComboBox.Text = "Select your device";
            this.devicesComboBox.SelectedIndexChanged += new System.EventHandler(this.devicesComboBox_SelectedIndexChanged);
            // 
            // remotesList
            // 
            this.remotesList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.remotesList.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.remotesList.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.remotesList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remotesList.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.remotesList.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.remotesList.FormattingEnabled = true;
            this.remotesList.Location = new System.Drawing.Point(545, 40);
            this.remotesList.Margin = new System.Windows.Forms.Padding(2);
            this.remotesList.Name = "remotesList";
            this.remotesList.Size = new System.Drawing.Size(53, 26);
            this.remotesList.TabIndex = 3;
            this.remotesList.SelectedIndexChanged += new System.EventHandler(this.remotesList_SelectedIndexChanged);
            // 
            // gamesListView
            // 
            this.gamesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gamesListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gamesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.GameNameIndex,
            this.ReleaseNameIndex,
            this.PackageNameIndex,
            this.VersionCodeIndex,
            this.ReleaseAPKPathIndex,
            this.VersionNameIndex});
            this.gamesListView.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.gamesListView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamesListView.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.gamesListView.HideSelection = false;
            this.gamesListView.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.gamesListView.Location = new System.Drawing.Point(224, 70);
            this.gamesListView.Name = "gamesListView";
            this.gamesListView.ShowGroups = false;
            this.gamesListView.Size = new System.Drawing.Size(798, 360);
            this.gamesListView.TabIndex = 6;
            this.gamesListView.UseCompatibleStateImageBehavior = false;
            this.gamesListView.View = System.Windows.Forms.View.Details;
            this.gamesListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.gamesListView.SelectedIndexChanged += new System.EventHandler(this.gamesListView_SelectedIndexChanged);
            this.gamesListView.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.gamesListView.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.gamesListView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gamesListView_KeyPress);
            this.gamesListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gamesListView_MouseDoubleClick);
            // 
            // GameNameIndex
            // 
            this.GameNameIndex.Text = "Game Name";
            this.GameNameIndex.Width = 159;
            // 
            // ReleaseNameIndex
            // 
            this.ReleaseNameIndex.Text = "Release Name";
            this.ReleaseNameIndex.Width = 244;
            // 
            // PackageNameIndex
            // 
            this.PackageNameIndex.Text = "Package Name";
            this.PackageNameIndex.Width = 87;
            // 
            // VersionCodeIndex
            // 
            this.VersionCodeIndex.Text = "Version";
            this.VersionCodeIndex.Width = 75;
            // 
            // ReleaseAPKPathIndex
            // 
            this.ReleaseAPKPathIndex.Text = "Last Updated";
            this.ReleaseAPKPathIndex.Width = 145;
            // 
            // VersionNameIndex
            // 
            this.VersionNameIndex.Text = "Size (MB)";
            this.VersionNameIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.VersionNameIndex.Width = 66;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.BackColor = global::AndroidSideloader.Properties.Settings.Default.TextBoxColor;
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextBox.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "TextBoxColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.searchTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.searchTextBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.searchTextBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.searchTextBox.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.searchTextBox.Location = new System.Drawing.Point(484, 250);
            this.searchTextBox.MaximumSize = new System.Drawing.Size(231, 26);
            this.searchTextBox.MinimumSize = new System.Drawing.Size(231, 26);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(231, 24);
            this.searchTextBox.TabIndex = 5;
            this.searchTextBox.Text = "Search";
            this.searchTextBox.Visible = false;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            this.searchTextBox.Leave += new System.EventHandler(this.searchTextBox_Leave);
            // 
            // gamesQueueLabel
            // 
            this.gamesQueueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gamesQueueLabel.AutoSize = true;
            this.gamesQueueLabel.BackColor = System.Drawing.Color.Transparent;
            this.gamesQueueLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.gamesQueueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.gamesQueueLabel.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.gamesQueueLabel.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.gamesQueueLabel.Location = new System.Drawing.Point(599, 586);
            this.gamesQueueLabel.Name = "gamesQueueLabel";
            this.gamesQueueLabel.Size = new System.Drawing.Size(52, 18);
            this.gamesQueueLabel.TabIndex = 86;
            this.gamesQueueLabel.Text = "Queue";
            // 
            // ProgressText
            // 
            this.ProgressText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProgressText.AutoSize = true;
            this.ProgressText.BackColor = System.Drawing.Color.Transparent;
            this.ProgressText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressText.ForeColor = System.Drawing.Color.White;
            this.ProgressText.Location = new System.Drawing.Point(225, 692);
            this.ProgressText.Name = "ProgressText";
            this.ProgressText.Size = new System.Drawing.Size(0, 18);
            this.ProgressText.TabIndex = 88;
            // 
            // notesRichTextBox
            // 
            this.notesRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notesRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.notesRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notesRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.notesRichTextBox.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.notesRichTextBox.HideSelection = false;
            this.notesRichTextBox.Location = new System.Drawing.Point(601, 622);
            this.notesRichTextBox.Name = "notesRichTextBox";
            this.notesRichTextBox.ReadOnly = true;
            this.notesRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.notesRichTextBox.ShowSelectionMargin = true;
            this.notesRichTextBox.Size = new System.Drawing.Size(421, 66);
            this.notesRichTextBox.TabIndex = 10;
            this.notesRichTextBox.Text = "\n\n\n                                     TIP: PRESS F1 TO SEE A LIST OF SHORTCUTS";
            // 
            // DragDropLbl
            // 
            this.DragDropLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DragDropLbl.AutoSize = true;
            this.DragDropLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DragDropLbl.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DragDropLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DragDropLbl.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.DragDropLbl.Location = new System.Drawing.Point(602, 509);
            this.DragDropLbl.Name = "DragDropLbl";
            this.DragDropLbl.Size = new System.Drawing.Size(320, 55);
            this.DragDropLbl.TabIndex = 25;
            this.DragDropLbl.Text = "DragDropLBL";
            this.DragDropLbl.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.label1.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.label1.Location = new System.Drawing.Point(597, 674);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 86;
            this.label1.Text = "Notes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", global::AndroidSideloader.Properties.Settings.Default, "BackPicturePath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.ImageLocation = global::AndroidSideloader.Properties.Settings.Default.BackPicturePath;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(218, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(819, 751);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.updateAvailable_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label2.Location = new System.Drawing.Point(464, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 120);
            this.label2.TabIndex = 89;
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(516, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 51);
            this.label3.TabIndex = 90;
            this.label3.Text = "Start typing to search.\r\nPress ESC to close.\r\n\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(509, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 17);
            this.label4.TabIndex = 90;
            this.label4.Text = "Shortcuts: CTRL+F or F2";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(738, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 90;
            this.label5.Text = "Quick Search";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUpdateAvailable
            // 
            this.lblUpdateAvailable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUpdateAvailable.AutoSize = true;
            this.lblUpdateAvailable.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdateAvailable.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateAvailable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUpdateAvailable.Location = new System.Drawing.Point(878, 24);
            this.lblUpdateAvailable.Name = "lblUpdateAvailable";
            this.lblUpdateAvailable.Size = new System.Drawing.Size(151, 20);
            this.lblUpdateAvailable.TabIndex = 90;
            this.lblUpdateAvailable.Text = "𝖴𝖯𝖣𝖠𝖳𝖤 𝖠𝖵𝖠𝖨𝖫𝖠𝖡𝖫𝖤";
            this.lblUpdateAvailable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblUpdateAvailable.Click += new System.EventHandler(this.updateAvailable_Click);
            // 
            // lblUpToDate
            // 
            this.lblUpToDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUpToDate.AutoSize = true;
            this.lblUpToDate.BackColor = System.Drawing.Color.Transparent;
            this.lblUpToDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpToDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUpToDate.Location = new System.Drawing.Point(878, 6);
            this.lblUpToDate.Name = "lblUpToDate";
            this.lblUpToDate.Size = new System.Drawing.Size(96, 20);
            this.lblUpToDate.TabIndex = 90;
            this.lblUpToDate.Text = "𝖴𝖯 𝖳𝖮 𝖣𝖠𝖳𝖤";
            this.lblUpToDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMirror
            // 
            this.lblMirror.AutoSize = true;
            this.lblMirror.BackColor = System.Drawing.Color.Transparent;
            this.lblMirror.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblMirror.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMirror.Location = new System.Drawing.Point(475, 44);
            this.lblMirror.Name = "lblMirror";
            this.lblMirror.Size = new System.Drawing.Size(65, 17);
            this.lblMirror.TabIndex = 90;
            this.lblMirror.Text = "Mirror #";
            this.lblMirror.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EnterInstallBox
            // 
            this.EnterInstallBox.AutoSize = true;
            this.EnterInstallBox.BackColor = System.Drawing.Color.Transparent;
            this.EnterInstallBox.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EnterInstallBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.EnterInstallBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.EnterInstallBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EnterInstallBox.Location = new System.Drawing.Point(635, 8);
            this.EnterInstallBox.Name = "EnterInstallBox";
            this.EnterInstallBox.Size = new System.Drawing.Size(80, 54);
            this.EnterInstallBox.TabIndex = 93;
            this.EnterInstallBox.Text = "  Install w/ \r\n Enter Key";
            this.EnterInstallBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EnterInstallBox.UseVisualStyleBackColor = false;
            this.EnterInstallBox.CheckedChanged += new System.EventHandler(this.EnterInstallBox_CheckedChanged);
            // 
            // ADBcommandbox
            // 
            this.ADBcommandbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ADBcommandbox.BackColor = global::AndroidSideloader.Properties.Settings.Default.TextBoxColor;
            this.ADBcommandbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ADBcommandbox.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "TextBoxColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ADBcommandbox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ADBcommandbox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ADBcommandbox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.ADBcommandbox.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.ADBcommandbox.Location = new System.Drawing.Point(484, 250);
            this.ADBcommandbox.MaximumSize = new System.Drawing.Size(231, 26);
            this.ADBcommandbox.MinimumSize = new System.Drawing.Size(231, 26);
            this.ADBcommandbox.Name = "ADBcommandbox";
            this.ADBcommandbox.Size = new System.Drawing.Size(231, 24);
            this.ADBcommandbox.TabIndex = 5;
            this.ADBcommandbox.Visible = false;
            this.ADBcommandbox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            this.ADBcommandbox.Enter += new System.EventHandler(this.ADBcommandbox_Enter);
            this.ADBcommandbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ADBcommandbox_KeyPress);
            this.ADBcommandbox.Leave += new System.EventHandler(this.ADBcommandbox_Leave);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(528, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 17);
            this.label11.TabIndex = 90;
            this.label11.Text = "Shorcut = CTRL+R";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label11.Visible = false;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(514, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 68);
            this.label9.TabIndex = 90;
            this.label9.Text = "Type command without\r\n\"adb\" prefix.\r\n\r\n\r\n";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Visible = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", global::AndroidSideloader.Properties.Settings.Default, "BackPicturePath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pictureBox7.ErrorImage = null;
            this.pictureBox7.ImageLocation = global::AndroidSideloader.Properties.Settings.Default.BackPicturePath;
            this.pictureBox7.InitialImage = null;
            this.pictureBox7.Location = new System.Drawing.Point(217, 18);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(819, 718);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 74;
            this.pictureBox7.TabStop = false;
            // 
            // lblNeedsDonate
            // 
            this.lblNeedsDonate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNeedsDonate.AutoSize = true;
            this.lblNeedsDonate.BackColor = System.Drawing.Color.Transparent;
            this.lblNeedsDonate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeedsDonate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNeedsDonate.Location = new System.Drawing.Point(878, 43);
            this.lblNeedsDonate.Name = "lblNeedsDonate";
            this.lblNeedsDonate.Size = new System.Drawing.Size(142, 20);
            this.lblNeedsDonate.TabIndex = 90;
            this.lblNeedsDonate.Text = "𝖭𝖤𝖶𝖤𝖱 𝖳𝖧𝖠𝖭 𝖫𝖨𝖲𝖳";
            this.lblNeedsDonate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::AndroidSideloader.Properties.Resources.SearchGlass;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(773, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 91;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // gamesPictureBox
            // 
            this.gamesPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gamesPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gamesPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gamesPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gamesPictureBox.Location = new System.Drawing.Point(224, 475);
            this.gamesPictureBox.Name = "gamesPictureBox";
            this.gamesPictureBox.Size = new System.Drawing.Size(374, 214);
            this.gamesPictureBox.TabIndex = 84;
            this.gamesPictureBox.TabStop = false;
            this.gamesPictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.gamesPictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            // 
            // MountButton
            // 
            this.MountButton.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MountButton.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.MountButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MountButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.MountButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MountButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MountButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MountButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.MountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.MountButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.MountButton.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.MountButton.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.MountButton.Location = new System.Drawing.Point(393, 39);
            this.MountButton.Name = "MountButton";
            this.MountButton.Radius = 5;
            this.MountButton.Size = new System.Drawing.Size(76, 26);
            this.MountButton.Stroke = true;
            this.MountButton.StrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.MountButton.TabIndex = 95;
            this.MountButton.Text = "MOUNT";
            this.MountButton.Transparency = false;
            this.MountButton.Click += new System.EventHandler(this.MountButton_Click);
            this.MountButton.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            // 
            // downloadInstallGameButton
            // 
            this.downloadInstallGameButton.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.downloadInstallGameButton.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.downloadInstallGameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadInstallGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.downloadInstallGameButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.downloadInstallGameButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.downloadInstallGameButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.downloadInstallGameButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.downloadInstallGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.downloadInstallGameButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.downloadInstallGameButton.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.downloadInstallGameButton.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.downloadInstallGameButton.Location = new System.Drawing.Point(654, 436);
            this.downloadInstallGameButton.Margin = new System.Windows.Forms.Padding(0);
            this.downloadInstallGameButton.Name = "downloadInstallGameButton";
            this.downloadInstallGameButton.Radius = 5;
            this.downloadInstallGameButton.Size = new System.Drawing.Size(369, 34);
            this.downloadInstallGameButton.Stroke = true;
            this.downloadInstallGameButton.StrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.downloadInstallGameButton.TabIndex = 94;
            this.downloadInstallGameButton.Text = "Download and Install Game/Add To Queue ⮩ ";
            this.downloadInstallGameButton.Transparency = false;
            this.downloadInstallGameButton.Click += new System.EventHandler(this.downloadInstallGameButton_Click);
            this.downloadInstallGameButton.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.downloadInstallGameButton.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::AndroidSideloader.Properties.Settings.Default.BackColor;
            this.BackgroundImage = global::AndroidSideloader.Properties.Resources.pattern_cubes_1_1_1_0_0_0_1__000000_212121;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1032, 721);
            this.Controls.Add(this.MountButton);
            this.Controls.Add(this.downloadInstallGameButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EnterInstallBox);
            this.Controls.Add(this.ProgressText);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblNeedsDonate);
            this.Controls.Add(this.lblUpToDate);
            this.Controls.Add(this.lblUpdateAvailable);
            this.Controls.Add(this.lblMirror);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ADBcommandbox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.freeDisclaimer);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.DragDropLbl);
            this.Controls.Add(this.etaLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gamesQueueLabel);
            this.Controls.Add(this.gamesPictureBox);
            this.Controls.Add(this.remotesList);
            this.Controls.Add(this.devicesComboBox);
            this.Controls.Add(this.gamesQueListBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.m_combo);
            this.Controls.Add(this.notesRichTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gamesListView);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox7);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rookie\'s Sideloader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.DragLeave += new System.EventHandler(this.Form1_DragLeave);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ULGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.otherContainer.ResumeLayout(false);
            this.backupContainer.ResumeLayout(false);
            this.sideloadContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startsideloadbutton;
        private System.Windows.Forms.Button devicesbutton;
        private System.Windows.Forms.Button obbcopybutton;
        private System.Windows.Forms.Button backupbutton;
        private System.Windows.Forms.Button restorebutton;
        private System.Windows.Forms.Button getApkButton;
        private SergeUtils.EasyCompletionComboBox m_combo;
        private System.Windows.Forms.Button uninstallAppButton;
        private System.Windows.Forms.Button pullAppToDesktopBtn;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button copyBulkObbButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel backupContainer;
        private System.Windows.Forms.Button backupDrop;
        private System.Windows.Forms.Panel sideloadContainer;
        private System.Windows.Forms.Button sideloadDrop;
        private System.Windows.Forms.Button listApkButton;
        private System.Windows.Forms.Label etaLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label diskLabel;
        private System.Windows.Forms.Button otherDrop;
        private System.Windows.Forms.Panel otherContainer;
        private System.Windows.Forms.Button ADBWirelessEnable;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button ADBWirelessDisable;
        private System.Windows.Forms.Label freeDisclaimer;
        private System.Windows.Forms.ComboBox devicesComboBox;
        private System.Windows.Forms.Button QuestOptionsButton;
        private System.Windows.Forms.ListBox gamesQueListBox;
        private System.Windows.Forms.ListView gamesListView;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.PictureBox gamesPictureBox;
        private System.Windows.Forms.Button UpdateGamesButton;
        private System.Windows.Forms.Label gamesQueueLabel;
        private System.Windows.Forms.Label ProgressText;
        private System.Windows.Forms.Label downloadingLabel;
        private System.Windows.Forms.RichTextBox notesRichTextBox;
        private System.Windows.Forms.Label DragDropLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeQUSetting;
        private System.Windows.Forms.Button InstallQUset;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblUpdateAvailable;
        private System.Windows.Forms.Label lblUpToDate;
        private System.Windows.Forms.Label lblMirror;
        private System.Windows.Forms.CheckBox EnterInstallBox;
        private System.Windows.Forms.TextBox ADBcommandbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label BatteryLbl;
        private System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.ComboBox remotesList;
        private System.Windows.Forms.PictureBox ULGif;
        private System.Windows.Forms.Label ULLabel;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblNeedsDonate;
        public System.Windows.Forms.ColumnHeader GameNameIndex;
        public System.Windows.Forms.ColumnHeader ReleaseNameIndex;
        private System.Windows.Forms.ColumnHeader PackageNameIndex;
        private System.Windows.Forms.ColumnHeader VersionCodeIndex;
        private System.Windows.Forms.ColumnHeader ReleaseAPKPathIndex;
        public System.Windows.Forms.ColumnHeader VersionNameIndex;
        private ToolTip startsideloadbutton_Tooltip;
        private ToolTip devicesbutton_Tooltip;
        private ToolTip obbcopybutton_Tooltip;
        private ToolTip backupbutton_Tooltip;
        private ToolTip restorebutton_Tooltip;
        private ToolTip getApkButton_Tooltip;
        private ToolTip uninstallAppButton_Tooltip;
        private ToolTip pullAppToDesktopBtn_Tooltip;
        private ToolTip copyBulkObbButton_Tooltip;
        private ToolTip downloadInstallGameButton_Tooltip;
        private ToolTip aboutBtn_Tooltip;
        private ToolTip settingsButton_Tooltip;
        private ToolTip InstallQUset_Tooltip;
        private ToolTip removeQUSetting_Tooltip;
        private ToolTip QuestOptionsButton_Tooltip;
        private ToolTip ADBWirelessDisable_Tooltip;
        private ToolTip ADBWirelessEnable_Tooltip;
        private ToolTip UpdateGamesButton_Tooltip;
        private ToolTip listApkButton_Tooltip;
        private ToolTip speedLabel_Tooltip;
        private ToolTip etaLabel_Tooltip;
        private ToolTip MountButton_Tooltip;
        private ToolTip EnterInstallBox_Tooltip;
        private Label verLabel;
        private RoundButton downloadInstallGameButton;
        private RoundButton MountButton;
    }
}
