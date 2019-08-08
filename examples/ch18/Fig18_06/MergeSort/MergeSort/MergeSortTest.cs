// Fig. 18.6: MergeSortTest.cs
// Class that creates an array filled with random integers.  
// Provides a method to sort the array with merge sort.
using System;

public class MergeSortTest
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

      MergeSort(data); // sort array

      Console.WriteLine("Sorted array:");
      Console.WriteLine(string.Join(" ", data) + "\n"); // display array
   }

   // calls recursive SortArray method to begin merge sorting
   public static void MergeSort(int[] values)
   {
      SortArray(values, 0, values.Length - 1); // sort entire array
   }

   // splits array, sorts subarrays and merges subarrays into sorted array
   private static void SortArray(int[] values, int low, int high)
   {
      // test base case; size of array equals 1                        
      if ((high - low) >= 1) // if not base case                   
      {
         int middle1 = (low + high) / 2; // calculate middle of array
         int middle2 = middle1 + 1; // calculate next element over     

         // output split step                                          
         Console.WriteLine($"split:   {Subarray(values, low, high)}");
         Console.WriteLine($"         {Subarray(values, low, middle1)}");
         Console.WriteLine($"         {Subarray(values, middle2, high)}");
         Console.WriteLine();

         // split array in half; sort each half (recursive calls)      
         SortArray(values, low, middle1); // first half of array 
         SortArray(values, middle2, high); // second half of array   

         // merge two sorted arrays after split calls return           
         Merge(values, low, middle1, middle2, high);
      }
   }

   // merge two sorted subarrays into one sorted subarray             
   private static void Merge(int[] values, int left, int middle1, 
      int middle2, int right)
   {
      int leftIndex = left; // index into left subarray               
      int rightIndex = middle2; // index into right subarray          
      int combinedIndex = left; // index into temporary working array 
      int[] combined = new int[values.Length]; // working array       

      // output two subarrays before merging                          
      Console.WriteLine($"merge:   {Subarray(values, left, middle1)}");
      Console.WriteLine($"         {Subarray(values, middle2, right)}");

      // merge arrays until reaching end of either                    
      while (leftIndex <= middle1 && rightIndex <= right)
      {
         // place smaller of two current elements into result         
         // and move to next space in arrays                          
         if (values[leftIndex] <= values[rightIndex])
         {
            combined[combinedIndex++] = values[leftIndex++];
         }
         else
         {
            combined[combinedIndex++] = values[rightIndex++];
         }
      }

      // if left array is empty                                       
      if (leftIndex == middle2)
      {
         // copy in rest of right array                               
         while (rightIndex <= right)
         {
            combined[combinedIndex++] = values[rightIndex++];
         }
      }
      else // right array is empty                                    
      {
         // copy in rest of left array                                
         while (leftIndex <= middle1)
         {
            combined[combinedIndex++] = values[leftIndex++];
         }
      }

      // copy values back into original array                         
      for (int i = left; i <= right; ++i)
      {
         values[i] = combined[i];
      }

      // output merged array                                          
      Console.WriteLine($"         {Subarray(values, left, right)}");
      Console.WriteLine();
   }

   // method to output certain values in array
   public static string Subarray(int[] values, int low, int high)
   {
      string temporary = string.Empty.PadLeft(low * 3);

      // output elements left in array
      for (int i = low; i <= high; ++i)
      {
         temporary += $" {values[i]}";
      }

      return temporary;
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
