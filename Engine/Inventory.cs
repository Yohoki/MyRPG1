using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Inventory
    {
        public SortedList<Item, int> InventoryItems = new();
        public SortedList<String, Item> EquippedItems = new();

        public void AddItem(Item item, int quantity)
        {
            try { InventoryItems[item] += quantity; }
            catch { InventoryItems.Add(item, quantity); }
        }
        public void RemoveItem(Item item, int quantity)
        {
            try
            {
                // Try to find item, and remove a set quantity of it from list.
                InventoryItems[item] -= quantity;

                if (InventoryItems.GetValueOrDefault(item) <= 0)
                {   // Remove item if Quantity at or below 0
                    InventoryItems.Remove(item);
                }
            }
            catch { return; } //Probably is missing an item.
        }

        public void EquipItem(string equipSlot, Item item)
        {
            try
            {
                EquippedItems.Add(equipSlot, item);
            }
            catch
            {   //Something is already Equipped there. Unequip first.
                UnequipItem(equipSlot);
                EquipItem(equipSlot, item);
                return;
            }
            RemoveItem(item, 1);
        }
        public void UnequipItem(string equipSlot)
        {
            try
            {
                    AddItem(EquippedItems[equipSlot], 1);
                    EquippedItems.Remove(equipSlot);
            }
            catch { return; } //Probably an empty slot.
        }

        public override string ToString()
        {
            string printItems = $"Inventory Contains:\n";
            foreach (KeyValuePair<Item, int> item in InventoryItems)
            {
                printItems += item.Key.Name + " x" + item.Value.ToString() + System.Environment.NewLine;
            }
            if (InventoryItems.Count == 0) { printItems += $"Nothing\n"; }

            printItems += $"Equipped Items contains:\n";
            foreach (KeyValuePair<String, Item> item in EquippedItems)
            {
                printItems += item.Key + " - " + item.Value.Name.ToString() + System.Environment.NewLine;
            }
            if (EquippedItems.Count == 0) { printItems += $"Nothing\n"; }
            return printItems;
        }
    }
}
