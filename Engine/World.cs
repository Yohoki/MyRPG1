using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static partial class World
    {
        public static readonly List<Item> Items = new();
        public static readonly List<Monster> Monsters = new();
        public static readonly List<Vendor> Vendors = new();
        //public static readonly List<Quest> Quests = new();

        static World()
        {
            PopulateItems();
            PopulateMonsters();
            PopulateVendors();
            //PopulateQuests();
            PopulateLocations();
        }

        private static void PopulateItems()
        {
            Items.Add(new Weapon(ITEM_ID_RUSTY_SWORD, "Rusty sword", "A rusty Sword. It's been in your family for ages. Can't possibly work in a fight...",
                                  new int[] { 3, 1 }, 1, D4, 0, false, false, true)); // 1D4
            Items.Add(new Weapon(ITEM_ID_RUSTY_SWORD2, "Mythril Coated Sword", "A rusty sword, dipped in mythril. The rust gives the silvered metal a unique, bumpy texture. It's been in your family for ages. Not easy to push through flesh, but the mythril coating keeps it as sharp as it was when it was made.",
                                  new int[] { 50, 25 }, 2, D4, 4, false, false, true)); // 2D4+4
            Items.Add(new Item(ITEM_ID_RAT_TAIL, "Rat tail", "A small tail. Could make a nice broth for animal feed",
                                  new int[] { 2, 1 } ));
            Items.Add(new Item(ITEM_ID_PIECE_OF_FUR, "Piece of fur", "Pieces of fur. Might be useful for thread.",
                                  new int[] { 2 ,1 } ));
            Items.Add(new Item(ITEM_ID_SNAKE_FANG, "Snake fang", "A sharp fang. Local hunters make fearsome necklaces with these.",
                                  new int[] { 2, 1 } ));
            Items.Add(new Item(ITEM_ID_SNAKESKIN, "Snakeskin", "A skin covered with tiny scales.",
                                  new int[] { 3, 2 } ));
            Items.Add(new Weapon(ITEM_ID_CLUB, "Club", "A sturdy branch. Or, probably a leftover peice of lumber...",
                                  new int[] { 8, 6 }, 1, D8 )); // 1D8
            Items.Add(new Potion(ITEM_ID_WEAK_HEALING_POTION, "Weak Healing potion", "A small green red vial. Heals up to 10hp.",
                                  new int[] { 8, 4 }, 2, D4, 4)); // 2D4+4
            Items.Add(new Item(ITEM_ID_SPIDER_FANG, "Spider fang", "Poisonous mandibles from a very large spider. An alchemist could make a potent potion with this.",
                                  new int[] { 2, 1  } ));
            Items.Add(new Item(ITEM_ID_SPIDER_SILK, "Spider silk", "Tough. Durable. Shiny. An armourer could make some very good pieces with a spool of this.",
                                  new int[] { 3, 1 } ));
            Items.Add(new Item(ITEM_ID_FAKE_ADVENTURER_PASS, "Adventurer pass", "An official document allowing adventurers into restriced and dangerous places. This one is kind of... nutty...",
                                  new int[] { 100, 0 }, false, false, true));
            Items.Add(new Item(ITEM_ID_ADVENTURER_PASS, "Adventurer pass", "An official document allowing adventurers into restriced and dangerous places. This one looks real!",
                                  new int[] { 0, 0 }, false, false, true));
        }

        public static void PopulateMonsters()
        {
            Monster rat = new(MONSTER_ID_RAT, "Rat", "A small, furry annoyance",
                              5, 0, 1, D4, 0, 3, 1, 3);
            rat.Creature_Inventory.AddItem( ItemByID(ITEM_ID_RAT_TAIL)    , 1);
            rat.Creature_Inventory.AddItem( ItemByID(ITEM_ID_PIECE_OF_FUR) , 1);

            Monster snake = new(MONSTER_ID_SNAKE, "Snake", "A slithering beast",
                                5, 3, 1, D4, 1, 5, 3, 5);
            snake.Creature_Inventory.AddItem( ItemByID(ITEM_ID_SNAKE_FANG) , 1);
            snake.Creature_Inventory.AddItem( ItemByID(ITEM_ID_SNAKESKIN)  , 1);

            Monster giantSpider = new(MONSTER_ID_GIANT_SPIDER, "Giant spider", "A large, venomous arachnid",
                                      20, 10, 2, D6, 3, 10, 8, 10);
            giantSpider.Creature_Inventory.AddItem( ItemByID(ITEM_ID_SPIDER_FANG) , 1);
            giantSpider.Creature_Inventory.AddItem( ItemByID(ITEM_ID_SPIDER_SILK) , 1);

            Monsters.Add(rat);
            Monsters.Add(snake);
            Monsters.Add(giantSpider);
        }

        private static void PopulateVendors()
        {
            Vendor Testy = new(VENDOR_ID_TESTY, "Testy Testington", "Testy's ball shaped market has the best prices in town. " +
                                                "He specializes in nuts, balls, and rectal exams... Quite an odd fellow." +
                                                "He DOES sell cheap adventure passes, though... Much cheaper than the town hall...",
                                                1, 1, 1, D4, 1, 0, 0, 1000, new int[] { 0, 0 });
            Testy.Creature_Inventory.AddItem(ItemByID(ITEM_ID_CLUB), 1);
            Testy.Creature_Inventory.AddItem(ItemByID(ITEM_ID_FAKE_ADVENTURER_PASS), 1);
            Testy.Creature_Inventory.AddItem(ItemByID(ITEM_ID_WEAK_HEALING_POTION), 10);

            Vendors.Add(Testy);
        }

        public static Monster MonsterByID(int id)
        {
            return Monsters.SingleOrDefault(x => x.ID_Number == id).NewInstanceOfMonster();
        }
        public static Monster MonsterByName(string name)
        {
            return Monsters.SingleOrDefault(x => x.Name == name).NewInstanceOfMonster();
        }

        public static Item ItemByID(int id)
        {
            foreach (var item in Items.Where(item => item.ID_Number == id))
            {
                return item;
            }
            return null;
        }
        /*public static Quest QuestByID(int id)
        {
            foreach (var quest in Quests.Where(quest => quest.ID_Number == id))
            {
                return quest;
            }

            return null;
        }
        */

        public static Location LocationByID(int id)
        {
            foreach (var location in Locations.Where(location => location.ID_Number == id))
            {
                return location;
            }
            return null;
        }
        public static Location LocationByCoords(int level, int[] coordinates)
        {
            foreach (var location in Locations.Where(location => location.Level == level).Where(location => location.Coordinates == coordinates))
            {
                    return location;
            }
            return null;
        }
    }
}

