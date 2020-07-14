using System.Collections.Generic;

namespace AdventureGame
{
    internal class Location
    {
        private string roomTitle;
        private string roomDescription;
        private List<Exit> exits;
        private List<Item> inventory;

        //init location information empty
        public Location()
        {
            roomTitle = "";
            roomDescription = "";
            exits = new List<Exit>();
            inventory = new List<Item>();
        }

        //init location information with title
        public Location(string title)
        {
            roomTitle = title;
            roomDescription = "";
            exits = new List<Exit>();
            inventory = new List<Item>();
        }

        //init location information with title and desc
        public Location(string title, string description)
        {
            roomTitle = title;
            roomDescription = description;
            exits = new List<Exit>();
            inventory = new List<Item>();
        }

        public override string ToString()
        {
            return roomTitle;
        }

        //adds exit
        public void addExit(Exit exit)
        {
            exits.Add(exit);
        }

        //removes exit
        public void removeExit(Exit exit)
        {
            if (exits.Contains(exit))
            {
                exits.Remove(exit);
            }
        }

        //gets list of exits
        public List<Exit> getExits()
        {
            return new List<Exit>(exits);
        }

        //gets list of items in inv
        public List<Item> getInventory()
        {
            return new List<Item>(inventory);
        }

        //adds item to inventory
        public void addItem(Item itemToAdd)
        {
            inventory.Add(itemToAdd);
        }

        //remove item from inventory
        public void removeItem(Item itemToRemove)
        {
            if (inventory.Contains((itemToRemove)))
            {
                inventory.Remove(itemToRemove);
            }
        }

        //take item from inventory
        public Item takeItem(string name)
        {
            foreach (Item _item in inventory)
            {
                //if item matches the name of item then create temp of that item and remove it from inv
                if (_item.name.ToLower() == name)
                {
                    Item temp = _item;
                    inventory.Remove(temp);
                    return temp;
                }
            }

            return null;
        }

        public string getTitle()
        {
            return roomTitle;
        }

        public void setTitle(string title)
        {
            roomTitle = title;
        }

        public string getDescrption()
        {
            return roomDescription;
        }

        public void setDescrption(string description)
        {
            roomDescription = description;
        }
    }
}