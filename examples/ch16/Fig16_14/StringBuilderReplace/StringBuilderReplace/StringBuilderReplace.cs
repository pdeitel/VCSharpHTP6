// Fig. 16.14: StringBuilderReplace.cs
// Demonstrating method Replace.
using System;
using System.Text;

class StringBuilderReplace
{
   static void Main()
   {
      var builder1 = new StringBuilder("Happy Birthday Jane");
      var builder2 = new StringBuilder("goodbye greg");

      Console.WriteLine($"Before replacements:\n{builder1}\n{builder2}");

      builder1.Replace("Jane", "Greg");
      builder2.Replace('g', 'G', 0, 5);

      Console.WriteLine($"\nAfter replacements:\n{builder1}\n{builder2}");
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
