// Fig. 16.2: StringMethods.cs
// string indexer, Length property and CopyTo method

using System;

class StringMethods
{
   static void Main()
   {
      var string1 = "hello there";
      var characterArray = new char[5];

      Console.WriteLine($"string1: \"{string1}\""); // output string1

      // test Length property                                     
      Console.WriteLine($"Length of string1: {string1.Length}");

      // loop through characters in string1 and display reversed
      Console.Write("The string reversed is: ");

      for (int i = string1.Length - 1; i >= 0; --i)
      {
         Console.Write(string1[i]);
      }

      // copy characters from string1 into characterArray           
      string1.CopyTo(0, characterArray, 0, characterArray.Length);
      Console.Write("\nThe character array is: ");

      foreach (var element in characterArray)
      {
         Console.Write(element);
      }

      Console.WriteLine("\n");
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
