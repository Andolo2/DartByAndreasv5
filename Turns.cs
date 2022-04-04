using System;

namespace DartByAndreasv5
{
    public class Turns

        // Variable´s that are used for a human player and the computer player.
    {   private int firstThrow;
        private int secondThrow;
        private int thirdThrow;

        private int CompArrow1;
        private int CompArrow2;
        private int CompArrow3;

     
        //Method that sets the score of each arrow to zero by default.
        public Turns(int firstThrow = 0, int secondThrow = 0, int thirdThrow = 0, int CompArrow1 = 0, int CompArrow2 = 0, int CompArrow3 = 0) 
        {
            this.firstThrow = firstThrow;
            this.secondThrow = secondThrow;
            this.thirdThrow = thirdThrow;

            this.CompArrow1 = CompArrow1;
            this.CompArrow2 = CompArrow2;
            this.CompArrow3 = CompArrow3;



        }
         public int GetScore() // Add´s the score of each throw. Later used in the CalulatePoints() method.
        {
            int totalScore = firstThrow + secondThrow + thirdThrow;
            return totalScore;
        }
        public int ComputerGetScore() // Add´s the score of each throw. Later used in the CalulatePoints() method, but this one adds the computers score. 
        {
            int computertotalScore = CompArrow1 + CompArrow2 + CompArrow3;
            return computertotalScore;
        }

        public override string ToString() // Prints out the score of each arrow. 
        {
            return string.Format("The first arrow: {0}, The second arrow: {1}, The third arrow: {2}\n ", firstThrow, secondThrow, thirdThrow);
        }
        
    }
}
