// Fig. 7.7: RollDie.cs
// Roll a six-sided die 60,000,000 times.
using System;

class RollDie
{
   static void Main()
   {
      Random randomNumbers = new Random(); // random-number generator

      int frequency1 = 0; // count of 1s rolled
      int frequency2 = 0; // count of 2s rolled
      int frequency3 = 0; // count of 3s rolled
      int frequency4 = 0; // count of 4s rolled
      int frequency5 = 0; // count of 5s rolled
      int frequency6 = 0; // count of 6s rolled

      // summarize results of 60,000,000 rolls of a die
      for (int roll = 1; roll <= 60000000; ++roll)
      {
         int face = randomNumbers.Next(1, 7); // number from 1 to 6

         // determine roll value 1-6 and increment appropriate counter
         switch (face)
         {
            case 1:
               ++frequency1; // increment the 1s counter
               break;
            case 2:
               ++frequency2; // increment the 2s counter
               break;
            case 3:
               ++frequency3; // increment the 3s counter
               break;
            case 4:
               ++frequency4; // increment the 4s counter
               break;
            case 5:
               ++frequency5; // increment the 5s counter
               break;
            case 6:
               ++frequency6; // increment the 6s counter
               break;
         }
      }

      Console.WriteLine("Face\tFrequency"); // output headers
      Console.WriteLine($"1\t{frequency1}\n2\t{frequency2}");
      Console.WriteLine($"3\t{frequency3}\n4\t{frequency4}");
      Console.WriteLine($"5\t{frequency5}\n6\t{frequency6}");
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
