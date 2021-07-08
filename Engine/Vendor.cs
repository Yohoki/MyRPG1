using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Vendor : LivingCreature
    {
        //public int ID_Number { get; protected set; }
        public int[] LocationXY { get; protected set; }
        public Vendor(int id_Number, string name, string description, int hp, int mp, int attackRolls, int[] attackDamage, int attackModifier, int exp, int level, int gold, int[] locationXY)
                : base(id_Number, name, description, hp, mp, attackRolls, attackDamage, attackModifier, exp, level, gold)
        {
            //ID_Number = id_Number;
            LocationXY = locationXY;
        }
    }
}
