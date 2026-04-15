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

        private void button1_Click(object sender, EventArgs e)
        {
            Json a = new Json();
            a.items.layers = Layers.LayerList;
            a.items.level = LevelData.getleveldata().level;

            int i = 1;
            foreach (var item in ResourceClass.ResourceList)
            {
                a.res.Add(new Json.Resources(i, Path.GetFileName(item.Path)));
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
    }
}
