using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Item : IComparable<Item>
    {
        public int ID_Number { get; protected set; }
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public int[] Price { get; protected set; } // [Buy,Sell]
        public bool IsItemSellable { get; protected set; } // default=true;
        public bool IsItemHidden { get; protected set; } // default=false;
        public bool IsItemEssential { get; protected set; } // default=false;

        public Item(int id_Number, string name, string description, int[] price, bool isItemSellable = true, bool isItemHidden = false, bool isItemEssential = false)
        {
            ID_Number       = id_Number;
            Name            = name;
            Description     = description;
            Price           = price;
            IsItemSellable  = isItemSellable;
            IsItemHidden    = isItemHidden;
            IsItemEssential = isItemEssential;
        }

        public int CompareTo(Item other)
        {
            return ID_Number.CompareTo(other.ID_Number);
        }
    }
}
