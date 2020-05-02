﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace JNSoundboard
{
    public partial class AddEditHotkeyForm : Form
    {
        internal class ListViewItemComparer : IComparer
        {
            private int col;

            public ListViewItemComparer()
            {
                col = 0;
            }

            public ListViewItemComparer(int column)
            {
                col = column;
            }

            public int Compare(object x, object y)
            {
                if (string.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text) == 0)
                {
                    return string.Compare(((ListViewItem)x).SubItems[2].Text, ((ListViewItem)y).SubItems[2].Text);
                }
                else
                {
                    return string.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
                }
            }
        }

        internal string[] editStrings = null;
        internal int editIndex = -1;

        MainForm mainForm;
        SettingsForm settingsForm;

        public AddEditHotkeyForm()
        {
            InitializeComponent();
        }

        private void AddEditSoundKeys_Load(object sender, EventArgs e)
        {
            if (SettingsForm.addingEditingLoadXMLFile)
            {
                //hide window restriction
                gbWindowRestriction.Visible = false;
                this.MinimumSize = new Size(375, 170);
                this.Size = new Size(375, 170);

                settingsForm = Application.OpenForms[1] as SettingsForm;

                this.Text = "Add/edit keys and XML location";

                if (editIndex != -1)
                {
                    tbKeys.Text = editStrings[0];
                    tbLocation.Text = editStrings[1];
                }
            }
            else
            {
                mainForm = Application.OpenForms[0] as MainForm;

                labelLoc.Text += " (use a semi-colon (;) to seperate multiple locations)";

                loadWindows();

                if (editIndex != -1)
                {
                    tbKeys.Text = editStrings[0];

                    if (editStrings[1] != "")
                    {
                        cbEnableRestrictWindow.Checked = true;

                        int index = cbWindows.Items.IndexOf(editStrings[1]);

                        if (index != -1) cbWindows.SelectedIndex = index;
                        else
                        {
                            cbWindows.Items.Add(editStrings[1]);
                            cbWindows.SelectedIndex = cbWindows.Items.Count - 1;
                        }
                    }

                    tbLocation.Text = editStrings[2];
                }

                
            }
        }

        private void loadWindows()
        {
            cbWindows.Items.Clear();

            cbWindows.Items.Add("");

            Process[] processlist = Process.GetProcesses();

            foreach (Process process in processlist)
            {
                if (!string.IsNullOrEmpty(process.MainWindowTitle))
                {
                    cbWindows.Items.Add(process.MainWindowTitle);
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbLocation.Text))
            {
                MessageBox.Show("Location is empty");
                return;
            }

            if (SettingsForm.addingEditingLoadXMLFile && string.IsNullOrWhiteSpace(tbKeys.Text))
            {
                MessageBox.Show("No keys entered");
                return;
            }

            string[] soundLocs = null;
            string errorMessage = "";

            if (!SettingsForm.addingEditingLoadXMLFile)
            {
                if (!SettingsForm.addingEditingLoadXMLFile && Helper.soundLocsArrayFromString(tbLocation.Text, out soundLocs, out errorMessage))
                {
                    if (soundLocs.Any(x => string.IsNullOrWhiteSpace(x) || !File.Exists(x)))
                    {
                        MessageBox.Show("The file/one of the files does not exist");

                        this.Close();

                        return;
                    }
                }

                if (soundLocs == null)
                {
                    MessageBox.Show(errorMessage);
                    return;
                }
            }

            Keys[] keysArr;

            if (!Helper.keysArrayFromString(tbKeys.Text, out keysArr, out errorMessage)) keysArr = new Keys[] { };

            if (SettingsForm.addingEditingLoadXMLFile)
            {
                if (editIndex != -1)
                {
                    settingsForm.lvKeysLocs.Items[editIndex].Text = tbKeys.Text;
                    settingsForm.lvKeysLocs.Items[editIndex].SubItems[1].Text = tbLocation.Text;

                    settingsForm.loadXMLFilesList[editIndex].Keys = keysArr;
                    settingsForm.loadXMLFilesList[editIndex].XMLLocation = tbLocation.Text;
                }
                else
                {
                    var item = new ListViewItem(tbKeys.Text);
                    item.SubItems.Add(tbLocation.Text);

                    settingsForm.lvKeysLocs.Items.Add(item);

                    settingsForm.loadXMLFilesList.Add(new XMLSettings.LoadXMLFile(keysArr, tbLocation.Text));
                }
            }
            else
            {
                string windowText = "";
                if (cbEnableRestrictWindow.Checked && (string)cbWindows.SelectedItem != "") windowText = (string)cbWindows.SelectedItem;

                if (editIndex > -1)
                {
                    mainForm.lvKeySounds.Items[editIndex].Text = tbKeys.Text;
                    mainForm.lvKeySounds.Items[editIndex].SubItems[1].Text = windowText;
                    mainForm.lvKeySounds.Items[editIndex].SubItems[2].Text = tbLocation.Text;

                    mainForm.soundHotkeys[editIndex] = new XMLSettings.SoundHotkey(keysArr, windowText, soundLocs);
                }
                else
                {
                    var newItem = new ListViewItem(tbKeys.Text);
                    newItem.SubItems.Add(windowText);
                    newItem.SubItems.Add(tbLocation.Text);

                    mainForm.lvKeySounds.Items.Add(newItem);

                    mainForm.soundHotkeys.Add(new XMLSettings.SoundHotkey(keysArr, windowText, soundLocs));
                }

                mainForm.lvKeySounds.ListViewItemSorter = new ListViewItemComparer(0);
                mainForm.lvKeySounds.Sort();

                mainForm.soundHotkeys.Sort(delegate (XMLSettings.SoundHotkey x, XMLSettings.SoundHotkey y)
                {
                    if (x.Keys == null && y.Keys == null) return 0;
                    else if (x.Keys == null) return -1;
                    else if (y.Keys == null) return 1;
                    else return Helper.keysToString(x.Keys).CompareTo(Helper.keysToString(y.Keys));
                });

                mainForm.chKeys.Width = -2;
                mainForm.chSoundLoc.Width = -2;
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowseSoundLoc_Click(object sender, EventArgs e)
        {
            var diag = new OpenFileDialog();

            diag.Multiselect = !SettingsForm.addingEditingLoadXMLFile;

            diag.Filter = (SettingsForm.addingEditingLoadXMLFile ? "XML file containing keys and sounds|*.xml" : "Supported audio formats|*.mp3;*.m4a;*.wav;*.wma;*.ac3;*.aiff;*.mp2|All files|*.*");

            var result = diag.ShowDialog();

            if (result == DialogResult.OK)
            {
                string text = "";

                for (int i = 0; i < diag.FileNames.Length; i++)
                {
                    string fileName = diag.FileNames[i];

                    if (fileName != "") text += (i == 0 ? "" : ";") + fileName;
                }

                tbLocation.Text = text;
            }
        }

        private void tbKeys_Enter(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void tbKeys_Leave(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        int lastAmountPressed = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            int amountPressed = 0;

            if (Keyboard.IsKeyDown(Keys.Escape))
            {
                lastAmountPressed = 50;

                tbKeys.Text = ""; 
            }
            else
            {
                var pressedKeys = new List<Keys>();

                foreach (Keys key in Enum.GetValues(typeof(Keys)))
                {
                    if (Keyboard.IsKeyDown(key))
                    {
                        amountPressed++;
                        pressedKeys.Add(key);
                    }
                }

                if (amountPressed > lastAmountPressed)
                {
                    tbKeys.Text = Helper.keysToString(pressedKeys.ToArray());
                }

                lastAmountPressed = amountPressed;
            }
        }

        private void cbEnableRestrictWindow_CheckedChanged(object sender, EventArgs e)
        {
            cbWindows.Enabled = cbEnableRestrictWindow.Checked;
            btnReloadWindows.Enabled = cbEnableRestrictWindow.Checked;
        }

        private void btnReloadWindows_Click(object sender, EventArgs e)
        {
            loadWindows();
        }
    }
}
