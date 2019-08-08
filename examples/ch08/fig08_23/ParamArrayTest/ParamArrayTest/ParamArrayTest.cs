// Fig. 8.23: ParamArrayTest.cs
// Using variable-length argument lists.
using System;

class ParamArrayTest
{
   // calculate average
   static double Average(params double[] numbers)
   {
      var total = 0.0; // initialize total

      // calculate total using the foreach statement
      foreach (var d in numbers)
      {
         total += d;
      }

      return numbers.Length != 0 ? total / numbers.Length : 0.0;
   }

   static void Main()
   {
      var d1 = 10.0;
      var d2 = 20.0;
      var d3 = 30.0;
      var d4 = 40.0;

      Console.WriteLine(
         $"d1 = {d1:F1}\nd2 = {d2:F1}\nd3 = {d3:F1}\nd4 = {d4:F1}\n");
      Console.WriteLine($"Average of d1 and d2 is {Average(d1, d2):F1}");
      Console.WriteLine(
         $"Average of d1, d2 and d3 is {Average(d1, d2, d3):F1}");
      Console.WriteLine(
         $"Average of d1, d2, d3 and d4 is {Average(d1, d2, d3, d4):F1}");
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
