// Fig. 9.2: LINQWithSimpleTypeArray.cs
// LINQ to Objects using an int array.
using System;
using System.Linq;

class LINQWithSimpleTypeArray
{
   static void Main()
   {
      // create an integer array
      var values = new[] {2, 9, 5, 0, 3, 7, 1, 4, 8, 5};

      // display original values
      Console.Write("Original array:");
      foreach (var element in values)
      {
         Console.Write($" {element}");
      }

      // LINQ query that obtains values greater than 4 from the array
      var filtered =
         from value in values // data source is values
         where value > 4
         select value;

      // display filtered results
      Console.Write("\nArray values greater than 4:");
      foreach (var element in filtered)
      {
         Console.Write($" {element}");
      }

      // use orderby clause to sort original values in ascending order
      var sorted =
         from value in values // data source is values
         orderby value
         select value;

      // display sorted results
      Console.Write("\nOriginal array, sorted:");
      foreach (var element in sorted)
      {
         Console.Write($" {element}");
      }

      // sort the filtered results into descending order
      var sortFilteredResults =
         from value in filtered   // data source is LINQ query filtered
         orderby value descending
         select value;

      // display the sorted results
      Console.Write(
         "\nValues greater than 4, descending order (two queries):");
      foreach (var element in sortFilteredResults)
      {
         Console.Write($" {element}");
      }

      // filter original array and sort results in descending order
      var sortAndFilter =
         from value in values     // data source is values
         where value > 4
         orderby value descending
         select value;

      // display the filtered and sorted results
      Console.Write(
         "\nValues greater than 4, descending order (one query):");
      foreach (var element in sortAndFilter)
      {
         Console.Write($" {element}");
      }

      Console.WriteLine();
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
