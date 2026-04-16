using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULE.editor
{
    public class Layer
    {
        public int Zlayer { get; set; }
        public bool Visible { get; set; }
        public int GridSize { get; set; }

        public bool navmeshsurface = false;
        public bool enablecollisions = false;

        public void UpdateCombobox(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            foreach (var layer in Layers.LayerList)
            {
                comboBox.Items.Add("Layer " + layer.Zlayer);
            }
        }
    }
    public class Layers
    {
        public static List<Layer> LayerList = new List<Layer>();
    }
}
