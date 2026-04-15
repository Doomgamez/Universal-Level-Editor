using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Newtonsoft.Json;
namespace ULE.editor
{
    public enum ResourceType
    {
        Texture
    }

    public class Resource
    {
        public string Name { get; set; }
        public ResourceType Type { get; set; }
        [JsonIgnore]
        public Bitmap Texture { get; set; }
        public string Path { get; set; }
        public Resource(string name, ResourceType type, string path,Bitmap Texture)
        {
            this.Name = name;
            this.Type = type;
            this.Path = path;
            this.Texture = Texture;
        }
    }
    public static class ResourceClass
    {
        public static List<Resource> ResourceList = new List<Resource>();
    }
} 
