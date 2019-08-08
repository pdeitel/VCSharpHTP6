// Fig. 16.9: StringBuilderConstructor.cs
// Demonstrating StringBuilder class constructors.
using System;
using System.Text;

class StringBuilderConstructor
{
   static void Main()
   {
      var buffer1 = new StringBuilder();
      var buffer2 = new StringBuilder(10);
      var buffer3 = new StringBuilder("hello");

      Console.WriteLine($"buffer1 = \"{buffer1}\"");
      Console.WriteLine($"buffer2 = \"{buffer2}\"");
      Console.WriteLine($"buffer3 = \"{buffer3}\"");
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
