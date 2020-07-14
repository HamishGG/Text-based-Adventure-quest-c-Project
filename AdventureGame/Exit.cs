namespace AdventureGame
{
    internal class Exit
    {
        public enum Directions
        {
            Undefined, North, South, East, West, Up, Down, NorthEast, SouthEast, SouthWest, In, Out
        }

        public static string[] shortDirections = { "null", "N", "S", "E", "W", "U", "D", "NE", "SE", "SW", "I", "O" };

        private Location leadsTo;
        private Directions direction;

        public Exit()
        {
            direction = Directions.Undefined;
            leadsTo = null;
        }

        public Exit(Directions _direction, Location newLeadsTo)
        {
            direction = _direction;
            leadsTo = newLeadsTo;
        }

        public override string ToString()
        {
            return direction.ToString();
        }

        public void setDirection(Directions _directions)
        {
            direction = _directions;
        }

        public Directions GetDirections()
        {
            return direction;
        }

        public string getShortDirection()
        {
            return shortDirections[(int)direction].ToLower();
        }

        public void setLeadsTo(Location _leadsTo)
        {
            leadsTo = _leadsTo;
        }

        public Location getLeadsTo()
        {
            return leadsTo;
        }
    }
}