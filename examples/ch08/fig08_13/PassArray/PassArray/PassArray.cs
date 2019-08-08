// Fig. 8.13: PassArray.cs
// Passing arrays and individual array elements to methods.
using System;

class PassArray
{
   // Main creates array and calls ModifyArray and ModifyElement
   static void Main()
   {
      int[] array = {1, 2, 3, 4, 5};

      Console.WriteLine("Effects of passing reference to entire array:");
      Console.WriteLine("The values of the original array are:");

      // output original array elements 
      foreach (var value in array)
      {
         Console.Write($"   {value}");
      }

      ModifyArray(array); // pass array reference
      Console.WriteLine("\n\nThe values of the modified array are:");

      // output modified array elements 
      foreach (var value in array)
      {
         Console.Write($"   {value}");
      }

      Console.WriteLine("\n\nEffects of passing array element value:\n" +
         $"array[3] before ModifyElement: {array[3]}");

      ModifyElement(array[3]); // attempt to modify array[3]
      Console.WriteLine($"array[3] after ModifyElement: {array[3]}");
   }

   // multiply each element of an array by 2                     
   static void ModifyArray(int[] array2)
   {
      for (var counter = 0; counter < array2.Length; ++counter)
      {
         array2[counter] *= 2;
      }
   }

   // multiply argument by 2                                 
   static void ModifyElement(int element)
   {
      element *= 2;
      Console.WriteLine($"Value of element in ModifyElement: {element}");
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
