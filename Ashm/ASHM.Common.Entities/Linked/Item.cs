using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASHM.Common.Entities
{
    public class Item
    {
        public Item() { }
   
        public Item(int i, string s)
        {
            Index = i;
            Label = s;
        }

        public int Index { get; set; }

        public string Label { get; set; }
    }
}
