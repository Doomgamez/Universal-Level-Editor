using ULE.editor;
using static ULE.utils.Math;
using static ULE.utils.specialobjectenums;

public class LevelData
{
    public static LevelData current = new LevelData();
    public static uint version { get; set; }
    public static string loadedpath { get; set; }
    public Level level { get; set; } = new Level();

    public class Gridobj
    {
        public int layer { get; set; } = 0;
        public Vector2I position { get; set; } = new Vector2I(0, 0);
        public Vector2I size { get; set; } = new Vector2I(0, 0);
        public int objtype { get; set; }
        public SpecialClass metadata { get; set; }
        public Resource resource { get; set; }
    }

    public class Object
    {
        public int layer { get; set; } = 0;
        public Vector2 position { get; set; } = new Vector2(0, 0);
        public Vector2 size { get; set; } = new Vector2(0, 0);
        public int objtype { get; set; }
        public SpecialClass metadata { get; set; }
        public Resource resource { get; set; }
    }

    public class Level
    {
        public List<Gridobj> Grid { get; set; } = new List<Gridobj>();
        public List<Object> Objarr { get; set; } = new List<Object>();
    }

    public static void applyleveldata(LevelData lvl)
    {
        if (lvl?.level == null) return;

        current.level = lvl.level;
    }

    public static LevelData getleveldata()
    {
        return new LevelData
        {
            level = current.level
        };
    }
}