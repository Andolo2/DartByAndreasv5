using System;

namespace DartByAndreasv5
{
    public class Game
    {
        private List<Player> ListOfPlayers = new List<Player>();
        int totalScore = 0;
        int winningScore = 31;
        public void addPlayer(string name)
        {
            Player human = new Player(name); //names
            ListOfPlayers.Add(human);
        }
        
        public void Plygame()
        {
            Console.WriteLine("Welcome to DartByAndreas\n");
            Console.WriteLine("Before we play, i will state the rules of the game...");
            Console.WriteLine("You will soon play a game of Dart 301, add as many friends as you like. Either case, you won´t be alone. A computer will play alongside you to make sure you do your best...");
            Console.WriteLine("How many players will participate? Enter a number and continue: \n");
            var NumberOfPlayers = int.Parse(Console.ReadLine());
            for (int i = 0; i < NumberOfPlayers; i++)
            {
                Console.WriteLine("Now... Enter the name of the player/players");
                var NameOfPlayers = Console.ReadLine();
                addPlayer(NameOfPlayers);
            }
            Console.WriteLine("All set? Let´s begin..");
            
            do
            {
                foreach (Player name in ListOfPlayers)
                {
                    Console.WriteLine(name + " It´s your turn to play ", name);
                    Console.WriteLine("Enter the result from the first arrow: ");
                    int firstThrow = Int32.Parse(Console.ReadLine());
                    if (firstThrow > 20 || firstThrow < 0)
                    {
                        Console.WriteLine("You can only add a score between 0 and 20");
                        --firstThrow;
                    }
                    Console.WriteLine("Enter the result from the second arrow: ");
                    int secondThrow = Int32.Parse(Console.ReadLine());
                    if (secondThrow > 20 || secondThrow < 0)
                    {
                        Console.WriteLine("You can only add a score between 0 and 20");
                        --secondThrow;
                    }
                    Console.WriteLine("Enter the result from the third arrow: ");
                    int thirdThrow = Int32.Parse(Console.ReadLine());
                    if (thirdThrow > 20 || thirdThrow < 0)
                    {
                        Console.WriteLine("You can only add a score between 0 and 20");
                        --thirdThrow;
                    }
                    name.AddThrows(firstThrow, secondThrow, thirdThrow);
                    totalScore = name.CalculatePoints();
                    //Console.WriteLine("Current score is: " + totalScore);
                    name.PrintTurns();
                    
                    








                }
            }
            while(totalScore < winningScore);
            
            
            

        }


















    }
}
