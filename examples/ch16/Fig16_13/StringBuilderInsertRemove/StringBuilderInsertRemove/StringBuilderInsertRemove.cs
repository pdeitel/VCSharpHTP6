// Fig. 16.13: StringBuilderInsertRemove.cs
// Demonstrating methods Insert and Remove of the 
// StringBuilder class.
using System;
using System.Text;

class StringBuilderInsertRemove
{
   static void Main()
   {
      object objectValue = "hello";
      var stringValue = "good bye";
      char[] characterArray = { 'a', 'b', 'c', 'd', 'e', 'f' };
      var booleanValue = true;
      var characterValue = 'K';
      var integerValue = 7;
      var longValue = 1000000L; // L suffix indicates a long literal
      var floatValue = 2.5F; // F suffix indicates a float literal
      var doubleValue = 33.333;
      var buffer = new StringBuilder();

      // insert values into buffer       
      buffer.Insert(0, objectValue);
      buffer.Insert(0, "  ");
      buffer.Insert(0, stringValue);
      buffer.Insert(0, "  ");
      buffer.Insert(0, characterArray);
      buffer.Insert(0, "  ");
      buffer.Insert(0, booleanValue);
      buffer.Insert(0, "  ");
      buffer.Insert(0, characterValue);
      buffer.Insert(0, "  ");
      buffer.Insert(0, integerValue);
      buffer.Insert(0, "  ");
      buffer.Insert(0, longValue);
      buffer.Insert(0, "  ");
      buffer.Insert(0, floatValue);
      buffer.Insert(0, "  ");
      buffer.Insert(0, doubleValue);
      buffer.Insert(0, "  ");

      Console.WriteLine($"buffer after Inserts: \n{buffer}\n");

      buffer.Remove(10, 1); // delete 2 in 2.5      
      buffer.Remove(4, 4);  // delete .333 in 33.333

      Console.WriteLine($"buffer after Removes:\n{buffer}");
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
