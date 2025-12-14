using System;
using System.IO;
using Casino;
using Casino.TwentyOne;

namespace PuttingAllTogether
{
    class Program
    {
        static void Main(string[] args)
        {

            Player newPlayer = new Player("Jesse");         

            Console.WriteLine("Welcome to GBdiso Casino! Pls input your Name...");
            string playerName = Console.ReadLine();
            Console.WriteLine("Enter your Starting Balance...");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Join now {0} ?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\gbdis\Logs\log.txt", true))
                {
                    file.WriteLine(player.Id);
                    
                }
                Game game = new TwentyOneGame();
                game += player;
                player.isActivePlaying = true;
                while (player.isActivePlaying && player.Balance > 0) 
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to play!");
            Console.Read();
        }
    }
}
