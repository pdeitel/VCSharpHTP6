// Fig. 21.8: FunctionalProgramming.cs
// Functional programming with LINQ extension methods and lambdas.
using System;
using System.Collections.Generic;
using System.Linq;

namespace FilterMapReduce
{
   class FunctionalProgramming
   {
      static void Main()
      {
         var values = new List<int> {3, 10, 6, 1, 4, 8, 2, 5, 9, 7};

         Console.Write("Original values: ");
         values.Display(); // call Display extension method

         // display the Min, Max, Sum and Average
         Console.WriteLine($"\nMin: {values.Min()}");
         Console.WriteLine($"Max: {values.Max()}");
         Console.WriteLine($"Sum: {values.Sum()}");
         Console.WriteLine($"Average: {values.Average()}");

         // sum of values via Aggregate
         Console.WriteLine("\nSum via Aggregate method: " +
            values.Aggregate(0, (x, y) => x + y));

         // sum of squares of values via Aggregate
         Console.WriteLine("Sum of squares via Aggregate method: " +
            values.Aggregate(0, (x, y) => x + y * y));

         // product of values via Aggregate
         Console.WriteLine("Product via Aggregate method: " +
            values.Aggregate(1, (x, y) => x * y));

         // even values displayed in sorted order
         Console.Write("\nEven values displayed in sorted order: ");
         values.Where(value => value % 2 == 0) // find even integers
               .OrderBy(value => value) // sort remaining values
               .Display(); // show results

         // odd values multiplied by 10 and displayed in sorted order
         Console.Write(
            "Odd values multiplied by 10 displayed in sorted order: ");
         values.Where(value => value % 2 != 0) // find odd integers
               .Select(value => value * 10) // multiply each by 10
               .OrderBy(value => value) // sort the values
               .Display(); // show results

         // display original values again to prove they were not modified
         Console.Write("\nOriginal values: ");
         values.Display(); // call Display extension method
      }
   }

   // declares an extension method 
   static class Extensions
   {
      // extension method that displays all elements separated by spaces
      public static void Display<T>(this IEnumerable<T> data)
      {
         Console.WriteLine(string.Join(" ", data));        
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
 **************************************************************************/

