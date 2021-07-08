using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static partial class World
    {
        public static readonly List<Location> Locations = new();

        private static void PopulateLocations()
        {
            #region Create new locations for City1 
            Locations.AddRange(new List<Location>
            {
                new (LOCATION_ID_CITY1_YARD1, "Yard 1", "A small field. The farmer's family are growing a variety of vegetables here.",
                                  new[] { 2, 0 }, 1, null, null),
                new(LOCATION_ID_CITY1_EXIT1, "Exit 1", "You are now at the northern city gates. There's a dirt path south of you.",
                                  new[] { 2, 1 }, 1, null, null, true),
                new(LOCATION_ID_CITY1_VENDOR1, "Vendor 1", "A small shop. The shelves are mostly filled with food." +
                                  "You can't expect much more from such a small village.",
                                  new[] { 1, -1 }, 1, null, null),
                new(LOCATION_ID_CITY1_HOUSE1, "House 1", "A small house. A farmer and his family live here. " +
                                  "There is a yard to north of the house and a dirt path to the south.",
                                  new[] { 1, 0 }, 1, MonsterByID(MONSTER_ID_RAT), null),
                new(LOCATION_ID_CITY1_STREET1, "Street 1", "A dirt road. Hard on the feet and barely even a trail. Mostly just bare ground where villagers " +
                                  "have passed between houses. You can see the village entrance to the north and a small house to the east",
                                  new[] { 1, 1 }, 1, null, null),
                new(LOCATION_ID_CITY1_HOUSE2, "House 2", "A small house. Not much more than a hut. You don't think anyone's lived here in a while..." +
                                  "except for the rats!",
                                  new[] { 1, 2 }, 1, null, null),
                new(LOCATION_ID_CITY1_EXIT2, "Exit 2", "You are now at the western city gates. There's a dirt path to your east.",
                                  new[] { 0, -2 }, 1, null, null, true),
                new(LOCATION_ID_CITY1_STREET2, "Street 2", "A well traveled path. You can tell many people and animals have passed through here." +
                                  "There is a merchant to the north and another path to the east.",
                                  new[] { 0, -1 }, 1, null, null),
                new(LOCATION_ID_CITY1_STREET3, "Street 3", "A wealthy looking plaza. The path continues east. There is also a small house to the north " +
                                  "and a large house to the south.",
                                  new[] { 0, 0 }, 1, null, null),
                new(LOCATION_ID_CITY1_STREET4, "Street 4", "A corner road. Your house is to the east. The road continues to the north and west.",
                                  new[] { 0, 1 }, 1, null, null),
                new(LOCATION_ID_CITY1_PLAYER_HOUSE, "Player's House", "Your house. There's not a lot here, but it's all yours.",
                                  new[] { 0, 2 }, 1, null, null),
                new(LOCATION_ID_CITY1_LARGE_HOUSE1, "Large House 1", "A wealthy looking bedroom. A large bed, nightstand and wardrobes. The shelves have many colored bottles with liquids in them" +
                                  "There is another room to the south and the entrance is to the east.",
                                  new[] { -1, -1 }, 1, null, null),
                new(LOCATION_ID_CITY1_LARGE_HOUSE2, "Large House 2", "A very large house for such a small village. Someone wealthy must live here. " +
                                  "You can see another room to the west and a flower garden to the east.",
                                  new[] { -1, 0 }, 1, null, null),
                new(LOCATION_ID_CITY1_YARD2, "Yard 2", "A large flower garden. There are many beautiful plants growing here... Many of which are very poisonous... " + 
                                  "You wonder how the owner come to be so rich.... The house is to the east and more garden is to the south.",
                                  new[] { -1, 1 }, 1, null, null),
                new(LOCATION_ID_CITY1_LARGE_HOUSE3, "Large House 3", "A large library. There are all kinds of books on flowers, their habitats and how to find and grow them." +
                                  " There's also books on medicines, poisons, distilation and brewing of potions. To the east there is a... kitchen?... and a bedroom north.",
                                  new[] { -2, -1 }, 1, null, null),
                new(LOCATION_ID_CITY1_LARGE_HOUSE4, "Large House 4", "A small cooking room. Filled to the brim with things you recognize. Pots, fuel, matches, cups, bottles, plates, paper." +
                                  "Also filled with many things you do not. Tubes and barrels and boxes of equipment. All the makings of a potion maker. " +
                                  "There is a garden to the east, a library westward and the entrance to the north.",
                                  new[] { -2, 0 }, 1, null, null),
                new(LOCATION_ID_CITY1_YARD3, "Yard 3", "A flower large flower garden. Small herbs and bushes that you've seen on your travels, but have no idea how to use." +
                                  "There is more to the garden to the north. The house is to your west.",
                                  new[] { -2, 1 }, 1, null, null)
            });
            #endregion
            #region Add Connections for City1
            LocationByID(LOCATION_ID_CITY1_YARD1).ConnectLocation(new[]   { LocationByID(LOCATION_ID_CITY1_HOUSE1) });
            LocationByID(LOCATION_ID_CITY1_EXIT1).ConnectLocation(new[]   { LocationByID(LOCATION_ID_CITY1_STREET1) });
            LocationByID(LOCATION_ID_CITY1_VENDOR1).ConnectLocation(new[] { LocationByID(LOCATION_ID_CITY1_STREET2) });
            LocationByID(LOCATION_ID_CITY1_HOUSE1).ConnectLocation(new[]  { LocationByID(LOCATION_ID_CITY1_STREET3),
                                                                            LocationByID(LOCATION_ID_CITY1_YARD1) });
            LocationByID(LOCATION_ID_CITY1_STREET1).ConnectLocation(new[] { LocationByID(LOCATION_ID_CITY1_EXIT1),
                                                                            LocationByID(LOCATION_ID_CITY1_HOUSE2),
                                                                            LocationByID(LOCATION_ID_CITY1_STREET4) });
            LocationByID(LOCATION_ID_CITY1_HOUSE2).ConnectLocation(new[]  { LocationByID(LOCATION_ID_CITY1_STREET1) });
            LocationByID(LOCATION_ID_CITY1_EXIT2).ConnectLocation(new[]   { LocationByID(LOCATION_ID_CITY1_STREET2) });
            LocationByID(LOCATION_ID_CITY1_STREET2).ConnectLocation(new[] { LocationByID(LOCATION_ID_CITY1_VENDOR1),
                                                                            LocationByID(LOCATION_ID_CITY1_EXIT2),
                                                                            LocationByID(LOCATION_ID_CITY1_STREET3) });
            LocationByID(LOCATION_ID_CITY1_STREET3).ConnectLocation(new[] { LocationByID(LOCATION_ID_CITY1_STREET2),
                                                                            LocationByID(LOCATION_ID_CITY1_HOUSE1),
                                                                            LocationByID(LOCATION_ID_CITY1_STREET4),
                                                                            LocationByID(LOCATION_ID_CITY1_LARGE_HOUSE2) });
            LocationByID(LOCATION_ID_CITY1_STREET4).ConnectLocation(new[] { LocationByID(LOCATION_ID_CITY1_STREET1),
                                                                            LocationByID(LOCATION_ID_CITY1_STREET3),
                                                                            LocationByID(LOCATION_ID_CITY1_PLAYER_HOUSE) });
            LocationByID(LOCATION_ID_CITY1_PLAYER_HOUSE).ConnectLocation(new[] { LocationByID(LOCATION_ID_CITY1_STREET4) });
            LocationByID(LOCATION_ID_CITY1_LARGE_HOUSE1).ConnectLocation(new[] { LocationByID(LOCATION_ID_CITY1_LARGE_HOUSE2),
                                                                            LocationByID(LOCATION_ID_CITY1_LARGE_HOUSE3) });
            LocationByID(LOCATION_ID_CITY1_LARGE_HOUSE2).ConnectLocation(new[] { LocationByID(LOCATION_ID_CITY1_LARGE_HOUSE1),
                                                                            LocationByID(LOCATION_ID_CITY1_STREET3),
                                                                            LocationByID(LOCATION_ID_CITY1_YARD2) });
            LocationByID(LOCATION_ID_CITY1_YARD2).ConnectLocation(new[]   { LocationByID(LOCATION_ID_CITY1_LARGE_HOUSE2),
                                                                            LocationByID(LOCATION_ID_CITY1_YARD3) });
            LocationByID(LOCATION_ID_CITY1_LARGE_HOUSE3).ConnectLocation(new[] {  LocationByID(LOCATION_ID_CITY1_LARGE_HOUSE1),
                                                                            LocationByID(LOCATION_ID_CITY1_LARGE_HOUSE4) });
            LocationByID(LOCATION_ID_CITY1_LARGE_HOUSE4).ConnectLocation(new[] { LocationByID(LOCATION_ID_CITY1_LARGE_HOUSE2),
                                                                            LocationByID(LOCATION_ID_CITY1_YARD3) });
            LocationByID(LOCATION_ID_CITY1_YARD3).ConnectLocation(new[]   { LocationByID(LOCATION_ID_CITY1_LARGE_HOUSE4),
                                                                            LocationByID(LOCATION_ID_CITY1_YARD2) });
            #endregion
            #region Create new locations for Dungeon1
            Locations.AddRange(new List<Location>
            {
                new (LOCATION_ID_DUNGEON1_EXIT1, "", "",
                                  new[] { 2, -2 }, 2, null, null, true),
                new (LOCATION_ID_DUNGEON1_CAVE1, "", "",
                                  new[] { 2, -1 }, 2, null, null),
                new (LOCATION_ID_DUNGEON1_GREAT_TREASURE1, "", "",
                                  new[] { 2, 0 }, 2, null, null),
                new (LOCATION_ID_DUNGEON1_BOSS, "", "",
                                  new[] { 2, 1 }, 2, null, null),
                new (LOCATION_ID_DUNGEON1_CAVE2, "", "",
                                  new[] { 2, 2 }, 2, null, null),
                new (LOCATION_ID_DUNGEON1_CAVE3, "", "",
                                  new[] { 1, -2 }, 2, null, null),
                new (LOCATION_ID_DUNGEON1_CAVE4, "", "",
                                  new[] { 1, -1 }, 2, null, null),
                new (LOCATION_ID_DUNGEON1_TREASURE1, "", "",
                                  new[] { 1, 0 }, 2, null, null),
                new (LOCATION_ID_DUNGEON1_CAVE5, "", "",
                                  new[] { 1, 1 }, 2, null, null),
                new (LOCATION_ID_DUNGEON1_CAVE6, "", "",
                                  new[] { 1, 2 }, 2, null, null),
                new (LOCATION_ID_DUNGEON1_TREASURE2, "", "",
                                  new[] { 0, -2 }, 2, null, null),
                new (LOCATION_ID_DUNGEON1_CAVE7, "", "",
                                  new[] { 0, -1 }, 2, null, null),
                new (LOCATION_ID_DUNGEON1_CAVE8, "", "",
                                  new[] { 0, 0 }, 2, null, null),
                new (LOCATION_ID_DUNGEON1_CAVE9, "", "",
                                  new[] { 0, 1 }, 2, null, null),
                new (LOCATION_ID_DUNGEON1_MINIBOSS1, "", "",
                                  new[] { 0, 2 }, 2, null, null),
                new (LOCATION_ID_DUNGEON1_TREASURE3, "", "",
                                  new[] { -1, -2 }, 2, null, null),
                new (LOCATION_ID_DUNGEON1_CAVE10, "", "",
                                  new[] { -1, -1 }, 2, null, null),
                new (LOCATION_ID_DUNGEON1_GREAT_TREASURE2, "", "",
                                  new[] { -1, 0 }, 2, null, null),
                new (LOCATION_ID_DUNGEON1_CAVE11, "", "",
                                  new[] { -1, 1 }, 2, null, null),
                new (LOCATION_ID_DUNGEON1_CAVE12, "", "",
                                  new[] { -1, 2 }, 2, null, null)
            });
            #endregion
            #region Add connections for Dungeon1
            LocationByID(LOCATION_ID_DUNGEON1_EXIT1).ConnectLocation(new[] { LocationByID(LOCATION_ID_DUNGEON1_CAVE1) });
            LocationByID(LOCATION_ID_DUNGEON1_CAVE1).ConnectLocation(new[] { LocationByID(LOCATION_ID_DUNGEON1_CAVE4),
                                                                             LocationByID(LOCATION_ID_DUNGEON1_EXIT1) });
            LocationByID(LOCATION_ID_DUNGEON1_GREAT_TREASURE1).ConnectLocation(new[] { LocationByID(LOCATION_ID_DUNGEON1_BOSS) });
            LocationByID(LOCATION_ID_DUNGEON1_BOSS).ConnectLocation(new[] {  LocationByID(LOCATION_ID_DUNGEON1_GREAT_TREASURE1),
                                                                             LocationByID(LOCATION_ID_DUNGEON1_CAVE5) });
            LocationByID(LOCATION_ID_DUNGEON1_CAVE2).ConnectLocation(new[] { LocationByID(LOCATION_ID_DUNGEON1_CAVE6) });
            LocationByID(LOCATION_ID_DUNGEON1_CAVE3).ConnectLocation(new[] { LocationByID(LOCATION_ID_DUNGEON1_CAVE4),
                                                                             LocationByID(LOCATION_ID_DUNGEON1_TREASURE2) });
            LocationByID(LOCATION_ID_DUNGEON1_CAVE4).ConnectLocation(new[] { LocationByID(LOCATION_ID_DUNGEON1_CAVE3),
                                                                             LocationByID(LOCATION_ID_DUNGEON1_CAVE1),
                                                                             LocationByID(LOCATION_ID_DUNGEON1_CAVE7) });
            LocationByID(LOCATION_ID_DUNGEON1_TREASURE1).ConnectLocation(new[] { LocationByID(LOCATION_ID_DUNGEON1_CAVE8) });
            LocationByID(LOCATION_ID_DUNGEON1_CAVE5).ConnectLocation(new[] { LocationByID(LOCATION_ID_DUNGEON1_BOSS),
                                                                             LocationByID(LOCATION_ID_DUNGEON1_CAVE6) });
            LocationByID(LOCATION_ID_DUNGEON1_CAVE6).ConnectLocation(new[] { LocationByID(LOCATION_ID_DUNGEON1_CAVE2),
                                                                             LocationByID(LOCATION_ID_DUNGEON1_CAVE5),
                                                                             LocationByID(LOCATION_ID_DUNGEON1_MINIBOSS1) });
            LocationByID(LOCATION_ID_DUNGEON1_TREASURE2).ConnectLocation(new[] { LocationByID(LOCATION_ID_DUNGEON1_CAVE3) });
            LocationByID(LOCATION_ID_DUNGEON1_CAVE7).ConnectLocation(new[] { LocationByID(LOCATION_ID_DUNGEON1_CAVE4),
                                                                             LocationByID(LOCATION_ID_DUNGEON1_CAVE8),
                                                                             LocationByID(LOCATION_ID_DUNGEON1_CAVE10) });
            LocationByID(LOCATION_ID_DUNGEON1_CAVE8).ConnectLocation(new[] { LocationByID(LOCATION_ID_DUNGEON1_CAVE7),
                                                                             LocationByID(LOCATION_ID_DUNGEON1_TREASURE1),
                                                                             LocationByID(LOCATION_ID_DUNGEON1_CAVE9) });
            LocationByID(LOCATION_ID_DUNGEON1_CAVE9).ConnectLocation(new[] { LocationByID(LOCATION_ID_DUNGEON1_CAVE8),
                                                                             LocationByID(LOCATION_ID_DUNGEON1_MINIBOSS1) });
            LocationByID(LOCATION_ID_DUNGEON1_MINIBOSS1).ConnectLocation(new[] { LocationByID(LOCATION_ID_DUNGEON1_CAVE9),
                                                                             LocationByID(LOCATION_ID_DUNGEON1_CAVE6),
                                                                             LocationByID(LOCATION_ID_DUNGEON1_CAVE12) });
            LocationByID(LOCATION_ID_DUNGEON1_TREASURE3).ConnectLocation(new[] { LocationByID(LOCATION_ID_DUNGEON1_CAVE10) });
            LocationByID(LOCATION_ID_DUNGEON1_CAVE10).ConnectLocation(new[]{ LocationByID(LOCATION_ID_DUNGEON1_CAVE7),
                                                                             LocationByID(LOCATION_ID_DUNGEON1_TREASURE3) });
            LocationByID(LOCATION_ID_DUNGEON1_GREAT_TREASURE2).ConnectLocation(new[] { LocationByID(LOCATION_ID_DUNGEON1_CAVE11) });
            LocationByID(LOCATION_ID_DUNGEON1_CAVE11).ConnectLocation(new[]{ LocationByID(LOCATION_ID_DUNGEON1_GREAT_TREASURE2),
                                                                             LocationByID(LOCATION_ID_DUNGEON1_CAVE12) });
            LocationByID(LOCATION_ID_DUNGEON1_CAVE12).ConnectLocation(new[]{ LocationByID(LOCATION_ID_DUNGEON1_MINIBOSS1),
                                                                             LocationByID(LOCATION_ID_DUNGEON1_CAVE11) });
            #endregion
            #region Create new locations for World
            Locations.AddRange(new List<Location>
            {
                new (LOCATION_ID_WORLD_FIELD1, "", "",
                                  new[] { 3, 0 }, 0, null, null, true),
                new (LOCATION_ID_WORLD_FIELD2, "", "",
                                  new[] { 3, 1 }, 0, null, null, true),
                new (LOCATION_ID_WORLD_FIELD3, "", "",
                                  new[] { 3, 2 }, 0, null, null, true),
                new (LOCATION_ID_WORLD_FIELD4, "", "",
                                  new[] { 3, 3 }, 0, null, null, true),
                new (LOCATION_ID_WORLD_DUNGEON1_ENTRANCE, "", "",
                                  new[] { 3, 4 }, 0, null, null, true),
                new (LOCATION_ID_WORLD_FIELD5, "", "",
                                  new[] { 2, 0 }, 0, null, null, true),
                new (LOCATION_ID_WORLD_FIELD6, "", "",
                                  new[] { 2, 1 }, 0, null, null, true),
                new (LOCATION_ID_WORLD_FIELD7, "", "",
                                  new[] { 2, 2 }, 0, null, null, true),
                new (LOCATION_ID_WORLD_CITY1_ENTRANCE, "", "",
                                  new[] { 2, 3 }, 0, null, null, true),
                new (LOCATION_ID_WORLD_RIVERBANK1, "", "",
                                  new[] { 2, 4 }, 0, null, null, true),
                new (LOCATION_ID_WORLD_MOUNTAIN_BASE1, "", "",
                                  new[] { 1, 0 }, 0, null, null, true),
                new (LOCATION_ID_WORLD_MOUNTAIN_SUMMIT1, "", "",
                                  new[] { 1, 1 }, 0, null, null, true),
                new (LOCATION_ID_WORLD_MOUNTAIN_BASE2, "", "",
                                  new[] { 1, 2 }, 0, null, null, true),
                new (LOCATION_ID_WORLD_BRIDGE1_OVER_RIVER1, "", "",
                                  new[] { 1, 3 }, 0, null, null, true),
                new (LOCATION_ID_WORLD_FIELD8, "", "",
                                  new[] { 1, 4 }, 0, null, null, true),
                new (LOCATION_ID_WORLD_FIELD9, "", "",
                                  new[] { 0, 0 }, 0, null, null, true),
                new (LOCATION_ID_WORLD_FIELD10, "", "",
                                  new[] { 0, 1 }, 0, null, null, true),
                new (LOCATION_ID_WORLD_RIVERBANK2, "", "",
                                  new[] { 0, 2 }, 0, null, null, true),
                new (LOCATION_ID_WORLD_RIVERBANK3, "", "",
                                  new[] { 0, 3 }, 0, null, null, true),
                new (LOCATION_ID_WORLD_FIELD11, "", "",
                                  new[] { 0, 4 }, 0, null, null, true)
            });
            #endregion
            #region Add connections for World
            LocationByID(LOCATION_ID_WORLD_FIELD1).ConnectLocation(new[]  { LocationByID(LOCATION_ID_WORLD_FIELD2),
                                                                            LocationByID(LOCATION_ID_WORLD_FIELD5) });
            LocationByID(LOCATION_ID_WORLD_FIELD2).ConnectLocation(new[]  { LocationByID(LOCATION_ID_WORLD_FIELD1),
                                                                            LocationByID(LOCATION_ID_WORLD_FIELD3),
                                                                            LocationByID(LOCATION_ID_WORLD_FIELD6) });
            LocationByID(LOCATION_ID_WORLD_FIELD3).ConnectLocation(new[]  { LocationByID(LOCATION_ID_WORLD_FIELD4),
                                                                            LocationByID(LOCATION_ID_WORLD_FIELD2),
                                                                            LocationByID(LOCATION_ID_WORLD_FIELD7) });
            LocationByID(LOCATION_ID_WORLD_FIELD4).ConnectLocation(new[]  { LocationByID(LOCATION_ID_WORLD_FIELD3),
                                                                            LocationByID(LOCATION_ID_WORLD_DUNGEON1_ENTRANCE),
                                                                            LocationByID(LOCATION_ID_WORLD_CITY1_ENTRANCE) });
            LocationByID(LOCATION_ID_WORLD_DUNGEON1_ENTRANCE).ConnectLocation(new[] { LocationByID(LOCATION_ID_WORLD_FIELD4) });
            LocationByID(LOCATION_ID_WORLD_FIELD5).ConnectLocation(new[]  { LocationByID(LOCATION_ID_WORLD_FIELD1),
                                                                            LocationByID(LOCATION_ID_WORLD_FIELD6),
                                                                            LocationByID(LOCATION_ID_WORLD_MOUNTAIN_BASE1) });
            LocationByID(LOCATION_ID_WORLD_FIELD6).ConnectLocation(new[]  { LocationByID(LOCATION_ID_WORLD_FIELD2),
                                                                            LocationByID(LOCATION_ID_WORLD_FIELD7),
                                                                            LocationByID(LOCATION_ID_WORLD_FIELD5) });
            LocationByID(LOCATION_ID_WORLD_FIELD7).ConnectLocation(new[]  { LocationByID(LOCATION_ID_WORLD_FIELD3),
                                                                            LocationByID(LOCATION_ID_WORLD_FIELD6),
                                                                            LocationByID(LOCATION_ID_WORLD_MOUNTAIN_BASE2),
                                                                            LocationByID(LOCATION_ID_WORLD_CITY1_ENTRANCE) });
            LocationByID(LOCATION_ID_WORLD_CITY1_ENTRANCE).ConnectLocation(new[] { LocationByID(LOCATION_ID_WORLD_FIELD4),
                                                                            LocationByID(LOCATION_ID_WORLD_FIELD7) });
            LocationByID(LOCATION_ID_WORLD_RIVERBANK1).ConnectLocation(new[] { LocationByID(LOCATION_ID_WORLD_FIELD8) });
            LocationByID(LOCATION_ID_WORLD_MOUNTAIN_BASE1).ConnectLocation(new[] { LocationByID(LOCATION_ID_WORLD_FIELD5),
                                                                            LocationByID(LOCATION_ID_WORLD_MOUNTAIN_SUMMIT1),
                                                                            LocationByID(LOCATION_ID_WORLD_FIELD9) });
            LocationByID(LOCATION_ID_WORLD_MOUNTAIN_SUMMIT1).ConnectLocation(new[] { LocationByID(LOCATION_ID_WORLD_MOUNTAIN_BASE1),
                                                                            LocationByID(LOCATION_ID_WORLD_MOUNTAIN_BASE2),
                                                                            LocationByID(LOCATION_ID_WORLD_FIELD10) });
            LocationByID(LOCATION_ID_WORLD_MOUNTAIN_BASE2).ConnectLocation(new[] { LocationByID(LOCATION_ID_WORLD_MOUNTAIN_SUMMIT1),
                                                                            LocationByID(LOCATION_ID_WORLD_FIELD7),
                                                                            LocationByID(LOCATION_ID_WORLD_BRIDGE1_OVER_RIVER1),
                                                                            LocationByID(LOCATION_ID_WORLD_RIVERBANK2) });
            LocationByID(LOCATION_ID_WORLD_BRIDGE1_OVER_RIVER1).ConnectLocation(new[] { LocationByID(LOCATION_ID_WORLD_MOUNTAIN_BASE2),
                                                                            LocationByID(LOCATION_ID_WORLD_FIELD8),
                                                                            LocationByID(LOCATION_ID_WORLD_RIVERBANK3) });
            LocationByID(LOCATION_ID_WORLD_FIELD8).ConnectLocation(new[]  { LocationByID(LOCATION_ID_WORLD_RIVERBANK1),
                                                                            LocationByID(LOCATION_ID_WORLD_BRIDGE1_OVER_RIVER1),
                                                                            LocationByID(LOCATION_ID_WORLD_FIELD11) });
            LocationByID(LOCATION_ID_WORLD_FIELD9).ConnectLocation(new[]  { LocationByID(LOCATION_ID_WORLD_MOUNTAIN_BASE1),
                                                                            LocationByID(LOCATION_ID_WORLD_FIELD10) });
            LocationByID(LOCATION_ID_WORLD_FIELD10).ConnectLocation(new[] { LocationByID(LOCATION_ID_WORLD_MOUNTAIN_SUMMIT1),
                                                                            LocationByID(LOCATION_ID_WORLD_RIVERBANK2),
                                                                            LocationByID(LOCATION_ID_WORLD_FIELD9) });
            LocationByID(LOCATION_ID_WORLD_RIVERBANK2).ConnectLocation(new[] { LocationByID(LOCATION_ID_WORLD_FIELD10),
                                                                            LocationByID(LOCATION_ID_WORLD_MOUNTAIN_BASE2) });
            LocationByID(LOCATION_ID_WORLD_RIVERBANK3).ConnectLocation(new[] { LocationByID(LOCATION_ID_WORLD_BRIDGE1_OVER_RIVER1),
                                                                            LocationByID(LOCATION_ID_WORLD_FIELD11) });
            LocationByID(LOCATION_ID_WORLD_FIELD11).ConnectLocation(new[] { LocationByID(LOCATION_ID_WORLD_FIELD8),
                                                                            LocationByID(LOCATION_ID_WORLD_RIVERBANK3) });
            #endregion
            #region Add locations to connect level grids
            LocationByID(LOCATION_ID_WORLD_CITY1_ENTRANCE).ConnectLocation(      "EXIT", LocationByID(LOCATION_ID_CITY1_EXIT1) );
            LocationByID(LOCATION_ID_WORLD_DUNGEON1_ENTRANCE).ConnectLocation(   "EXIT", LocationByID(LOCATION_ID_DUNGEON1_EXIT1) );
            LocationByID(LOCATION_ID_DUNGEON1_EXIT1).ConnectLocation(            "EXIT", LocationByID(LOCATION_ID_WORLD_DUNGEON1_ENTRANCE) );
            LocationByID(LOCATION_ID_CITY1_EXIT1).ConnectLocation(               "EXIT", LocationByID(LOCATION_ID_WORLD_CITY1_ENTRANCE) );
            LocationByID(LOCATION_ID_CITY1_EXIT2).ConnectLocation(               "EXIT", LocationByID(LOCATION_ID_WORLD_CITY1_ENTRANCE) );

            #endregion
        }
    }
}
