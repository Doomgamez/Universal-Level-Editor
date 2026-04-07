using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULE.editor;

namespace ULE
{
    public partial class FSettings : Form
    {
        public FSettings()
        {
            InitializeComponent();
        }

        private void Debug_CheckedChanged(object sender, EventArgs e)
        {
            EditorData.settings.debug = Debug.Checked;
            if (Debug.Checked)
            {
                Form1.logger.Show();
            }
            else
            {
                Form1.logger.Hide();
            }
        }

        private void FSettings_Load(object sender, EventArgs e)
        {

        }

        private void FSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
