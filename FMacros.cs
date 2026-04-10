using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULE.editor;

namespace ULE
{
    public partial class FMacros : Form
    {
        public FMacros()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                DialogResult dr = MessageBox.Show("This will enable macros, which can be used to automate tasks in the editor.\nHowever, be aware that macros can potentially contain malicious code.\n\nOnly enable macros if you trust the source of the macros you intend to use.\n(are you sure you want to enable them?)", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    EditorData.settings.macrosenabled = true;
                }
                else
                {
                    checkBox1.Checked = false;
                    EditorData.settings.macrosenabled = false;
                }
            }
        }

        private void FMacros_Load(object sender, EventArgs e)
        {
            
        }

        private void FMacros_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void FMacros_Shown(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                foreach (var item in Directory.GetFiles("plugins/", "*.dll"))
                {
                    var asm = Assembly.LoadFrom(item);
                    int x = 1;
                    flowLayoutPanel1.Controls.Clear();

                    foreach (var type in asm.GetTypes())
                    {
                        if (typeof(ULEPLUGIN).IsAssignableFrom(type) && !type.IsAbstract)
                        {
                            try
                            {
                                var instance = Activator.CreateInstance(type);
                                ((ULEPLUGIN)instance).Init();
                                Label label = new Label();
                                label.Text = $"Loaded plugin: {type.FullName}";
                                label.AutoSize = true;
                                label.Location = new Point(30, 20 * x);
                                flowLayoutPanel1.Controls.Add(label);
                                flowLayoutPanel1.SetFlowBreak(label, true);
                            }
                            catch (Exception ex)
                            {
                                Form1.logger.Log(ex.Message);
                            }
                        }
                        x = x + 1;
                    }
                }
            }
        }
    }
}
