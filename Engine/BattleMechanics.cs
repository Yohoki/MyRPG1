using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public partial class Player
    {
        public void Battle_PlayerAttack()
        {
            MonsterBeingFought.HP -= Battle_CalcDamage(this);
            if (MonsterBeingFought.HP > 0) { Battle_MonsterAttack(); }
        }
        public void Battle_MonsterAttack()
        {
            HP -= Battle_CalcDamage(MonsterBeingFought);
        }

        public int Battle_CalcDamage(LivingCreature Temp)
        {

            if (Temp.Creature_Inventory.EquippedItems.TryGetValue("MainHand", out Item TempWeapon))
            {
                Weapon weapon = (Weapon)World.ItemByID(TempWeapon.ID_Number);
                return RollDice.Roll(weapon.Rolls, weapon.Damage) + weapon.Modifier;
                //return 20;
            }
            if (!Creature_Inventory.EquippedItems.ContainsKey("MainHand"))
            {
                return RollDice.Roll(AttackRolls, AttackDamage) + AttackModifier;
            }
            return 0;
        }
    }
}
