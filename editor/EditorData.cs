using static ULE.utils.Math;
using LA = ULE.editor.Layers;

namespace ULE.editor
{
    public static class EditorData
    {
        public class EditorSettings
        {
            public bool showgrid = true;
            public bool snaptoGrid = false;
            public Layer selectedlayer;
            public Resource selectedresource;
            public bool debug = false;
            public bool previewmode = false;
            public bool macrosenabled = false;
        }

        public static EditorSettings settings = new EditorSettings();

        public class EditorState
        {
            public Vector2I offset = new Vector2I(0, 0);
            public bool focused()
            {
                var form = Form.ActiveForm;
                if (form == null) return false;

                var control = form.Controls.Find("pictureBox1", true).FirstOrDefault();

                return control != null && control.Focused;
            }
            public bool debug = true;
            public bool isDragging;
        }

        public static EditorState state = new EditorState();
    }
}
