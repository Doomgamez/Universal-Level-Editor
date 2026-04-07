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
using System.Diagnostics;

namespace ULE
{
    public partial class FResources : Form
    {
        public FResources()
        {
            InitializeComponent();
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.WrapContents = false;
        }
        private void FResources_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        void UpdateList()
        {
            flowLayoutPanel1.Controls.Clear();
            int y = 1;
            foreach (var item in ResourceClass.ResourceList)
            {
                Label path = new Label();
                path.Text = item.Path;
                path.AutoSize = true;
                path.Location = new Point(0, y * 30);
                
                Button deleteButton = new Button();
                deleteButton.Text = "Remove";
                deleteButton.AutoSize = true;
                deleteButton.Location = new Point(path.Width, y * 30);
                deleteButton.Click += (s, e) =>
                {
                    ResourceClass.ResourceList.Remove(item);
                    item.Texture.Dispose();
                    item.Texture = null;
                    UpdateList();
                };

                Button Showbutton = new Button();
                Showbutton.Text = "Show";
                Showbutton.AutoSize = true;
                Showbutton.Location = new Point(path.Width + deleteButton.Width, y * 30);
                Showbutton.Click += (s, e) =>
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = item.Path,
                        UseShellExecute = true
                    });
                };

                flowLayoutPanel1.Controls.Add(path);
                flowLayoutPanel1.SetFlowBreak(path, true);
                flowLayoutPanel1.Controls.Add(deleteButton);
                flowLayoutPanel1.Controls.Add(Showbutton);
                flowLayoutPanel1.SetFlowBreak(Showbutton, true);
                y = y + 1;
            }
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap;
                try
                {
                    bitmap = new Bitmap(openFileDialog.FileName);
                    Resource res = new Resource(System.IO.Path.GetFileNameWithoutExtension(openFileDialog.FileName), ResourceType.Texture, openFileDialog.FileName);
                    res.Texture = bitmap;
                    ResourceClass.ResourceList.Add(res);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load image: " + ex.Message);
                    return;
                }
                UpdateList();
            }
        }
    }
}
