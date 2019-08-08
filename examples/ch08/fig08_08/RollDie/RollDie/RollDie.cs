// Fig. 8.8: RollDie.cs
// Roll a six-sided die 60,000,000 times.
using System;

class RollDie
{
   static void Main()
   {
      var randomNumbers = new Random(); // random-number generator
      var frequency = new int[7]; // array of frequency counters

      // roll die 60,000,000 times; use die value as frequency index
      for (var roll = 1; roll <= 60000000; ++roll)
      {
         ++frequency[randomNumbers.Next(1, 7)];
      }

      Console.WriteLine($"{"Face"}{"Frequency",10}");

      // output each array element's value
      for (var face = 1; face < frequency.Length; ++face)
      {
         Console.WriteLine($"{face,4}{frequency[face],10}");
      }
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
