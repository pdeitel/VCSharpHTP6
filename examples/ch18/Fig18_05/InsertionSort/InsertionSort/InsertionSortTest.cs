// Fig. 18.5: InsertionSortTest.cs
// Class that creates an array filled with random integers.  
// Provides a method to sort the array with insertion sort.
using System;

public class InsertionSortTest
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

      InsertionSort(data); // sort array

      Console.WriteLine("Sorted array:");
      Console.WriteLine(string.Join(" ", data) + "\n"); // display array
   }

   // sort array using insertion sort                            
   public static void InsertionSort(int[] values)
   {
      // loop over data.Length - 1 elements                      
      for (var next = 1; next < values.Length; ++next)
      {
         // store value in current element                       
         var insert = values[next];

         // initialize location to place element                 
         var moveItem = next;

         // search for place to put current element              
         while (moveItem > 0 && values[moveItem - 1] > insert)
         {
            // shift element right one slot                      
            values[moveItem] = values[moveItem - 1];
            moveItem--;
         }

         values[moveItem] = insert; // place inserted element    
         PrintPass(values, next, moveItem); // output pass of algorithm
      }
   }

   // display a pass of the algorithm
   public static void PrintPass(int[] values, int pass, int index)
   {
      Console.Write($"after pass {pass}: ");

      // output elements till swapped item
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
      for (var i = 0; i <= pass; ++i)
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
