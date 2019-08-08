// Fig. 16.12: StringBuilderAppendFormat.cs
// StringBuilder's AppendFormat method
using System;
using System.Text;

class StringBuilderAppendFormat
{
   static void Main()
   {
      var buffer = new StringBuilder();

      // formatted string                         
      var string1 = "This {0} costs: {1:C}.\n\n";

      // string1 argument array              
      var objectArray = new object[2] { "car", 1234.56 };

      // append to buffer formatted string with argument
      buffer.AppendFormat(string1, objectArray);

      // formatted string                              
      string string2 = "Number:\n{0:d3}.\n\n" +
         "Number right aligned with spaces:\n{0,4}.\n\n" +
         "Number left aligned with spaces:\n{0,-4}.";

      // append to buffer formatted string with argument
      buffer.AppendFormat(string2, 5);

      // display formatted strings
      Console.WriteLine(buffer.ToString());
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
