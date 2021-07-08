using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Location
    {
        public int ID_Number { get; protected set; }
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public int[] Coordinates { get; protected set; }
        public int Level { get; protected set; }
        public Monster MonsterLivingHere { get; protected set; }
        public Item ItemRequiredToEnter { get; protected set; }
        //public Quest QuestAvailableHere { get; protected set; }
        //public Quest CompletedQuestRequiredToEnter { get; protected set; }
        //public int State { get; protected set; }
        public bool IsEntrance { get; protected set; }

        public SortedList<String, Location> ConnectedLocations = new();

        public Location(int id_Number, string name, string description, int[] coordinates, int level, Monster monsterLivingHere, Item itemRequiredToEnter/*, Quest questAvailableHere, quest completedQuestRequiredToEnter, int state*/, bool isEntrance = false)
        {
            ID_Number = id_Number;
            Name = name;
            Description = description;
            Coordinates = coordinates;
            Level = level;
            MonsterLivingHere = monsterLivingHere;
            ItemRequiredToEnter = itemRequiredToEnter;
            //QuestAvailableHere = questAvailableHere;
            //CompletedQuestRequiredToEnter = completedQuestRequiredToEnter;
            //State = state;
            IsEntrance = isEntrance;
        }

        internal void ConnectLocation(Location connection)
        {
            switch (Coordinates[0] - connection.Coordinates[0])
            {
                case -1:
                    ConnectedLocations.Add("N", connection);
                    break;
                case 1:
                    ConnectedLocations.Add("S", connection);
                    break;
                default: break;
            }
            switch (Coordinates[1] - connection.Coordinates[1])
            {
                case -1:
                    ConnectedLocations.Add("E", connection);
                    break;
                case 1:
                    ConnectedLocations.Add("W", connection);
                    break;
                default: break;
            }
        }

        internal void ConnectLocation(Location[] connections)
        {
            foreach (Location location in connections)
                { ConnectLocation(location); }
        }

        internal void ConnectLocation(string exit, Location connection)
        {
            this.ConnectedLocations.Add(exit, connection);
        }
    }
}
