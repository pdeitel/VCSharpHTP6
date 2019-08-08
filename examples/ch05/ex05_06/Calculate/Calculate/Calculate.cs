// Ex. 5.6: Calculate.cs
// Calculate the sum of the integers from 1 to 10 
using System;

class Calculate
{
   static void Main()
   {
      int sum = 0; // initialize sum to 0 for totaling
      int x = 1; // initialize x to 1 for counting

      while (x <= 10) // while x is less than or equal to 10      
      {
         sum += x; // add x to sum
         ++x; // increment x
      } // end while

      Console.WriteLine($"The sum is: {sum}");
   }
}
