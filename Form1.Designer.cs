namespace ULE
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            Settings = new Button();
            FileOutput = new Button();
            Macros = new Button();
            Resources = new Button();
            Editmetadata = new Button();
            NewObject = new Button();
            timer3 = new System.Windows.Forms.Timer(components);
            Layers = new Button();
            comboBox1 = new ComboBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            checkBox3 = new CheckBox();
            timer4 = new System.Windows.Forms.Timer(components);
            checkBox4 = new CheckBox();
            timer5 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1280, 720);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.Paint += pictureBox1_Paint;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 250;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 41;
            timer2.Tick += timer2_Tick;
            // 
            // Settings
            // 
            Settings.Location = new Point(12, 726);
            Settings.Name = "Settings";
            Settings.Size = new Size(82, 23);
            Settings.TabIndex = 1;
            Settings.Text = "Settings";
            Settings.UseVisualStyleBackColor = true;
            Settings.Click += Settings_Click;
            // 
            // FileOutput
            // 
            FileOutput.Location = new Point(13, 756);
            FileOutput.Name = "FileOutput";
            FileOutput.Size = new Size(82, 23);
            FileOutput.TabIndex = 2;
            FileOutput.Text = "File";
            FileOutput.UseVisualStyleBackColor = true;
            FileOutput.Click += FileOutput_Click;
            // 
            // Macros
            // 
            Macros.Location = new Point(13, 785);
            Macros.Name = "Macros";
            Macros.Size = new Size(82, 23);
            Macros.TabIndex = 3;
            Macros.Text = "Macros";
            Macros.UseVisualStyleBackColor = true;
            Macros.Click += Macros_Click;
            // 
            // Resources
            // 
            Resources.Location = new Point(13, 814);
            Resources.Name = "Resources";
            Resources.Size = new Size(82, 23);
            Resources.TabIndex = 4;
            Resources.Text = "Resources";
            Resources.UseVisualStyleBackColor = true;
            Resources.Click += Resources_Click;
            // 
            // Editmetadata
            // 
            Editmetadata.Location = new Point(1185, 726);
            Editmetadata.Name = "Editmetadata";
            Editmetadata.Size = new Size(95, 23);
            Editmetadata.TabIndex = 5;
            Editmetadata.Text = "Edit metadata";
            Editmetadata.UseVisualStyleBackColor = true;
            Editmetadata.Click += Editmetadata_Click;
            // 
            // NewObject
            // 
            NewObject.Location = new Point(1097, 726);
            NewObject.Name = "NewObject";
            NewObject.Size = new Size(82, 23);
            NewObject.TabIndex = 6;
            NewObject.Text = "New Object";
            NewObject.UseVisualStyleBackColor = true;
            NewObject.Click += NewObject_Click;
            // 
            // timer3
            // 
            timer3.Enabled = true;
            timer3.Interval = 250;
            timer3.Tick += timer3_Tick;
            // 
            // Layers
            // 
            Layers.Location = new Point(449, 726);
            Layers.Name = "Layers";
            Layers.Size = new Size(93, 23);
            Layers.TabIndex = 8;
            Layers.Text = "Manage layers";
            Layers.UseVisualStyleBackColor = true;
            Layers.Click += Layers_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(548, 727);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(678, 729);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(60, 19);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Visible";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(678, 754);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(67, 19);
            checkBox2.TabIndex = 11;
            checkBox2.Text = "Preview";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            flowLayoutPanel1.BackColor = SystemColors.ButtonShadow;
            flowLayoutPanel1.Location = new Point(1286, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(306, 866);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(678, 779);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(48, 19);
            checkBox3.TabIndex = 13;
            checkBox3.Text = "Grid";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(678, 804);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(51, 19);
            checkBox4.TabIndex = 14;
            checkBox4.Text = "Drag";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // timer5
            // 
            timer5.Enabled = true;
            timer5.Interval = 30000;
            timer5.Tick += timer5_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 861);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(comboBox1);
            Controls.Add(Layers);
            Controls.Add(NewObject);
            Controls.Add(Editmetadata);
            Controls.Add(Resources);
            Controls.Add(Macros);
            Controls.Add(FileOutput);
            Controls.Add(Settings);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Button Settings;
        private Button FileOutput;
        private Button Macros;
        private Button Resources;
        private Button Editmetadata;
        private Button NewObject;
        private System.Windows.Forms.Timer timer3;
        private Button Layers;
        private ComboBox comboBox1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private FlowLayoutPanel flowLayoutPanel1;
        private CheckBox checkBox3;
        private System.Windows.Forms.Timer timer4;
        private CheckBox checkBox4;
        private System.Windows.Forms.Timer timer5;
    }
}
