// Fig. 18.3: BinarySearchTest.cs
// Class that contains an array of random integers and a method 
// that uses binary search to find an integer.
using System;

public class BinarySearchTest
{
   static void Main()
   {
      var generator = new Random();
      var data = new int[15]; // create space for array

      // fill array with random ints in range 10-99
      for (var i = 0; i < data.Length; ++i)
      {
         data[i] = generator.Next(10, 100);
      }

      Array.Sort(data); // elements must be sorted in ascending order
      DisplayElements(data, 0, data.Length - 1); // display array

      // input first int from user
      Console.Write("\nPlease enter an integer value (-1 to quit): ");
      int searchInt = int.Parse(Console.ReadLine());

      // repeatedly input an integer; -1 terminates the app
      while (searchInt != -1)
      {
         // perform binary search
         int position = BinarySearch(data, searchInt);

         if (position != -1) // integer was found
         {
            Console.WriteLine($"The integer {searchInt} was found in " +
               $"position {position}.\n");
         }
         else // integer was not found
         {
            Console.WriteLine(
               $"The integer {searchInt} was not found.\n");
         }

         // input next int from user
         Console.Write("Please enter an integer value (-1 to quit): ");
         searchInt = int.Parse(Console.ReadLine());
      }
   }

   // perform a binary search on the data                          
   public static int BinarySearch(int[] values, int searchElement)
   {
      var low = 0; // low end of the search area                   
      var high = values.Length - 1; // high end of the search area   
      var middle = (low + high + 1) / 2; // middle element       

      do // loop to search for element                             
      {
         // display remaining elements of array 
         DisplayElements(values, low, high);

         // indicate current middle; pad left with spaces for alignment
         Console.WriteLine("-- ".PadLeft((middle + 1) * 3)); 

         // if the element is found at the middle                  
         if (searchElement == values[middle])
         {
            return middle; // search key found, so return its index    
         }
         // middle element is too high                             
         else if (searchElement < values[middle])
         {
            high = middle - 1; // eliminate the higher half        
         }
         else // middle element is too low                         
         {
            low = middle + 1; // eliminate the lower half          
         }

         middle = (low + high + 1) / 2; // recalculate the middle
      } while (low <= high);

      return -1; // search key was not found            
   }

   // method to output certain values in array
   public static void DisplayElements(int[] values, int low, int high)
   {
      // output three spaces for each element up to low for alignment
      Console.Write(string.Empty.PadLeft(low * 3));

      // output elements left in array
      for (var i = low; i <= high; ++i)
      {
         Console.Write($"{values[i]} ");
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
 **************************************************************************/
