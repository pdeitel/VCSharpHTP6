// Fig. 16.7: SubConcatenation.cs
// Demonstrating string class Concat method.
using System;

class StringConcatenation
{
   static void Main()
   {
      var string1 = "Happy ";
      var string2 = "Birthday";

      Console.WriteLine($"string1 = \"{string1}\"");
      Console.WriteLine($"string2 = \"{string2}\"");
      Console.WriteLine("\nResult of string.Concat(string1, string2) = " +
         string.Concat(string1, string2));
      Console.WriteLine($"string1 after concatenation = {string1}");
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
