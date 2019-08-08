// Fig. 16.3: StringCompare.cs
// Comparing strings
using System;

class StringCompare
{
   static void Main()
   {
      var string1 = "hello";
      var string2 = "good bye";
      var string3 = "Happy Birthday";
      var string4 = "happy birthday";

      // output values of four strings
      Console.WriteLine($"string1 = \"{string1}\"" +
         $"\nstring2 = \"{string2}\"" +
         $"\nstring3 = \"{string3}\"" +
         $"\nstring4 = \"{string4}\"\n");

      // test for equality using Equals method
      if (string1.Equals("hello"))
      { 
         Console.WriteLine("string1 equals \"hello\"");
      }
      else
      { 
         Console.WriteLine("string1 does not equal \"hello\"");
      }

      // test for equality with ==
      if (string1 == "hello")
      {
         Console.WriteLine("string1 equals \"hello\"");
      }
      else
      {
         Console.WriteLine("string1 does not equal \"hello\"");
      }

      // test for equality comparing case
      if (string.Equals(string3, string4)) // static method
      {
         Console.WriteLine("string3 equals string4");
      }
      else
      {
         Console.WriteLine("string3 does not equal string4");
      }

      // test CompareTo
      Console.WriteLine(
         $"\nstring1.CompareTo(string2) is {string1.CompareTo(string2)}");
      Console.WriteLine(
         $"string2.CompareTo(string1) is {string2.CompareTo(string1)}");
      Console.WriteLine(
         $"string1.CompareTo(string1) is {string1.CompareTo(string1)}");
      Console.WriteLine(
         $"string3.CompareTo(string4) is {string3.CompareTo(string4)}");
      Console.WriteLine(
         $"string4.CompareTo(string3) is {string4.CompareTo(string3)}");
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
