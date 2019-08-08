// Fig. 7.8: Craps.cs
// Craps class simulates the dice game craps.
using System;

class Craps
{
   // create random-number generator for use in method RollDice
   private static Random randomNumbers = new Random();

   // enumeration with constants that represent the game status
   private enum Status {Continue, Won, Lost}

   // enumeration with constants that represent common rolls of the dice
   private enum DiceNames
   {
      SnakeEyes = 2,
      Trey = 3,
      Seven = 7,
      YoLeven = 11,
      BoxCars = 12
   }

   // plays one game of craps
   static void Main()
   {
      // gameStatus can contain Continue, Won or Lost
      Status gameStatus = Status.Continue;
      int myPoint = 0; // point if no win or loss on first roll

      int sumOfDice = RollDice(); // first roll of the dice

      // determine game status and point based on first roll 
      switch ((DiceNames)sumOfDice)
      {
         case DiceNames.Seven: // win with 7 on first roll    
         case DiceNames.YoLeven: // win with 11 on first roll
            gameStatus = Status.Won;
            break;
         case DiceNames.SnakeEyes: // lose with 2 on first roll
         case DiceNames.Trey: // lose with 3 on first roll      
         case DiceNames.BoxCars: // lose with 12 on first roll 
            gameStatus = Status.Lost;
            break;
         default: // did not win or lose, so remember point  
            gameStatus = Status.Continue; // game is not over
            myPoint = sumOfDice; // remember the point       
            Console.WriteLine($"Point is {myPoint}");
            break;
      }

      // while game is not complete
      while (gameStatus == Status.Continue) // game not Won or Lost
      {
         sumOfDice = RollDice(); // roll dice again

         // determine game status
         if (sumOfDice == myPoint) // win by making point
         {
            gameStatus = Status.Won;
         }
         else
         {
            // lose by rolling 7 before point
            if (sumOfDice == (int)DiceNames.Seven)
            {
               gameStatus = Status.Lost;
            }
         }
      }

      // display won or lost message
      if (gameStatus == Status.Won)
      {
         Console.WriteLine("Player wins");
      }
      else
      {
         Console.WriteLine("Player loses");
      }
   }

   // roll dice, calculate sum and display results
   static int RollDice()
   {
      // pick random die values
      int die1 = randomNumbers.Next(1, 7); // first die roll
      int die2 = randomNumbers.Next(1, 7); // second die roll

      int sum = die1 + die2; // sum of die values

      // display results of this roll
      Console.WriteLine($"Player rolled {die1} + {die2} = {sum}");
      return sum; // return sum of dice
   }
}


/**************************************************************************
 * (C) Copyright 1992-2017 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/
