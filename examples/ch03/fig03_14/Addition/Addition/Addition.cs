// Fig. 3.14: Addition.cs
// Displaying the sum of two numbers input from the keyboard.
using System;

class Addition
{
   // Main method begins execution of C# app
   static void Main()
   {
      int number1; // declare first number to add
      int number2; // declare second number to add
      int sum; // declare sum of number1 and number2

      Console.Write("Enter first integer: "); // prompt user 
      // read first number from user
      number1 = int.Parse(Console.ReadLine());

      Console.Write("Enter second integer: "); // prompt user
      // read second number from user
      number2 = int.Parse(Console.ReadLine());

      sum = number1 + number2; // add numbers

      Console.WriteLine($"Sum is {sum}"); // display sum
   } // end Main
} // end class Addition


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
