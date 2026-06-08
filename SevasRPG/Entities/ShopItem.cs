using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevasRPG.Entities
{
    class ShopItem
    {
        public object Item { get; set; }
        public int Price { get; set; }
        public string DisplayText { get; set; }

        public override string ToString() => DisplayText;
    }
}
