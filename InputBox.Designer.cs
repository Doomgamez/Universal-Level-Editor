namespace ULE
{
    partial class InputBox
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
            button1 = new Button();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(329, 80);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Ok";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 1;
            label1.Text = "Label";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 80);
            richTextBox1.Multiline = false;
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox1.Size = new Size(311, 21);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // InputBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 115);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            MaximizeBox = false;
            Name = "InputBox";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "InputBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private RichTextBox richTextBox1;
    }
}