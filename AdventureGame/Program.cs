namespace AdventureGame
{
    class Program
    {
        private static void Main(string[] args)
        {
            Game _Game = new Game();

            while (_Game.isRunning)
            {
                _Game.Update();

            }
        }
    }
}