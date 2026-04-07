using ULE.editor;
using ULE.utils;
using ULE.utils.level;
using static ULE.utils.Math;
using ED = ULE.editor.EditorData;
using LA = ULE.editor.Layers;
namespace ULE
{
    public partial class Form1 : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);

        public static FSettings settings;
        public static Logger logger;
        public static ManageLayers managelayers;
        public Form1()
        {
            settings = new FSettings();
            logger = new Logger();
            managelayers = new ManageLayers();
            InitializeComponent();
        }

        void InitSideBar()
        {
            flowLayoutPanel1.Controls.Clear();
            Label label = new Label();
            label.Location = new Point(3, 20);
            label.Font = new Font("Segoe UI", 16);
            label.Text = "Object manager";
            label.AutoSize = true;

            flowLayoutPanel1.Controls.Add(label);

            if (EditorData.settings.previewmode)
            {
                int y = 2;
                foreach (var item in LevelData.level.Grid)
                {
                    Label label1 = new Label();
                    label1.Location = new Point(3, 20 * y);
                    label1.Font = new Font("Segoe UI", 12);
                    label1.Text = $"Grid {item.layer} : {item.position.X},{item.position.Y}";
                    label1.AutoSize = true;

                    Button button1 = new Button();
                    button1.Location = new Point(label1.Width, 20 * y);
                    button1.Click += (s, e) =>
                    {
                        ED.state.offset = item.position;
                        pictureBox1.Invalidate();
                    };
                    button1.Text = "Go to";
                    button1.AutoSize = true;

                    Button button2 = new Button();
                    button2.Location = new Point(label1.Width + button1.Width, 20 * y);
                    button2.Click += (s, e) =>
                    {
                        LevelData.level.Grid.Remove(item);
                        InitSideBar();
                        pictureBox1.Invalidate();
                    };
                    button2.Text = "Delete";
                    button2.AutoSize = true;

                    flowLayoutPanel1.Controls.Add(label1);
                    flowLayoutPanel1.Controls.Add(button1);
                    flowLayoutPanel1.Controls.Add(button2);
                    flowLayoutPanel1.SetFlowBreak(button2, true);
                    y = y + 1;
                }
                foreach (var item in LevelData.level.Objarr)
                {
                    Label label1 = new Label();
                    label1.Location = new Point(3, 20 * y);
                    label1.Font = new Font("Segoe UI", 12);
                    label1.Text = $"Grid {item.layer} : {item.position.X},{item.position.Y}";
                    label1.AutoSize = true;

                    Button button1 = new Button();
                    button1.Location = new Point(label1.Width, 20 * y);
                    button1.Click += (s, e) =>
                    {
                        ED.state.offset = new Vector2I((int)item.position.X, (int)item.position.Y);
                        pictureBox1.Invalidate();
                    };
                    button1.Text = "Go to";
                    button1.AutoSize = true;

                    Button button2 = new Button();
                    button2.Location = new Point(label1.Width + button1.Width, 20 * y);
                    button2.Click += (s, e) =>
                    {
                        LevelData.level.Objarr.Remove(item);
                        InitSideBar();
                        pictureBox1.Invalidate();
                    };
                    button2.Text = "Delete";
                    button2.AutoSize = true;

                    flowLayoutPanel1.Controls.Add(label1);
                    flowLayoutPanel1.Controls.Add(button1);
                    flowLayoutPanel1.Controls.Add(button2);
                    flowLayoutPanel1.SetFlowBreak(button2, true);
                    y = y + 1;
                }
            }
            else
            {
                int y = 2;
                int a = EditorData.settings.selectedlayer.Zlayer;
                foreach (var item in LevelData.level.Grid)
                {
                   if (item.layer == a)
                   {
                        Label label1 = new Label();
                        label1.Location = new Point(3, 20 * y);
                        label1.Font = new Font("Segoe UI", 12);
                        label1.Text = $"Grid {item.layer} : {item.position.X},{item.position.Y}";
                        label1.AutoSize = true;

                        Button button1 = new Button();
                        button1.Location = new Point(label1.Width, 20 * y);
                        button1.Click += (s, e) =>
                        {
                            ED.state.offset = item.position;
                            pictureBox1.Invalidate();
                        };
                        button1.Text = "Go to";
                        button1.AutoSize = true;

                        Button button2 = new Button();
                        button2.Location = new Point(label1.Width + button1.Width, 20 * y);
                        button2.Click += (s, e) =>
                        {
                            LevelData.level.Grid.Remove(item);
                            InitSideBar();
                            pictureBox1.Invalidate();
                        };
                        button2.Text = "Delete";
                        button2.AutoSize = true;

                        flowLayoutPanel1.Controls.Add(label1);
                        flowLayoutPanel1.Controls.Add(button1);
                        flowLayoutPanel1.Controls.Add(button2);
                        flowLayoutPanel1.SetFlowBreak(button2, true);
                        y = y + 1;
                   }
                }
                foreach (var item in LevelData.level.Objarr)
                {
                    if (item.layer == a)
                    {
                        Label label1 = new Label();
                        label1.Location = new Point(3, 20 * y);
                        label1.Font = new Font("Segoe UI", 12);
                        label1.Text = $"Grid {item.layer} : {item.position.X},{item.position.Y}";
                        label1.AutoSize = true;

                        Button button1 = new Button();
                        button1.Location = new Point(label1.Width, 20 * y);
                        button1.Click += (s, e) =>
                        {
                            ED.state.offset = new Vector2I( (int)item.position.X,(int)item.position.Y);
                            pictureBox1.Invalidate();
                        };
                        button1.Text = "Go to";
                        button1.AutoSize = true;

                        Button button2 = new Button();
                        button2.Location = new Point(label1.Width + button1.Width, 20 * y);
                        button2.Click += (s, e) =>
                        {
                            LevelData.level.Objarr.Remove(item);
                            InitSideBar();
                            pictureBox1.Invalidate();
                        };
                        button2.Text = "Delete";
                        button2.AutoSize = true;

                        flowLayoutPanel1.Controls.Add(label1);
                        flowLayoutPanel1.Controls.Add(button1);
                        flowLayoutPanel1.Controls.Add(button2);
                        flowLayoutPanel1.SetFlowBreak(button2, true);
                        y = y + 1;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.WrapContents = false;

            this.Text = "ULE - Universal Level Editor v" + AppData.version;
            this.pictureBox1.Focus();

            Layer defaultlayer = new Layer();

            defaultlayer.Zlayer = 0;
            defaultlayer.Visible = true;
            defaultlayer.GridSize = 32;

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            LA.LayerList.Add(defaultlayer);

            LA.LayerList.Sort((a, b) => a.Zlayer.CompareTo(b.Zlayer));

            defaultlayer.UpdateCombobox(comboBox1);

            comboBox1.SelectedIndex = 0;

            EditorData.settings.selectedlayer = LA.LayerList[0];

            InitSideBar();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 1);

            int startX = ((ED.state.offset.X % ED.settings.selectedlayer.GridSize) + ED.settings.selectedlayer.GridSize) % ED.settings.selectedlayer.GridSize;
            int startY = ((ED.state.offset.Y % ED.settings.selectedlayer.GridSize) + ED.settings.selectedlayer.GridSize) % ED.settings.selectedlayer.GridSize;

            for (int i = startX; i <= pictureBox1.Width; i += ED.settings.selectedlayer.GridSize)
            {
                g.DrawLine(pen, i, 0, i, pictureBox1.Height);
            }

            for (int j = startY; j <= pictureBox1.Height; j += ED.settings.selectedlayer.GridSize)
            {
                g.DrawLine(pen, 0, j, pictureBox1.Width, j);
            }

            if (ED.state.debug)
            {
                g.DrawString(ED.state.offset.X + "," + ED.state.offset.Y + " : " + ED.state.focused() + " : " + EditorData.settings.selectedlayer.Zlayer, new Font("Arial", 16), Brushes.Black, 0, 0);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (!pictureBox1.Focused) { return; }
            if ((GetAsyncKeyState((int)Keys.W) & 0x8000) != 0)
            {
                ED.state.offset.Y += 4;
                pictureBox1.Invalidate();
            }
            if ((GetAsyncKeyState((int)Keys.S) & 0x8000) != 0)
            {
                ED.state.offset.Y -= 4;
                pictureBox1.Invalidate();
            }
            if ((GetAsyncKeyState((int)Keys.D) & 0x8000) != 0)
            {
                ED.state.offset.X -= 4;
                pictureBox1.Invalidate();
            }
            if ((GetAsyncKeyState((int)Keys.A) & 0x8000) != 0)
            {
                ED.state.offset.X += 4;
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!pictureBox1.Focused) { pictureBox1.Focus(); }
        }

        private void Macros_Click(object sender, EventArgs e)
        {
            logger.Log("Macros Clicked");
            throw new NotImplementedException();
        }

        private void FileOutput_Click(object sender, EventArgs e)
        {
            logger.Log("File clicked");
            throw new NotImplementedException();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            logger.Log("Settings Clicked");
            settings.Show();
            settings.Focus();
        }

        private void Resources_Click(object sender, EventArgs e)
        {
            logger.Log("Resources Clicked");
            throw new NotImplementedException();
        }

        private void NewObject_Click(object sender, EventArgs e)
        {
            logger.Log("New Object Clicked");
            throw new NotImplementedException();
        }

        private void Editmetadata_Click(object sender, EventArgs e)
        {
            logger.Log("Edit metadata clicked");
            throw new NotImplementedException();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if ((GetAsyncKeyState((int)Keys.F3) & 0x8000) != 0)
            {
                ED.state.debug = !ED.state.debug;
            }
        }

        private void Layers_Click(object sender, EventArgs e)
        {
            logger.Log("Manage Layers Clicked");
            managelayers.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EditorData.settings.selectedlayer = LA.LayerList[comboBox1.SelectedIndex];
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            Layer garbage = new Layer();
            garbage.UpdateCombobox(comboBox1);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            logger.Log($"Layers {EditorData.settings.selectedlayer.Zlayer} visibility changed to {checkBox1.Checked}");
            ED.settings.selectedlayer.Visible = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            logger.Log($"Global Preview value changed {checkBox2.Checked}");
            ED.settings.previewmode = checkBox2.Checked;
        }
    }
}
