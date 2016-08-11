﻿namespace JNSoundboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.cbPlaybackDevices = new System.Windows.Forms.ComboBox();
            this.cbEnable = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnTTS = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvKeySounds = new System.Windows.Forms.ListView();
            this.chKeys = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSoundLoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnReloadDevices = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLoopbackDevices = new System.Windows.Forms.ComboBox();
            this.llBitcoinAddress = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Playback device";
            // 
            // cbPlaybackDevices
            // 
            this.cbPlaybackDevices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbPlaybackDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlaybackDevices.FormattingEnabled = true;
            this.cbPlaybackDevices.Location = new System.Drawing.Point(108, 393);
            this.cbPlaybackDevices.Name = "cbPlaybackDevices";
            this.cbPlaybackDevices.Size = new System.Drawing.Size(240, 21);
            this.cbPlaybackDevices.TabIndex = 8;
            this.cbPlaybackDevices.SelectedIndexChanged += new System.EventHandler(this.cbPlaybackDevices_SelectedIndexChanged);
            // 
            // cbEnable
            // 
            this.cbEnable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEnable.AutoSize = true;
            this.cbEnable.Location = new System.Drawing.Point(511, 370);
            this.cbEnable.Name = "cbEnable";
            this.cbEnable.Size = new System.Drawing.Size(59, 17);
            this.cbEnable.TabIndex = 12;
            this.cbEnable.Text = "Enable";
            this.cbEnable.UseVisualStyleBackColor = true;
            this.cbEnable.CheckedChanged += new System.EventHandler(this.cbEnable_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnTTS
            // 
            this.btnTTS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTTS.Location = new System.Drawing.Point(484, 393);
            this.btnTTS.Name = "btnTTS";
            this.btnTTS.Size = new System.Drawing.Size(86, 23);
            this.btnTTS.TabIndex = 11;
            this.btnTTS.Text = "Text-to-speech";
            this.btnTTS.UseVisualStyleBackColor = true;
            this.btnTTS.Click += new System.EventHandler(this.btnTTS_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(167, 345);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(495, 187);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 72);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(495, 107);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 72);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(495, 27);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 72);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvKeySounds
            // 
            this.lvKeySounds.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lvKeySounds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvKeySounds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chKeys,
            this.chSoundLoc});
            this.lvKeySounds.FullRowSelect = true;
            this.lvKeySounds.GridLines = true;
            this.lvKeySounds.Location = new System.Drawing.Point(12, 27);
            this.lvKeySounds.MultiSelect = false;
            this.lvKeySounds.Name = "lvKeySounds";
            this.lvKeySounds.Size = new System.Drawing.Size(477, 312);
            this.lvKeySounds.TabIndex = 0;
            this.lvKeySounds.UseCompatibleStateImageBehavior = false;
            this.lvKeySounds.View = System.Windows.Forms.View.Details;
            this.lvKeySounds.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvKeySounds_MouseDoubleClick);
            // 
            // chKeys
            // 
            this.chKeys.Text = "Keys";
            this.chKeys.Width = 150;
            // 
            // chSoundLoc
            // 
            this.chSoundLoc.Text = "Sound location";
            this.chSoundLoc.Width = 300;
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoad.Location = new System.Drawing.Point(12, 345);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(145, 23);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnReloadDevices
            // 
            this.btnReloadDevices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReloadDevices.Image = ((System.Drawing.Image)(resources.GetObject("btnReloadDevices.Image")));
            this.btnReloadDevices.Location = new System.Drawing.Point(354, 419);
            this.btnReloadDevices.Name = "btnReloadDevices";
            this.btnReloadDevices.Size = new System.Drawing.Size(22, 22);
            this.btnReloadDevices.TabIndex = 10;
            this.btnReloadDevices.UseVisualStyleBackColor = true;
            this.btnReloadDevices.Click += new System.EventHandler(this.btnReloadDevices_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(495, 267);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 72);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveAs.Location = new System.Drawing.Point(322, 345);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(145, 23);
            this.btnSaveAs.TabIndex = 7;
            this.btnSaveAs.Text = "Save As";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(580, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Loopback device";
            // 
            // cbLoopbackDevices
            // 
            this.cbLoopbackDevices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbLoopbackDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoopbackDevices.FormattingEnabled = true;
            this.cbLoopbackDevices.Location = new System.Drawing.Point(108, 420);
            this.cbLoopbackDevices.Name = "cbLoopbackDevices";
            this.cbLoopbackDevices.Size = new System.Drawing.Size(240, 21);
            this.cbLoopbackDevices.TabIndex = 9;
            this.cbLoopbackDevices.SelectedIndexChanged += new System.EventHandler(this.cbLoopbackDevices_SelectedIndexChanged);
            // 
            // llBitcoinAddress
            // 
            this.llBitcoinAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.llBitcoinAddress.AutoSize = true;
            this.llBitcoinAddress.Location = new System.Drawing.Point(391, 424);
            this.llBitcoinAddress.Name = "llBitcoinAddress";
            this.llBitcoinAddress.Size = new System.Drawing.Size(179, 13);
            this.llBitcoinAddress.TabIndex = 19;
            this.llBitcoinAddress.TabStop = true;
            this.llBitcoinAddress.Text = "Buy the dev a cup of coffee (bitcoin)";
            this.llBitcoinAddress.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llBitcoinAddress_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 446);
            this.Controls.Add(this.llBitcoinAddress);
            this.Controls.Add(this.cbLoopbackDevices);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSaveAs);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnReloadDevices);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvKeySounds);
            this.Controls.Add(this.btnTTS);
            this.Controls.Add(this.cbEnable);
            this.Controls.Add(this.cbPlaybackDevices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(566, 477);
            this.Name = "MainForm";
            this.Text = "Soundboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPlaybackDevices;
        private System.Windows.Forms.Button btnTTS;
        private System.Windows.Forms.CheckBox cbEnable;
        internal System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.ListView lvKeySounds;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnReloadDevices;
        internal System.Windows.Forms.ColumnHeader chKeys;
        internal System.Windows.Forms.ColumnHeader chSoundLoc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLoopbackDevices;
        private System.Windows.Forms.LinkLabel llBitcoinAddress;
    }
}

