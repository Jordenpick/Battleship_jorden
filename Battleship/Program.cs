namespace Battleship
{
    class Program
    {
        static void Main()
        {
            Player player = new Player();
            AIPlayer ai = new AIPlayer();
            Grid aiGrid = ai.GetGrid();
            Grid playerGrid = player.GetGrid();
            int shots = 0;
            string[] battleShipWord =
            {
                   "BATTLESHIP!!!",
                   "PRESS ENTER TO START!"
            };

            
            
            foreach(string word in battleShipWord)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("AI's Board (Shots Fired):");
                aiGrid.DisplayBoard(false);

                Console.WriteLine("\nYour Board:");
                playerGrid.DisplayBoard(false);
                player.PlaceShipsManually();
                player.Attack(aiGrid);
                shots++;
                if (aiGrid.CheckWin())
                {
                    Console.WriteLine("You win in " + shots + " shots!");
                    break;
                }
                ai.Attack(playerGrid);
                if (playerGrid.CheckWin())
                {
                    Console.WriteLine("AI wins!");
                    break;
                }
            }
        }
    }


}