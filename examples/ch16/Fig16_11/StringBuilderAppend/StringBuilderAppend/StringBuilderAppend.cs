// Fig. 16.11: StringBuilderAppend.cs
// Demonstrating StringBuilder Append methods.
using System;
using System.Text;

class StringBuilderAppend
{
   static void Main()
   {
      object objectValue = "hello";
      var stringValue = "good bye";
      char[] characterArray = { 'a', 'b', 'c', 'd', 'e', 'f' };
      var booleanValue = true;
      var characterValue = 'Z';
      var integerValue = 7;
      var longValue = 1000000L; // L suffix indicates a long literal
      var floatValue = 2.5F; // F suffix indicates a float literal
      var doubleValue = 33.333;
      var buffer = new StringBuilder();

      // use method Append to append values to buffer  
      buffer.Append(objectValue);
      buffer.Append("  ");
      buffer.Append(stringValue);
      buffer.Append("  ");
      buffer.Append(characterArray);
      buffer.Append("  ");
      buffer.Append(characterArray, 0, 3);
      buffer.Append("  ");
      buffer.Append(booleanValue);
      buffer.Append("  ");
      buffer.Append(characterValue);
      buffer.Append("  ");
      buffer.Append(integerValue);
      buffer.Append("  ");
      buffer.Append(longValue);
      buffer.Append("  ");
      buffer.Append(floatValue);
      buffer.Append("  ");
      buffer.Append(doubleValue);

      Console.WriteLine($"buffer = {buffer.ToString()}");
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
