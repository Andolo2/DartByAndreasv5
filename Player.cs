using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace DartByAndreasv5
{
    public class Player // 
    {
        public string Name { get; set; }
        private List<Turns> ListOfThrows = new List<Turns>(); // List that contains the number of throws, set as private.

        public Player(string name = "") // Method that let´s the user enter his/her´s name. 
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
        public void AddThrows(int firstThrow, int secondThrow, int thirdThrow) // Method that adds the players throw in the private list
        {
            ListOfThrows.Add(new Turns(firstThrow, secondThrow, thirdThrow));
          
        
        }
        public int CalculatePoints()
        {
            int totalScore = 0; // The score all players start with
            int winner = 301; // The score a player needs to win the game. 
            foreach (var Turns in ListOfThrows)
            {
                totalScore = totalScore + Turns.GetScore() + Turns.ComputerGetScore(); // Adds the score of the players and the computer to keep count. 
                if (winner <= totalScore) // a loop that start when a score get´s higher then 301
                {
                    Console.WriteLine("We have a winner!" + Name + "\n"); //presents the name of the winner
                    Console.ReadKey();

                    int menuSelect = 0; // After the winner has been decleared, the user can choose to play again or quit the game by themselfs. 
                    Console.WriteLine("Press [1] to close the game");
                    Console.WriteLine("Press [2] to restart the game\n");
                    Console.WriteLine("Make your choice and press Enter. :\n ");
                    menuSelect = Convert.ToInt32(Console.ReadLine());
                    if (menuSelect == 1)
                    {
                        Environment.Exit(0);
                    }
                    else if (menuSelect == 2)
                    {
                       Game game = new Game();
                       game.Plygame();
                    }
                    else
                    {
                        Environment.Exit(0);
                    }




                    
                }

            }
            return totalScore;
        }
        public void PrintTurns() // A method that prints the score for every user between turns. 
        {  
            Console.WriteLine("Stats for player: {0}", CalculatePoints(), Name + "\n");
            foreach (var Turns in ListOfThrows)
            {   
                
                Console.WriteLine(Turns);
                
                
            }
            Console.WriteLine("Total score for player: {1} {0}\n", CalculatePoints(), Name + "\n");
            
        }
     
    
       








    }
}
