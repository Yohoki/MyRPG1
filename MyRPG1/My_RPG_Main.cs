using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Engine;

namespace MyRPG1
{
    public partial class My_RPG_Main : Form
    {
        private const string West = "W";
        private const string East = "E";
        private const string North = "N";
        private const string South = "S";
        private const string Exit = "EXIT";
        private const int PlayerHome = World.LOCATION_ID_CITY1_PLAYER_HOUSE;

        private Player _Player;

        public Monster DebugMonster;
        //public Monster DebugMonster2;
        public My_RPG_Main()
        {
            InitializeComponent();
            //DEBUG_SpawnTest();
            //DEBUG_DisplayDebugText();
            DEBUG_SpawnDefaultPlayer();
        }

        public void DEBUG_SpawnDefaultPlayer()
        {
            _Player = Player.SpawnDefaultPlayer();
            DEBUG_RefreshPlayerStats();
        }
        public void DEBUG_RefreshPlayerStats()
        {

            btnEnter.Visible = false;
            btnNorth.Visible = false;
            btnSouth.Visible = false;
            btnEast.Visible  = false;
            btnWest.Visible = false;
            btnAttack1.Visible = false;
            lblEnemyHP.Visible = false;
            lblPlayerHP.Visible = false;

            lblDEBUGPlayerStats.Text = string.Format("Player Name: {0}\n" +
                                                     "Player HP/MP: {1}/{2}\n" +
                                                     "Player Location: {3} - [ {4} , {5} ]\n" +
                                                     "{6}\n" + "{7}\n",
                                                     _Player.Name, _Player.HP, _Player.MP, _Player._Location.Level,
                                                     _Player._Location.Coordinates[0], _Player._Location.Coordinates[1],
                                                     _Player._Location.Name, _Player._Location.Description );
            foreach (KeyValuePair<string, Location> kvp in _Player._Location.ConnectedLocations)
            {
                switch (kvp.Key)
                {
                    case "EXIT":
                        btnEnter.Visible = true;
                        break;
                    case "N":
                        btnNorth.Visible = true;
                        break;
                    case "S":
                        btnSouth.Visible = true;
                        break;
                    case "E":
                        btnEast.Visible = true;
                        break;
                    case "W":
                        btnWest.Visible = true;
                        break;
                    default:
                        break;
                }
                lblDEBUGPlayerStats.Text += string.Format("Location Connection: {0} - [ {1} , {2} ]\n", kvp.Key, kvp.Value.Coordinates[0], kvp.Value.Coordinates[1]);
            }

        }
        public void DEBUG_RefreshFightStats()
        {
            lblPlayerHP.Text = string.Format("Name: {0}\n" +
                                             "HP: {1}\n" +
                                             "{2}",
                                             _Player.Name, _Player.HP, _Player.Creature_Inventory.ToString());
            lblEnemyHP.Text = string.Format("Name: {0}\n" +
                                             "HP: {1}\n" +
                                             "{2}",
                                             _Player.MonsterBeingFought.Name, _Player.MonsterBeingFought.HP,
                                             _Player.MonsterBeingFought.Creature_Inventory.ToString()); ;
        }

        public void DEBUG_SpawnTest()
        {
            DebugMonster = World.MonsterByName("Rat");
            //DebugMonster2 = World.MonsterByID(World.MONSTER_ID_SNAKE);
            _Player.MonsterBeingFought = DebugMonster;
            //_Player.Creature_Inventory.EquipItem("MainHand", World.ItemByID(World.ITEM_ID_RUSTY_SWORD2));
            DebugMonster.Creature_Inventory.EquipItem("MainHand", World.ItemByID(World.ITEM_ID_RUSTY_SWORD2));
        }

        private void btnDebugButton_Click(object sender, EventArgs e)
        {
            DEBUG_SpawnTest();

            btnAttack1.Visible = true;
            lblEnemyHP.Visible = true;
            lblPlayerHP.Visible = true;
            btnEnter.Visible = false;
            btnNorth.Visible = false;
            btnSouth.Visible = false;
            btnEast.Visible = false;
            btnWest.Visible = false;

            //DEBUG_RefreshPlayerStats();
            DEBUG_RefreshFightStats();
        }

        private void btnNorth_Click(object sender, EventArgs e)
        {
            _Player.MoveTo(North);
            DEBUG_RefreshPlayerStats();
        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            _Player.MoveTo(East);
            DEBUG_RefreshPlayerStats();
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            _Player.MoveTo(South);
            DEBUG_RefreshPlayerStats();
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            _Player.MoveTo(West);
            DEBUG_RefreshPlayerStats();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            _Player.MoveTo(Exit);
            DEBUG_RefreshPlayerStats();
        }

        private void btnAttack1_Click(object sender, EventArgs e)
        {
            _Player.Battle_PlayerAttack();
            DEBUG_RefreshFightStats();
        }
    }
}
