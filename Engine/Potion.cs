using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
   class Potion : Item
    {
        public int[] HealAmount { get; protected set; }
        public int Modifier { get; protected set; }
        public int Rolls { get; protected set; }
        public bool TargetPlayer { get; protected set; }

        public Potion(int id_Number, string name, string description, int[] price, int rolls, int[] healAmount, int modifier = 0, bool isItemSellable = true, bool isItemHidden = false, bool isItemEssential = false, bool targetPlayer = true)
               : base(id_Number, name, description, price, isItemSellable, isItemHidden, isItemEssential)
        {
            Rolls = rolls;
            Modifier = modifier;
            HealAmount = healAmount;
            TargetPlayer = targetPlayer;
        }
}
}
