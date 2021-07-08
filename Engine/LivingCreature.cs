using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class LivingCreature
    {
        public int ID_Number { get; protected set; }
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public int HP { get; set; }
        public int MP { get; protected set; }
        public int AttackRolls { get; protected set; }
        public int[] AttackDamage { get; protected set; }
        public int AttackModifier { get; protected set; }
        public int EXP { get; protected set; }
        public int Level { get; protected set; }
        public Inventory Creature_Inventory = new();
        public int Gold { get; protected set; }

        public LivingCreature(int id_Number, string name, string description, int hp, int mp, int attackRolls, int[] attackDamage, int attackModifier, int exp, int level, int gold)
        {
            ID_Number = id_Number;
            Name = name;
            Description = description;
            HP = hp;
            MP = mp;
            AttackRolls = attackRolls;
            AttackDamage = attackDamage;
            AttackModifier = attackModifier;
            EXP = exp;
            Level = level;
            Gold = gold;
        }
    }
}
