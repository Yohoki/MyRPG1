using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class Weapon : Item
    {
        public int[] Damage { get; protected set; }
        public int Modifier { get; protected set; }
        public int Rolls { get; protected set; }

        public Weapon(int id_Number, string name, string description, int[] price, int rolls, int[] damage, int modifier = 0, bool isItemSellable = true, bool isItemHidden = false, bool isItemEssential = false)
               : base( id_Number, name, description, price, isItemSellable, isItemHidden, isItemEssential)
        {
            Rolls = rolls;
            Damage = damage;
            Modifier = modifier;
        }
    }
}
