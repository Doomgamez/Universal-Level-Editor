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
using System.IO;

namespace ULE
{
    public partial class Loader : Form
    {
        public Loader()
        {
            InitializeComponent();
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.HorizontalScroll.Enabled = false;
            flowLayoutPanel1.HorizontalScroll.Visible = false;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
        }

        double foldersize(string a)
        {
            double size = 0;

            foreach (string i in Directory.GetFiles(Path.Combine(Consts.Dirpath,a)))
            {
                size = size + File.ReadAllBytes(i).Length;
            }
            return size;                        
        }
        void UpdateL()
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (string dir in Directory.GetDirectories(Consts.Dirpath))
            {
                Panel g = new Panel();
                g.Width = flowLayoutPanel1.ClientSize.Width;
                g.Height = 64;
                g.Margin = new Padding(0);
                g.BackColor = Color.FromArgb(100, 100, 100);

                Label label = new Label();
                label.Text = Path.GetFileName(dir);
                label.Font = new Font("Arial", 16, FontStyle.Bold);
                label.AutoSize = true;
                label.AutoEllipsis = true;

                Button button = new Button();
                button.Text = "Load";
                button.AutoSize = true;

                Button del = new Button();
                del.Text = "Delete";
                del.AutoSize = true;

                button.Location = new Point(16 + TextRenderer.MeasureText(label.Text, label.Font).Width, 0);
                del.Location = new Point(16 + TextRenderer.MeasureText(label.Text, label.Font).Width + TextRenderer.MeasureText(button.Text, button.Font).Width + 30, 0);

                button.Click += (s, ev) =>
                {
                    EditorData.settings.projectname = Path.GetFileName(dir);
                    Form1 mainForm = new Form1();
                    mainForm.Show();
                    this.Hide();
                };

                del.Click += (s, ev) =>
                {
                    if (MessageBox.Show("Are you sure you want to delete this project?", "",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Directory.Delete(dir, true);
                        UpdateL();
                    }
                };

                Label label1 = new Label();

                label1.Text = "Created: " + File.GetCreationTime(dir).ToString();
                label1.Font = new Font("Arial", 10, FontStyle.Regular);
                label1.AutoSize = true;
                label1.Location = new Point(0, 32);
                
                Label label2 = new Label();

                label2.Text = ByteSizeLib.ByteSize.FromBytes(foldersize(dir)).ToString();
                label2.Font = new Font("Arial", 10, FontStyle.Regular);
                label2.AutoSize = true;
                label2.Location = new Point(TextRenderer.MeasureText(label1.Text, label1.Font).Width + 32, 32);

                g.Controls.Add(label);
                g.Controls.Add(button);
                g.Controls.Add(del);
                g.Controls.Add(label1);
                g.Controls.Add(label2);

                flowLayoutPanel1.Controls.Add(g);
            }
        }

        private void Loader_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(Consts.Dirpath))
            {
                Directory.CreateDirectory(Consts.Dirpath);
            }

            UpdateL();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InputBox inputBox = new InputBox("Enter Project Name", "Project Name");
            inputBox.ShowDialog();
            if (inputBox.DialogResult != DialogResult.OK) { return; }
            if (!string.IsNullOrEmpty(inputBox.InputText))
            {
                EditorData.settings.projectname = inputBox.InputText;
                Directory.CreateDirectory(Consts.GetProjFolder());
                Form1 mainForm = new Form1();
                mainForm.Show();
                this.Hide();
            }
            inputBox.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
