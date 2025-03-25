namespace Battleship
{
    class BasePlayer
    {
        public static string[] shipNames = { "Toeculier", "Swayzumbel", "MudSplatter", "Cantabull", "Pludderslap" };
        public static int[] shipLength = { 5, 4, 3, 3, 2 };
        public Grid grid;
        public Random rand;

        public BasePlayer()
        {
            grid = new Grid();
            rand = new Random();
        }

        public virtual bool Attack(Grid enemyGrid)
        {
            int x, y;
            do
            {
                x = rand.Next(10);
                y = rand.Next(10);
            }
            while (enemyGrid.MakeGuess(x, y));
            return true;
        }

        public Grid GetGrid()
        {
            return grid;
        }
    }
}

