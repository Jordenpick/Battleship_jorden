
namespace Battleship
{
    class AIPlayer : BasePlayer
    {
        public AIPlayer()
        {
            PlaceShips();
        }
        public override bool Attack(Grid aiGrid)
        {
            int x, y;
            do
            {
                x = rand.Next(10);
                y = rand.Next(10);
            }
            while (aiGrid.MakeGuess(x, y));
            return true;
        }
        public void PlaceShips()
        {
            for (int i = 0; i < shipNames.Length; i++)
            {
                string direction = "H";
                if (rand.Next(0, 2) == 0)
                {
                    direction = "V";
                }
                if (!grid.PlaceShip(new Ship(shipNames[i], shipLength[i]), rand.Next(grid.BoardLength()), rand.Next(grid.BoardHeight()), direction))
                {
                    i--;
                }
            }
        }
    }
}



