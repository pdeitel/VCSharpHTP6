// Fig. 16.8: StringMethods2.cs
// Demonstrating string methods Replace, ToLower, ToUpper and Trim. 

using System;

class StringMethods2
{
   static void Main()
   {
      var string1 = "cheers!";
      var string2 = "GOOD BYE ";
      var string3 = "   spaces   ";

      Console.WriteLine($"string1 = \"{string1}\"\n" +
         $"string2 = \"{string2}\"\n" +
         $"string3 = \"{string3}\"");

      // call method Replace
      Console.WriteLine("\nReplacing \"e\" with \"E\" in string1: " +
         $"\"{string1.Replace('e', 'E')}\"");

      // call ToLower and ToUpper
      Console.WriteLine(
         $"\nstring1.ToUpper() = \"{string1.ToUpper()}\"" +
         $"\nstring2.ToLower() = \"{string2.ToLower()}\"");

      // call Trim method
      Console.WriteLine(
         $"\nstring3 after trim = \"{string3.Trim()}\"");

      Console.WriteLine($"\nstring1 = \"{string1}\"");
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
