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
    public partial class ManageLayers : Form
    {
        public static int zlayer = 0;
        public static int gridsize = 32;
        public ManageLayers()
        {
            InitializeComponent();
        }

        private void ManageLayers_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        void UpdateLayerList()
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var item in Layers.LayerList)
            {
                Panel row = new Panel();
                row.Width = flowLayoutPanel1.Width - 25;
                row.Height = 40;

                Label label = new Label();
                label.Font = new Font("Segoe UI", 12);
                label.Text = "Layer " + item.Zlayer;
                label.AutoSize = true;
                label.Location = new Point(5, 10);

                Button button = new Button();
                button.Text = "Delete";
                button.AutoSize = true;
                button.Location = new Point(150, 5);

                button.Click += (s, e) =>
                {
                    DialogResult dialogResult = MessageBox.Show(
                        "Are you sure?",
                        "",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (dialogResult == DialogResult.Yes)
                    {
                        Layers.LayerList.Remove(item);
                        UpdateLayerList();
                        Form1.logger.Log($"layer removed {item.Zlayer}");
                    }
                };

                row.Controls.Add(label);
                row.Controls.Add(button);

                flowLayoutPanel1.Controls.Add(row);
            }
        }

        void UpdateData()
        {
            label1.Text = "Grid Size: " + gridsize;
            label2.Text = "Zlayer: " + zlayer;
        }

        private void ManageLayers_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.AutoScroll = true;

            UpdateLayerList();
            UpdateData();
        }

        private void newlayer_Click(object sender, EventArgs e)
        {
            Layer layer = new Layer();
            layer.GridSize = gridsize;
            layer.Zlayer = zlayer;
            layer.enablecollisions = checkBox1.Checked;
            layer.navmeshsurface = checkBox2.Checked;
            Layers.LayerList.Add(layer);
            Form1.logger.Log($"Layer {layer.Zlayer} added");
            UpdateLayerList();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Form1.logger.Log("use collisions state changed");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InputBox inputBox = new InputBox("Grid Size", "Enter the grid size for the selected layer");
            inputBox.ShowDialog();
            if (inputBox.DialogResult != DialogResult.OK) { return; }
            if (int.TryParse(inputBox.InputText, out int result))
            {
                gridsize = result;
            }
            inputBox.Dispose();
            UpdateData();
            Form1.logger.Log("Grid Size updated");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InputBox inputBox = new InputBox("Zlayer", "Enter the Zlayer for the selected layer");
            inputBox.ShowDialog();
            if (inputBox.DialogResult != DialogResult.OK) { return; }
            if (int.TryParse(inputBox.InputText, out int result))
            {
                zlayer = result;
            }
            inputBox.Dispose();
            UpdateData();
            Form1.logger.Log("Zlayer updated");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Form1.logger.Log("is navmesh surface state changed");
        }
    }
}
