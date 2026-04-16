using System.Windows.Forms;
using ULE.editor;
using ULE.utils;

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
        public static FResources fresources;
        public static FMacros macros;
        public static FFile fFile;

        DateTime lastPlaceTime = DateTime.MinValue;
        DateTime lastDeleteTime = DateTime.MinValue;
        const int delayMs = 100;

        public Form1()
        {
            InitializeComponent();
            settings = new FSettings();
            logger = new Logger();
            managelayers = new ManageLayers();
            fresources = new FResources();
            macros = new FMacros();
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.WrapContents = false;
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
                foreach (var item in LevelData.current.level.Grid)
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
                        LevelData.current.level.Grid.Remove(item);
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
                foreach (var item in LevelData.current.level.Objarr)
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
                        LevelData.current.level.Objarr.Remove(item);
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
                foreach (var item in LevelData.current.level.Grid)
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
                            LevelData.current.level.Grid.Remove(item);
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
                foreach (var item in LevelData.current.level.Objarr)
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
                            ED.state.offset = new Vector2I((int)item.position.X, (int)item.position.Y);
                            pictureBox1.Invalidate();
                        };
                        button1.Text = "Go to";
                        button1.AutoSize = true;

                        Button button2 = new Button();
                        button2.Location = new Point(label1.Width + button1.Width, 20 * y);
                        button2.Click += (s, e) =>
                        {
                            LevelData.current.level.Objarr.Remove(item);
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

        void PlaceObject(int mouseX, int mouseY)
        {
            if (ED.settings.selectedresource == null) return;

            int grid = ED.settings.selectedlayer.GridSize;
            if (grid <= 0) grid = 32;

            int worldX = mouseX + ED.state.offset.X;
            int worldY = mouseY + ED.state.offset.Y;

            if (ED.settings.snaptoGrid)
            {
                worldX = (worldX / grid) * grid;
                worldY = (worldY / grid) * grid;

                if (LevelData.current.level.Grid.Any(g =>
                    g.position.X == worldX &&
                    g.position.Y == worldY &&
                    g.layer == ED.settings.selectedlayer.Zlayer))
                    return;

                var tile = new LevelData.Gridobj
                {
                    position = new Vector2I(worldX, worldY),
                    layer = ED.settings.selectedlayer.Zlayer,
                    resource = ED.settings.selectedresource,
                    size = new Vector2I(grid, grid)
                };

                LevelData.current.level.Grid.Add(tile);
            }
            else
            {
                if (LevelData.current.level.Objarr.Any(o =>
                    (int)o.position.X == worldX &&
                    (int)o.position.Y == worldY &&
                    o.layer == ED.settings.selectedlayer.Zlayer))
                    return;

                var obj = new LevelData.Object
                {
                    position = new Vector2(worldX - grid / 2, worldY - grid / 2),
                    layer = ED.settings.selectedlayer.Zlayer,
                    resource = ED.settings.selectedresource,
                    size = new Vector2(grid, grid)
                };

                LevelData.current.level.Objarr.Add(obj);
            }
            InitSideBar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.WrapContents = false;

            this.Text = "ULE - Universal Level Editor v" + Consts.version;
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

            ImportSave.Try2ImportSave();
            InitSideBar();

            this.Invalidate();
            this.Update();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;

            int grid = ED.settings.selectedlayer.GridSize;
            if (grid <= 0) grid = 32;

            Pen pen = new Pen(Color.Black, 1);

            int startWorldX = (ED.state.offset.X / grid) * grid;
            int startWorldY = (ED.state.offset.Y / grid) * grid;

            for (int x = startWorldX; x < ED.state.offset.X + pictureBox1.Width; x += grid)
            {
                int screenX = x - ED.state.offset.X;
                g.DrawLine(pen, screenX, 0, screenX, pictureBox1.Height);
            }

            for (int y = startWorldY; y < ED.state.offset.Y + pictureBox1.Height; y += grid)
            {
                int screenY = y - ED.state.offset.Y;
                g.DrawLine(pen, 0, screenY, pictureBox1.Width, screenY);
            }

            foreach (var tile in LevelData.current.level.Grid)
            {
                var layer = LA.LayerList.FirstOrDefault(l => l.Zlayer == tile.layer);
                if (layer == null || !layer.Visible) continue;

                int screenX = tile.position.X - ED.state.offset.X;
                int screenY = tile.position.Y - ED.state.offset.Y;

                if (tile.resource?.Texture != null)
                {
                    g.DrawImage(
                        tile.resource.Texture,
                        screenX,
                        screenY,
                        grid,
                        grid
                    );
                }
                else
                {
                    g.FillRectangle(Brushes.Blue, screenX, screenY, grid, grid);
                }
            }

            foreach (var obj in LevelData.current.level.Objarr)
            {
                var layer = LA.LayerList.FirstOrDefault(l => l.Zlayer == obj.layer);
                if (layer == null || !layer.Visible) continue;

                int screenX = (int)obj.position.X - ED.state.offset.X;
                int screenY = (int)obj.position.Y - ED.state.offset.Y;

                if (obj.resource?.Texture != null)
                {
                    g.DrawImage(
                        obj.resource.Texture,
                        screenX,
                        screenY,
                        grid,
                        grid
                    );
                }
                else
                {
                    g.FillRectangle(Brushes.Magenta, screenX, screenY, grid, grid);
                }
            }

            if (ED.state.debug)
            {
                g.DrawString(
                    ED.state.offset.X + "," + ED.state.offset.Y + " : " + ED.state.focused() + " : " + EditorData.settings.selectedlayer.Zlayer,
                    new Font("Arial", 16),
                    Brushes.Black,
                    0,
                    0
                );
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
                ED.state.offset.Y -= 4;
                pictureBox1.Invalidate();
            }
            if ((GetAsyncKeyState((int)Keys.S) & 0x8000) != 0)
            {
                ED.state.offset.Y += 4;
                pictureBox1.Invalidate();
            }
            if ((GetAsyncKeyState((int)Keys.D) & 0x8000) != 0)
            {
                ED.state.offset.X += 4;
                pictureBox1.Invalidate();
            }
            if ((GetAsyncKeyState((int)Keys.A) & 0x8000) != 0)
            {
                ED.state.offset.X -= 4;
                pictureBox1.Invalidate();
            }
        }

        private void Macros_Click(object sender, EventArgs e)
        {
            logger.Log("Macros Clicked");
            macros.Show();
            macros.Focus();
        }

        private void FileOutput_Click(object sender, EventArgs e)
        {
            logger.Log("File clicked");
            FFile file = new FFile();
            file.Show();
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
            fresources = new FResources();
            fresources.Show();
            fresources.Focus();
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
            managelayers.Focus();
        }

        void DeleteObject(int mouseX, int mouseY)
        {
            int grid = ED.settings.selectedlayer.GridSize;
            if (grid <= 0) grid = 32;

            int worldX = mouseX + ED.state.offset.X;
            int worldY = mouseY + ED.state.offset.Y;

            if (ED.settings.snaptoGrid)
            {
                var candidates = LevelData.current.level.Grid
                    .Where(g =>
                        g.layer == ED.settings.selectedlayer.Zlayer &&
                        worldX >= g.position.X &&
                        worldX < g.position.X + grid &&
                        worldY >= g.position.Y &&
                        worldY < g.position.Y + grid)
                    .ToList();

                if (candidates.Count > 0)
                {
                    var closest = candidates
                        .OrderBy(g =>
                        {
                            int cx = g.position.X + grid / 2;
                            int cy = g.position.Y + grid / 2;
                            int dx = cx - worldX;
                            int dy = cy - worldY;
                            return dx * dx + dy * dy;
                        })
                        .First();

                    LevelData.current.level.Grid.Remove(closest);
                }
            }
            else
            {
                var candidates = LevelData.current.level.Objarr
                    .Where(o =>
                        o.layer == ED.settings.selectedlayer.Zlayer &&
                        worldX >= o.position.X &&
                        worldX < o.position.X + o.size.X &&
                        worldY >= o.position.Y &&
                        worldY < o.position.Y + o.size.Y)
                    .ToList();

                if (candidates.Count > 0)
                {
                    var closest = candidates
                        .OrderBy(o =>
                        {
                            int cx = (int)o.position.X + (int)o.size.X / 2;
                            int cy = (int)o.position.Y + (int)o.size.Y / 2;
                            int dx = cx - worldX;
                            int dy = cy - worldY;
                            return dx * dx + dy * dy;
                        })
                        .First();

                    LevelData.current.level.Objarr.Remove(closest);
                }
            }
            InitSideBar();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            var now = DateTime.Now;

            if ((e.Button & MouseButtons.Left) != 0)
            {
                if (((now - lastPlaceTime).TotalMilliseconds >= delayMs) || checkBox4.Checked)
                {
                    PlaceObject(e.X, e.Y);
                    lastPlaceTime = now;
                }

                pictureBox1.Invalidate();
            }

            if ((e.Button & MouseButtons.Right) != 0)
            {
                if (((now - lastDeleteTime).TotalMilliseconds >= delayMs) || checkBox4.Checked)
                {
                    DeleteObject(e.X, e.Y);
                    lastDeleteTime = now;
                }

                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!pictureBox1.Focused) pictureBox1.Focus();

            var now = DateTime.Now;

            if ((e.Button & MouseButtons.Left) != 0)
            {
                if (((now - lastPlaceTime).TotalMilliseconds >= delayMs) || checkBox4.Checked)
                {
                    PlaceObject(e.X, e.Y);
                    lastPlaceTime = now;
                }
            }

            if ((e.Button & MouseButtons.Right) != 0)
            {
                if (((now - lastDeleteTime).TotalMilliseconds >= delayMs) || checkBox4.Checked)
                {
                    DeleteObject(e.X, e.Y);
                    lastDeleteTime = now;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EditorData.settings.selectedlayer = LA.LayerList[comboBox1.SelectedIndex];
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!pictureBox1.Focused) pictureBox1.Focus();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            ED.settings.snaptoGrid = checkBox3.Checked;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            FFile.SaveNow();
        }
    }
}
