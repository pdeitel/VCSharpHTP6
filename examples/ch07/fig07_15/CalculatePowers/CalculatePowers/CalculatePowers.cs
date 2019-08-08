// Fig. 7.15: CalculatePowers.cs
// Optional parameter demonstration with method Power.
using System;

class CalculatePowers
{
   // call Power with and without optional arguments
   static void Main()
   {
      Console.WriteLine($"Power(10) = {Power(10)}");
      Console.WriteLine($"Power(2, 10) = {Power(2, 10)}");
   }

   // use iteration to calculate power
   static int Power(int baseValue, int exponentValue = 2)
   {
      int result = 1;  

      for (int i = 1; i <= exponentValue; ++i)
      {
         result *= baseValue;
      }

      return result;
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
