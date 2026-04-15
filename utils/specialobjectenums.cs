using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULE.utils
{
    public class specialobjectenums
    {
        public class SpecialClass
        {
            public List<int> intarr = new List<int>();
            public specialobjectenums.specialenums specialtype;

            public bool AddData(int data)
            {
                intarr.Add(data);
                return true;
            }

            public bool PopData(int position)
            {
                try
                {
                    intarr.RemoveAt(position);
                    return true;
                }
                catch (Exception)
                {

                }
                return false;
            }
        }
        public enum specialenums
        {
            Player,
            Light,
            Enemy,
            Navmesh,
            Portal
        };
    }
}
