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
    public partial class MainForm : Form
    {
        private NewTrackingForm newTrackingForm;

        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 新規NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newTrackingForm = new NewTrackingForm();
            newTrackingForm.ShowDialog();
            UpdateTargetFileListView();
            UpdateTargetFolderListView();
        }

        private void UpdateTargetFileListView() {
            targetFileListView.FullRowSelect = true;
            targetFileListView.GridLines = true;
            targetFileListView.Sorting = SortOrder.Ascending;
            targetFileListView.View = View.Details;

            foreach (string filePath in newTrackingForm.FilePaths)
            {
                targetFileListView.Items.Add(filePath);
            }
        }

        private void UpdateTargetFolderListView()
        {
            targetFolderListView.FullRowSelect = true;
            targetFolderListView.GridLines = true;
            targetFolderListView.Sorting = SortOrder.Ascending;
            targetFolderListView.View = View.Details;

            foreach (string folderPath in newTrackingForm.FolderPaths)
            {
                targetFolderListView.Items.Add(folderPath);
            }
        }
    }
}
