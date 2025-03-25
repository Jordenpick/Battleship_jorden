namespace Battleship
{
    class Player : BasePlayer
    {
        public override bool Attack(Grid playerGrid)
        {
            int x, y;

            Console.WriteLine("Choose where to hit");

            while(true)
            {
                Console.WriteLine("Enter x (0-9)");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter y (0-9)");
                y = Convert.ToInt32(Console.ReadLine());
                if (x >= 0 && x <= 9 && y >= 0 && y <= 9)
                {
                    playerGrid.MakeGuess(x, y);
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid X or Y");
                }
            } 
        }
        public void PlaceShipsManually()
        {
            for (int i = 0; i < shipNames.Length; i++)
            {
                Console.WriteLine("Place " + shipNames[i] + " length of " + shipLength[i]);
                int x, y;
                string? direction;

                do
                {
                    Console.WriteLine("Enter X coordinate (0-9):");
                    x = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Y coordinate (0-9):");
                    y = Convert.ToInt32(Console.ReadLine());
                } while (x < 0 || x > 9 || y < 0 || y > 9);

                do
                {
                    Console.WriteLine("Enter direction (H or V):");
                    direction = Console.ReadLine();
                    direction = direction?.ToUpper();
                } while (direction != "H" && direction != "V");

                bool isPlaced = grid.PlaceShip(new Ship(shipNames[i], shipLength[i]), x, y, direction);
                if (!isPlaced)
                {
                    Console.WriteLine("Invalid placement.");
                    i--;
                }
                grid.DisplayBoard(false);
            }
        }
    }
}

