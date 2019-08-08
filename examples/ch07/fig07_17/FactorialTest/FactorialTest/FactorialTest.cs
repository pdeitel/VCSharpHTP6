// Fig. 7.17: FactorialTest.cs
// Recursive Factorial method.
using System;

class FactorialTest
{
   static void Main()
   {
      // calculate the factorials of 0 through 10
      for (long counter = 0; counter <= 10; ++counter)
      {
         Console.WriteLine($"{counter}! = {Factorial(counter)}");
      }
   }

   // recursive declaration of method Factorial  
   static long Factorial(long number)
   {
      // base case                               
      if (number <= 1)
      {
         return 1;
      }
      else // recursion step 
      {
         return number * Factorial(number - 1);
      }
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
