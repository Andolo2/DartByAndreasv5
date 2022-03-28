using System;

namespace DartByAndreasv5
{
    public class Player
    {
        public string Name { get; set; }
        private List<Turns> ListOfThrows = new List<Turns>();

        public Player(string name = "")
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
        public void AddThrows(int firstThrow, int secondThrow, int thirdThrow)
        {
            ListOfThrows.Add(new Turns(firstThrow, secondThrow, thirdThrow));
        }
        public int CalculatePoints()
        {
            int totalScore = 0;
            int winner = 31;
            foreach (var Turns in ListOfThrows)
            {
                totalScore = totalScore + Turns.GetScore();
                if (winner <= totalScore)
                {
                    Console.WriteLine("We have a winner!");
                }

            }
            return totalScore;
        }
        public void PrintTurns()
        {  
            Console.WriteLine("Stats for player: {0}", CalculatePoints(), Name);
            foreach (var Turns in ListOfThrows)
            {   
                
                Console.WriteLine(Turns);
                
            }
            Console.WriteLine("Total score for player: {1} {0}\n", CalculatePoints(), Name);
            
        }
        
    
       








    }
}
