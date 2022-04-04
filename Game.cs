using System;

namespace DartByAndreasv5
{
    public class Game
    {
       private List<Player> ListOfPlayers = new List<Player>(); // List that contains the players, set as private
    

       int totalScore; //Variable for the loop
       int winner = 301;//Variable to end the loop
      
       



        public void addPlayer(string name)
        {
            Player human = new Player(name); 
            Player ComputerPlayer = new Player("ComputerPlayer"); // A constructor that adds the "computer player" to the game
            ListOfPlayers.Add(human); // Add´s each player to our list (ListOfPlayers)
            ListOfPlayers.Add(ComputerPlayer); // Adds the computer to the same list.
            
            
        }
                                                        //This is where the game begins//
       
        public void Plygame()
        {
            Console.WriteLine("Welcome to DartByAndreas\n");
            Console.WriteLine("Before we play, i will state the rules of the game...");
            Console.WriteLine("You will soon play a game of Dart 301, add as many friends as you like. Either case, you won´t be alone. A computer will play alongside you to make sure you do your best...");
            Console.WriteLine("How many players will participate? Enter a number and continue: \n"); // Welcome message that does not add any values, i added it to make it more real.



            var NumberOfPlayers = int.Parse(Console.ReadLine());
            for (int i = 0; i < NumberOfPlayers; i++) // The user assigns the number of players and let´s each player enter a name.
            {
                Console.WriteLine("Now... Enter the name of the player/players");
                var NameOfPlayers = Console.ReadLine();
                addPlayer(NameOfPlayers);
                
                
                
                
            }
            Console.WriteLine("All set? Let´s begin..");
            
            do 
            {   
               
                
                foreach (Player name in ListOfPlayers) // The game loops though each element in the ListOfPLayers untill a winner has been decleared. 

                { 
                    if (name.Name == "ComputerPlayer") // If statement that checks for the computerPLayer since it need a different way of scoring points.
                    {
                    Console.WriteLine("Now it´s time for our binary friend to play...\n");    
                    Random computerRandom = new Random(); // A construcor that creates enables me to create random integers.
                    int CompArrow1 = computerRandom.Next(0, 20); // randomly selects a number between 0-20
                    int CompArrow2 = computerRandom.Next(0, 20); // randomly selects a number between 0-20
                    int CompArrow3 = computerRandom.Next(0, 20); // randomly selects a number between 0-20
                    Console.WriteLine("first arrow: " + CompArrow1); // Prints out the new random value
                    Console.WriteLine("second arrow: " + CompArrow2); // Prints out the new random value
                    Console.WriteLine("third arrow: " + CompArrow3); // Prints out the new random value
                    name.AddThrows(CompArrow1, CompArrow2, CompArrow3); // Add the computers darts in the AddThrows method. 
                    int computertotalScore = name.CalculatePoints(); // Calculate the current score and check for a winner.
                    name.PrintTurns();  // Print the current score. 
                    System.Threading.Thread.Sleep(2000); 
                   
                    continue;
                    
                    
                    }
                    
            

                    Console.WriteLine(name + " It´s your turn to play ", name); // Prints out the name of the player who´s turn it is. 
                    Console.WriteLine("Enter the result from the first arrow: "); // manually enter result.
                    int firstThrow = Int32.Parse(Console.ReadLine());
                  
                    
                    if (firstThrow > 20 || firstThrow < 0) // an if statement that checks the dart for a correct value between 0-20. If not it removes the input from the total score. 
                    {
                        Console.WriteLine("You can only add a score between 0 and 20");
                        --firstThrow;
                    }
                    Console.WriteLine("Enter the result from the second arrow: ");
                    int secondThrow = Int32.Parse(Console.ReadLine());
                    if (secondThrow > 20 || secondThrow < 0) // an if statement that checks the dart for a correct value between 0-20. If not it removes the input from the total score. 
                    {
                        Console.WriteLine("You can only add a score between 0 and 20");
                        --secondThrow;
                    }
                    Console.WriteLine("Enter the result from the third arrow: ");
                    int thirdThrow = Int32.Parse(Console.ReadLine()); // an if statement that checks the dart for a correct value between 0-20. If not it removes the input from the total score. 
                    if (thirdThrow > 20 || thirdThrow < 0)
                    {
                        Console.WriteLine("You can only add a score between 0 and 20");
                        --thirdThrow;
                    }
                    
                    
                    



                    name.AddThrows(firstThrow, secondThrow, thirdThrow); // The "darts" are added in the added to the Addthrows method. 
                    int totalScore = name.CalculatePoints(); // the total score of all the darts are added to the CalculatePoints method. It also checks if a winner has been declared.
                    name.PrintTurns(); // A method that prints the current score of each player between each round of the game. 

                
                    
                    
                    
                    
                   
                    
                    
                    
                    
                    
                    

                
                    

                    
                    







                 
                }
            }
            while(totalScore <= winner);
         
            
            
            

            
            
            

        }


















    }
}
