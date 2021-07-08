using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public partial class Player : LivingCreature
    {
        //public int ID_Number { get; protected set; }
        public Location _Location { get; protected set; }
        public int _MapLevel { get; protected set; }
        public int[] _Coords { get; protected set; } //{x,y}
        public Monster MonsterBeingFought { get; /*protected*/ set; } // DEBUG Not Protected for debug reasons.

        public Player(int id_Number, string name, string description, int hp, int mp, int attackRolls,
                      int[] attackDamage, int attackModifier, int exp, int level, int gold, Location location)
              : base (id_Number = 999999, name = "Hero", description = "The Hero of the World", hp, mp, attackRolls, attackDamage,
                      attackModifier, exp, level, gold)
        {
            _Location = location;
            //ID_Number = id_Number;
        }

        public static Player SpawnDefaultPlayer()
        {
            Player newPlayer = new(99999, "Hero", "Hero of the world", 20, 10, 1, World.D4, 0, 0, 1, 10, World.LocationByID(World.LOCATION_ID_CITY1_STREET3) );
            return newPlayer;
        }
    }
}
