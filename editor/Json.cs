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
        public class Resources
        {
            public int id { get; set; }
            public string path { get; set; }

            public Resources(int id, string path)
            {
                this.id = id;
                this.path = path;
            }
        }

        public List<Resources> res { get; set; } = new();

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
                    ResourceClass.ResourceList.Add(new Resource(Path.Combine(Consts.GetProjFolder(), Path.GetFileName(item.path)), ResourceType.Texture, item.path, (Bitmap)Bitmap.FromFile(Path.Combine(Consts.GetProjFolder(), item.path))));
                }

                foreach (var obj in LevelData.current.level.Objarr)
                {
                    if (obj.resource == null) continue;

                    var match = ResourceClass.ResourceList
                        .FirstOrDefault(r => Path.GetFileName(r.Path) == Path.GetFileName(obj.resource.Path));

                    if (match != null)
                        obj.resource = match;
                }

                foreach (var tile in LevelData.current.level.Grid)
                {
                    if (tile.resource == null) continue;

                    var match = ResourceClass.ResourceList
                        .FirstOrDefault(r => Path.GetFileName(r.Path) == Path.GetFileName(tile.resource.Path));

                    if (match != null)
                        tile.resource = match;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
