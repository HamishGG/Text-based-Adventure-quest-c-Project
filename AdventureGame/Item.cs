namespace AdventureGame
{
    internal class Item
    {
        public string name;
        private bool needsItem;

        public Item(string _name, bool canUse, string description)
        {
            name = _name;
            Useable = canUse;
            Description = description;
        }

        public string Name => name;

        public bool Useable { get; }

        public string Description { get; }
    }
}