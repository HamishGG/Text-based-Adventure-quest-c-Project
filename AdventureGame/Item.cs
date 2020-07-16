namespace AdventureGame
{
    internal class Item
    {
        public string name;
        private bool needsItem;
        private int itemDamage;
        private bool itemHasAmmo;

        public Item(string _name, bool canUse, string description, int _itemDamage, bool _itemHasAmmo)
        {
            name = _name;
            Useable = canUse;
            Description = description;
            itemDamage = _itemDamage;
            itemHasAmmo = _itemHasAmmo;
        }

        public string Name => name;

        public bool Useable { get; set; }

        public string Description { get; set; }

        public int ItemDamage { get; set; }

        public bool ItemAmmo { get; set; }
    }
}