using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monster : LivingCreature
    {
        public Monster(int id_Number, string name, string description, int hp, int mp, int attackRolls, int[] attackDamage, int attackModifier, int exp, int level, int gold)
                : base(id_Number, name, description, hp, mp, attackRolls, attackDamage, attackModifier, exp, level, gold)
        {
        }
        //internal Monster NewInstanceOfMonster()
        // This should be 'internal' so that only the engine handles mob-spawning. Set to 'public' for debugging.
        // DEBUG
        public Monster NewInstanceOfMonster()
        {
            Monster newMonster =
                new(ID_Number, Name, Description, HP, MP, AttackRolls, AttackDamage, AttackModifier, EXP, Level, Gold);
            foreach (KeyValuePair<Item, int> item in Creature_Inventory.InventoryItems)
            {
                newMonster.Creature_Inventory.AddItem(item.Key, item.Value);
            }
            foreach (KeyValuePair<string, Item> item in Creature_Inventory.EquippedItems)
            {
                newMonster.Creature_Inventory.EquipItem(item.Key, item.Value);
            }
            return newMonster;
        }
    }
}
