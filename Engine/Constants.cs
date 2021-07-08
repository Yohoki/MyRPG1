using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static partial class World
    {
        #region Die Values
        public static readonly int[] D100, Percentile = { 1, 101 };
        public static readonly int[] D20 = { 1, 21 };
        public static readonly int[] D12 = { 1, 13 };
        public static readonly int[] D10 = { 1, 11 };
        public static readonly int[] D8 = { 1, 9 };
        public static readonly int[] D6 = { 1, 7 };
        public static readonly int[] D4 = { 1, 5 };
        public static readonly int[] D2 = { 1, 3 };
        #endregion
        #region Item IDs
        //Item IDs
        public const int ITEM_ID_RUSTY_SWORD            = 1;
        public const int ITEM_ID_RAT_TAIL               = 2;
        public const int ITEM_ID_PIECE_OF_FUR           = 3;
        public const int ITEM_ID_SNAKE_FANG             = 4;
        public const int ITEM_ID_SNAKESKIN              = 5;
        public const int ITEM_ID_CLUB                   = 6;
        public const int ITEM_ID_WEAK_HEALING_POTION    = 7;
        public const int ITEM_ID_SPIDER_FANG            = 8;
        public const int ITEM_ID_SPIDER_SILK            = 9;
        public const int ITEM_ID_FAKE_ADVENTURER_PASS   = 10;
        public const int ITEM_ID_ADVENTURER_PASS        = 11;
        public const int ITEM_ID_RUSTY_SWORD2           = 12;
        #endregion
        #region Monster IDs
        //Monster IDs
        public const int MONSTER_ID_RAT             = 1;
        public const int MONSTER_ID_SNAKE           = 2;
        public const int MONSTER_ID_GIANT_SPIDER    = 3;
        #endregion
        #region Vendor IDs
        // Vendor IDs
        public const int VENDOR_ID_TESTY = 1;
        #endregion
        #region Location IDs
        // World=00XXX, City1=01XXX, Dungeon1=02XXX,
        #region World IDs (5x4) 00xxx
        public const int LOCATION_ID_WORLD_FIELD1               = 00001;
        public const int LOCATION_ID_WORLD_FIELD2               = 00002;
        public const int LOCATION_ID_WORLD_FIELD3               = 00003;
        public const int LOCATION_ID_WORLD_FIELD4               = 00004;
        public const int LOCATION_ID_WORLD_DUNGEON1_ENTRANCE    = 00005;
        public const int LOCATION_ID_WORLD_FIELD5               = 00006;
        public const int LOCATION_ID_WORLD_FIELD6               = 00007;
        public const int LOCATION_ID_WORLD_FIELD7               = 00008;
        public const int LOCATION_ID_WORLD_CITY1_ENTRANCE       = 00009;
        public const int LOCATION_ID_WORLD_RIVERBANK1           = 00010;
        public const int LOCATION_ID_WORLD_MOUNTAIN_BASE1       = 00011;
        public const int LOCATION_ID_WORLD_MOUNTAIN_SUMMIT1     = 00012;
        public const int LOCATION_ID_WORLD_MOUNTAIN_BASE2       = 00013;
        public const int LOCATION_ID_WORLD_BRIDGE1_OVER_RIVER1  = 00014;
        public const int LOCATION_ID_WORLD_FIELD8               = 00015;
        public const int LOCATION_ID_WORLD_FIELD9               = 00016;
        public const int LOCATION_ID_WORLD_FIELD10              = 00017;
        public const int LOCATION_ID_WORLD_RIVERBANK2           = 00018;
        public const int LOCATION_ID_WORLD_RIVERBANK3           = 00019;
        public const int LOCATION_ID_WORLD_FIELD11              = 00020;
        #endregion
        #region City1 IDs (5x5) 01xxx
        public const int LOCATION_ID_CITY1_YARD1                = 01001;
        public const int LOCATION_ID_CITY1_EXIT1                = 01002;
        public const int LOCATION_ID_CITY1_VENDOR1              = 01003;
        public const int LOCATION_ID_CITY1_HOUSE1               = 01004;
        public const int LOCATION_ID_CITY1_STREET1              = 01005;
        public const int LOCATION_ID_CITY1_HOUSE2               = 01006;
        public const int LOCATION_ID_CITY1_EXIT2                = 01007;
        public const int LOCATION_ID_CITY1_STREET2              = 01008;
        public const int LOCATION_ID_CITY1_STREET3              = 01009;
        public const int LOCATION_ID_CITY1_STREET4              = 01010;
        public const int LOCATION_ID_CITY1_PLAYER_HOUSE         = 01011;
        public const int LOCATION_ID_CITY1_LARGE_HOUSE1         = 01012;
        public const int LOCATION_ID_CITY1_LARGE_HOUSE2         = 01013;
        public const int LOCATION_ID_CITY1_YARD2                = 01014;
        public const int LOCATION_ID_CITY1_LARGE_HOUSE3         = 01015;
        public const int LOCATION_ID_CITY1_LARGE_HOUSE4         = 01016;
        public const int LOCATION_ID_CITY1_YARD3                = 01017;
        #endregion
        #region Dungeon1 IDs (5x4) 02xxx
        public const int LOCATION_ID_DUNGEON1_EXIT1             = 02001;
        public const int LOCATION_ID_DUNGEON1_CAVE1             = 02002;
        public const int LOCATION_ID_DUNGEON1_GREAT_TREASURE1   = 02003;
        public const int LOCATION_ID_DUNGEON1_BOSS              = 02004;
        public const int LOCATION_ID_DUNGEON1_CAVE2             = 02005;
        public const int LOCATION_ID_DUNGEON1_CAVE3             = 02006;
        public const int LOCATION_ID_DUNGEON1_CAVE4             = 02007;
        public const int LOCATION_ID_DUNGEON1_TREASURE1         = 02008;
        public const int LOCATION_ID_DUNGEON1_CAVE5             = 02009;
        public const int LOCATION_ID_DUNGEON1_CAVE6             = 02010;
        public const int LOCATION_ID_DUNGEON1_TREASURE2         = 02011;
        public const int LOCATION_ID_DUNGEON1_CAVE7             = 02012;
        public const int LOCATION_ID_DUNGEON1_CAVE8             = 02013;
        public const int LOCATION_ID_DUNGEON1_CAVE9             = 02014;
        public const int LOCATION_ID_DUNGEON1_MINIBOSS1         = 02015;
        public const int LOCATION_ID_DUNGEON1_TREASURE3         = 02016;
        public const int LOCATION_ID_DUNGEON1_CAVE10            = 02017;
        public const int LOCATION_ID_DUNGEON1_GREAT_TREASURE2   = 02018;
        public const int LOCATION_ID_DUNGEON1_CAVE11            = 02019;
        public const int LOCATION_ID_DUNGEON1_CAVE12            = 02020;
        #endregion
        #endregion
    }
}
