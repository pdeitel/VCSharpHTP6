// Fig. 5.15: Increment.cs
// Prefix increment and postfix increment operators.
using System;

class Increment
{
   static void Main()
   {
      // demonstrate postfix increment operator
      int c = 5; // assign 5 to c
      Console.WriteLine($"c before postincrement: {c}"); // displays 5
      Console.WriteLine($"    postincrementing c: {c++}"); // displays 5
      Console.WriteLine($" c after postincrement: {c}"); // displays 6

      Console.WriteLine(); // skip a line

      // demonstrate prefix increment operator
      c = 5; // assign 5 to c
      Console.WriteLine($" c before preincrement: {c}"); // displays 5
      Console.WriteLine($"     preincrementing c: {++c}"); // displays 6
      Console.WriteLine($"  c after preincrement: {c}"); // displays 6
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
