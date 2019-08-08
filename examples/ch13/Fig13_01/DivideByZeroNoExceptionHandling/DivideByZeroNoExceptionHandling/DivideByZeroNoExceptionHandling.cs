// Fig. 13.1: DivideByZeroNoExceptionHandling.cs
// Integer division without exception handling.
using System;

class DivideByZeroNoExceptionHandling
{
   static void Main()
   {
      // get numerator
      Console.Write("Please enter an integer numerator: ");
      var numerator = int.Parse(Console.ReadLine());

      // get denominator
      Console.Write("Please enter an integer denominator: ");
      var denominator = int.Parse(Console.ReadLine());

      // divide the two integers, then display the result
      var result = numerator / denominator;
      Console.WriteLine(
         $"\nResult: {numerator} / {denominator} = {result}");
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
 **************************************************************************/
