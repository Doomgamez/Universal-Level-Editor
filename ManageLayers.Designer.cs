namespace ULE
{
    partial class ManageLayers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            newlayer = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            checkBox1 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            checkBox2 = new CheckBox();
            SuspendLayout();
            // 
            // newlayer
            // 
            newlayer.Location = new Point(12, 12);
            newlayer.Name = "newlayer";
            newlayer.Size = new Size(75, 23);
            newlayer.TabIndex = 0;
            newlayer.Text = "New Layer";
            newlayer.UseVisualStyleBackColor = true;
            newlayer.Click += newlayer_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.BackColor = SystemColors.ScrollBar;
            flowLayoutPanel1.Location = new Point(0, 311);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(315, 122);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 74);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 98);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 41);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(97, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Use collisions";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(93, 12);
            button1.Name = "button1";
            button1.Size = new Size(101, 23);
            button1.TabIndex = 5;
            button1.Text = "change grid size";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(200, 12);
            button2.Name = "button2";
            button2.Size = new Size(87, 23);
            button2.TabIndex = 6;
            button2.Text = "change zlayer";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(115, 41);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(117, 19);
            checkBox2.TabIndex = 7;
            checkBox2.Text = "NavMesh surface";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // ManageLayers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 432);
            Controls.Add(checkBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(newlayer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ManageLayers";
            ShowInTaskbar = false;
            Text = "ManageLayers";
            FormClosing += ManageLayers_FormClosing;
            Load += ManageLayers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button newlayer;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label label2;
        private CheckBox checkBox1;
        private Button button1;
        private Button button2;
        private CheckBox checkBox2;
    }
}