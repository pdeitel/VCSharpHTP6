// Fig. 6.5: Sum.cs
// Summing integers with the for statement.
using System;

class Sum
{
   static void Main()
   {
      int total = 0; // initialize total

      // total even integers from 2 through 20
      for (int number = 2; number <= 20; number += 2)
      {
         total += number;
      }

      Console.WriteLine($"Sum is {total}"); // display results
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
