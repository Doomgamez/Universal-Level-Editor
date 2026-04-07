using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULE.editor
{
    public enum ResourceType
    {
        Texture,
        Sound
    }

    public class Resource
    {
        public static List<Resource> Resources = new List<Resource>();
        public string Name { get; set; }
        public ResourceType Type { get; set; }
        public string Path { get; set; }
        public Resource(string name, ResourceType type, string path)
        {
            Name = name;
            Type = type;
            Path = path;
        }
    }
} 
