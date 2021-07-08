using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class RollDice
    {
        private static Random _rand = new();
        public static int Roll(int number, int[] die)
        {
            //var rand = new Random();
            int Roll=0;
            
            for ( int i = 0; number > i; i++ )
            {
                Roll += _rand.Next(die[0], die[1]);
            }
            
            return Roll;
        }
        public static int Roll(int[] die)
        {
            //var rand = new Random();
            int Roll = 0;

            Roll += _rand.Next(die[0], die[1]);

            return Roll;
        }
    }
}
