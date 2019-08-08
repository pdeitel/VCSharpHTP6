// Fig. 7.6: RandomIntegers.cs
// Shifted and scaled random integers.
using System;

class RandomIntegers
{
   static void Main()
   {
      Random randomNumbers = new Random(); // random-number generator

      // loop 20 times
      for (int counter = 1; counter <= 20; ++counter)
      {
         // pick random integer from 1 to 6
         int face = randomNumbers.Next(1, 7);
         Console.Write($"{face}  "); // display generated value
      }

      Console.WriteLine();
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
