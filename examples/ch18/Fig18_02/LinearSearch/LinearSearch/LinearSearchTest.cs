// Fig. 18.2: LinearSearchTest.cs
// Class that contains an array of random integers and a method 
// that searches that array sequentially.
using System;

public class LinearSearchTest
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

      Console.WriteLine(string.Join(" ", data) + "\n"); // display array

      // input first int from user
      Console.Write("Enter an integer value (-1 to quit): ");
      var searchInt = int.Parse(Console.ReadLine());

      // repeatedly input an integer; -1 terminates the app
      while (searchInt != -1)
      {
         // perform linear search
         int position = LinearSearch(data, searchInt);

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
         Console.Write("Enter an integer value (-1 to quit): ");
         searchInt = int.Parse(Console.ReadLine());
      }
   }

   // perform a linear search on the data                     
   public static int LinearSearch(int[] values, int searchKey)
   {
      // loop through array sequentially                      
      for (var index = 0; index < values.Length; ++index)
      {
         if (values[index] == searchKey)
         {
            return index; // return the element's index       
         }
      }

      return -1; // integer was not found                     
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
