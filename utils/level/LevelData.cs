using ULE.editor;
using static ULE.utils.Math;
using static ULE.utils.specialobjectenums;

namespace ULE.utils.level
{
    internal class LevelData
    {
        public static uint version;
        public static string loadedpath;
        public static Level level = new Level();
        public class Gridobj
        {
            public int layer = 0;
            public Vector2I position = new Vector2I(0, 0);
            public Vector2I size = new Vector2I(0, 0);
            public int objtype;
            public SpecialClass metadata;
            public Resource resource;
        }
        public class Object
        {
            public int layer = 0;
            public Vector2 position = new Vector2(0, 0);
            public Vector2 size = new Vector2(0, 0);
            public int objtype;
            public SpecialClass metadata;
            public Resource resource;
        }
        public class Level
        {
            public List<Gridobj> Grid = new List<Gridobj>();
            public List<Object> Objarr = new List<Object>();
            public Level LoadLevel(string path)
            {
                throw new NotImplementedException();
                return level;
            }

            public Level SaveLevel(string path)
            {
                throw new NotImplementedException();
                return level;
            }

            public Level ExportLevel(string path)
            {
                throw new NotImplementedException();
                return level;
            }
        }
    }
}
