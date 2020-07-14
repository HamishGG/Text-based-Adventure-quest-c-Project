namespace AdventureGame
{
    internal class Item
    {
        public string name;
        private bool needsItem;

        public Item(string _name, bool canUse, string _descrption)
        {
            name = _name;
            Useable = canUse;
            Descrption = _descrption;
        }

        public string Name => name;

        public bool Useable { get; }

        public string Descrption { get; }
    }
}