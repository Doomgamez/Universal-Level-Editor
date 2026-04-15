using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULE.editor
{
    internal class Consts
    {
        public static string Dirpath = System.IO.Path.Combine(SpecialDirectories.MyDocuments, ".ULE_Projects");
        public static string GetProjFolder()
        {
            return System.IO.Path.Combine(Dirpath, EditorData.settings.projectname);
        }

        public static long version = 0;
    }
}
