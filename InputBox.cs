using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ULE
{
    public partial class InputBox : Form
    {
        public string InputText { get; set; }
        bool a = false;
        public InputBox(string InputTitle, string InputLabel)
        {
            InitializeComponent();
            label1.Text = InputLabel;
            this.Text = InputTitle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = true;
            InputText = this.richTextBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void InputBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!a)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Hide();
            }
        }
    }
}
