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
            NewTrackingForm newTrackingForm = new NewTrackingForm();
            newTrackingForm.ShowDialog();
        }
    }
}
