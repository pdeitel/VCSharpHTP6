// Fig. 18.4: SelectionSortTest.cs
// Class that creates an array filled with random integers. 
// Provides a method to sort the array with selection sort.
using System;

public class SelectionSortTest
{
   static void Main()
   {
      var generator = new Random();
      var data = new int[10]; // create space for array

      // fill array with random ints in range 10-99
      for (var i = 0; i < data.Length; ++i)
      {
         data[i] = generator.Next(10, 100);
      }

      Console.WriteLine("Unsorted array:");
      Console.WriteLine(string.Join(" ", data) + "\n"); // display array

      SelectionSort(data); // sort array

      Console.WriteLine("Sorted array:");
      Console.WriteLine(string.Join(" ", data) + "\n"); // display array
   }

   // sort array using selection sort                               
   public static void SelectionSort(int[] values)
   {
      // loop over data.Length - 1 elements                         
      for (var i = 0; i < values.Length - 1; ++i)
      {
         var smallest = i; // first index of remaining array            

         // loop to find index of smallest element                  
         for (var index = i + 1; index < values.Length; ++index)
         {
            if (values[index] < values[smallest])
            {
               smallest = index;
            }
         }

         Swap(ref values[i], ref values[smallest]); // swap elements
         PrintPass(values, i + 1, smallest); // output pass of algorithm  
      }
   }

   // helper method to swap values in two elements                
   public static void Swap(ref int first, ref int second)
   {
      var temporary = first; // store first in temporary  
      first = second; // replace first with second
      second = temporary; // put temporary in second      
   }

   // display a pass of the algorithm
   public static void PrintPass(int[] values, int pass, int index)
   {
      Console.Write($"after pass {pass}: ");

      // output elements through the selected item
      for (var i = 0; i < index; ++i)
      {
         Console.Write($"{values[i]}  ");
      }

      Console.Write($"{values[index]}* "); // indicate swap

      // finish outputting array
      for (var i = index + 1; i < values.Length; ++i)
      {
         Console.Write($"{values[i]}  ");
      }

      Console.Write("\n              "); // for alignment

      // indicate amount of array that is sorted
      for (var j = 0; j < pass; ++j)
      {
         Console.Write("--  ");
      }

      Console.WriteLine("\n"); // skip a line in output
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
