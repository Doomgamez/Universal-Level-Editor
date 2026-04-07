using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULE.utils
{
    public class Math
    {
        public class Vector2I
        {
            public int X { get; set; }
            public int Y { get; set; }
            public Vector2I(int x, int y)
            {
                X = x;
                Y = y;
            }
            public override string ToString()
            {
                return $"({X}, {Y})";
            }
        }
        public class Vector2
        {
            public float X { get; set; }
            public float Y { get; set; }
            public Vector2(float x, float y)
            {
                X = x;
                Y = y;
            }
            public override string ToString()
            {
                return $"({X}, {Y})";
            }
        }
    }
}
