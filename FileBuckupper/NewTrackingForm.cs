using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileBuckupper
{
    public enum FrequencyUnit
    {
        Second=1,
        Minute=2,
        Hour=3
    }

    public partial class NewTrackingForm : Form
    {
        public List<string> FilePaths = new List<string>();
        public List<string> FolderPaths = new List<string>();
        public int Frequency;
        public FrequencyUnit frequencyUnit;

        public NewTrackingForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            timeUnitComboBox.SelectedIndex = 0;
        }

        private void NewTrackingForm_Load(object sender, EventArgs e)
        {

        }

        private void finishConfigurationButton_Click(object sender, EventArgs e)
        {
            this.Frequency = Decimal.ToInt32(frequencyNumericUpDown.Value);

            switch (timeUnitComboBox.SelectedIndex)
            {
                case 0:
                    this.frequencyUnit = FrequencyUnit.Second;
                    break;
                case 1:
                    this.frequencyUnit = FrequencyUnit.Minute;
                    break;
                case 2:
                    this.frequencyUnit = FrequencyUnit.Hour;
                    break;
            }
            Close();
        }

        private void ReferMultipleFiles()
        {
            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "すべてのファイル|*.*";
            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileListView.FullRowSelect = true;
                fileListView.GridLines = true;
                fileListView.Sorting = SortOrder.Ascending;
                fileListView.View = View.Details;

                foreach(string filePath in openFileDialog1.FileNames)
                {
                    if (!FilePaths.Contains(filePath))
                    {
                        FilePaths.Add(filePath);
                        fileListView.Items.Add(filePath);
                    }
                }
            }
        }

        private void filePathReferenceButton_Click(object sender, EventArgs e)
        {
            ReferMultipleFiles();
        }

        private void filePathRemoveReferenceButton_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in fileListView.SelectedItems)
            {
                fileListView.Items.Remove(item);
                FilePaths.Remove(item.Text);
            }
        }

        private void folderPathAddReferenceButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                folderListView.FullRowSelect = true;
                folderListView.GridLines = true;
                folderListView.Sorting = SortOrder.Ascending;
                folderListView.View = View.Details;

                if (!FolderPaths.Contains(folderBrowserDialog1.SelectedPath))
                {
                    FolderPaths.Add(folderBrowserDialog1.SelectedPath);
                    folderListView.Items.Add(folderBrowserDialog1.SelectedPath);
                }
            }
        }

        private void folderPathRemoveReferenceButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in folderListView.SelectedItems)
            {
                folderListView.Items.Remove(item);
                FolderPaths.Remove(item.Text);
            }
        }
    }
}
