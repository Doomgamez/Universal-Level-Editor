using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
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
    public partial class FFile : Form
    {
        public FFile()
        {
            InitializeComponent();
        }

        public static void SaveNow()
        {
            Json a = new Json();
            a.items.layers = Layers.LayerList;
            a.items.level = LevelData.getleveldata().level;

            int i = 1;
            foreach (var item in ResourceClass.ResourceList)
            {
                ResourceClass.awesomedick.TryGetValue(item.id,out string str);
                a.res.Add(new Json.OutputResource(i, Path.GetFileName(str)));
                i = i + 1;
            }
            JsonSerializer serializer = new JsonSerializer();
            serializer.Converters.Add(new JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;

            using (StreamWriter sw = new StreamWriter(Path.Combine(Consts.GetProjFolder(), EditorData.settings.projectname + ".json")))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, new
                {
                    res = a.res,
                    items = new
                    {
                        layers = a.items.layers,
                        level = a.items.level
                    }
                });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveNow();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void FFile_Load(object sender, EventArgs e)
        {
            label1.Text = "Project Directory : " + Consts.GetProjFolder();
            label1.Font = new Font("Arial", 8);
            label1.AutoEllipsis = true;
        }
    }
}
