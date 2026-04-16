using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ULE.editor
{
    public class Json
    {
        public class OutputResource
        {
            public int id { get; set; }
            public string path { get; set; }

            public OutputResource(int id, string path)
            {
                this.id = id;
                this.path = path;
            }
        }

        public List<OutputResource> res { get; set; } = new();

        public class Items
        {
            public LevelData.Level level { get; set; }
            public List<Layer> layers { get; set; }
        }

        public Items items { get; set; } = new Items();
    }
    public class ImportSave()
    {
        public static void Try2ImportSave()
        {
            ResourceClass.ResourceList.Clear();
            try
            {
                Json Awesomefuckingbuttfuck = new Json();
                Awesomefuckingbuttfuck = JsonConvert.DeserializeObject<Json>(File.ReadAllText(Path.Combine(Consts.GetProjFolder(), EditorData.settings.projectname + ".json")));

                if (Awesomefuckingbuttfuck == null)
                {
                    throw new Exception("null");
                }

                LevelData.current.level = Awesomefuckingbuttfuck.items.level;
                Layers.LayerList = Awesomefuckingbuttfuck.items.layers;

                foreach (var item in Awesomefuckingbuttfuck.res)
                {
                    ResourceClass.ResourceList.Add(new Resource(ResourceType.Texture, (Bitmap)Bitmap.FromFile(Path.Combine(Consts.GetProjFolder(), item.path)), item.id));
                }

                foreach (var obj in LevelData.current.level.Objarr)
                {
                    if (obj.resource == null) continue;

                    var match = ResourceClass.ResourceList
                        .FirstOrDefault(r => r.id == obj.resource.id);

                    if (match != null)
                        obj.resource = match;
                }

                foreach (var tile in LevelData.current.level.Grid)
                {
                    if (tile.resource == null) continue;

                    var match = ResourceClass.ResourceList
                        .FirstOrDefault(r => r.id == tile.resource.id);

                    if (match != null)
                        tile.resource = match;
                }
            }
            catch (FileNotFoundException) { }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
