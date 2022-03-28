using System;

namespace DartByAndreasv5
{
    public class Turns

    {   private int firstThrow;
        private int secondThrow;
        private int thirdThrow;

        public Turns(int firstThrow = 0, int secondThrow = 0, int thirdThrow = 0)
        {
            this.firstThrow = firstThrow;
            this.secondThrow = secondThrow;
            this.thirdThrow = thirdThrow;

        }
         public int GetScore()
        {
            int totalScore = firstThrow + secondThrow + thirdThrow;
            return totalScore;
        }
        public override string ToString()
        {
            return string.Format("The first arrow: {0}, The second arrow: {1}, The third arrow: {2} ", firstThrow, secondThrow, thirdThrow);
        }
    }
}
