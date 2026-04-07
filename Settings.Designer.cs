namespace ULE
{
    partial class FSettings
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
            Debug = new CheckBox();
            SuspendLayout();
            // 
            // Debug
            // 
            Debug.AutoSize = true;
            Debug.Location = new Point(12, 12);
            Debug.Name = "Debug";
            Debug.Size = new Size(95, 19);
            Debug.TabIndex = 0;
            Debug.Text = "Debug mode";
            Debug.UseVisualStyleBackColor = true;
            Debug.CheckedChanged += Debug_CheckedChanged;
            // 
            // FSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 364);
            Controls.Add(Debug);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FSettings";
            ShowInTaskbar = false;
            Text = "Settings";
            FormClosing += FSettings_FormClosing;
            Load += FSettings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public CheckBox Debug;
    }
}