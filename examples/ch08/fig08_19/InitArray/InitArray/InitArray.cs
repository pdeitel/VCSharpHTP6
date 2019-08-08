// Fig. 8.19: InitArray.cs
// Initializing rectangular and jagged arrays.
using System;

class InitArray
{
   // create and output rectangular and jagged arrays
   static void Main()
   {
      // with rectangular arrays,
      // every row must be the same length.
      int[,] rectangular = {{1, 2, 3}, {4, 5, 6}};

      // with jagged arrays,
      // we need to use "new int[]" for every row,
      // but every row does not need to be the same length.
      int[][] jagged = {new int[] {1, 2},
                        new int[] {3},
                        new int[] {4, 5, 6}};

      OutputArray(rectangular); // displays array rectangular by row
      Console.WriteLine(); // output a blank line
      OutputArray(jagged); // displays array jagged by row
   }

   // output rows and columns of a rectangular array
   static void OutputArray(int[,] array)
   {
      Console.WriteLine("Values in the rectangular array by row are");

      // loop through array's rows                                      
      for (var row = 0; row < array.GetLength(0); ++row)
      {
         // loop through columns of current row                         
         for (var column = 0; column < array.GetLength(1); ++column)
         {
            Console.Write($"{array[row, column]}  ");
         }

         Console.WriteLine(); // start new line of output               
      }
   }

   // output rows and columns of a jagged array
   static void OutputArray(int[][] array)
   {
      Console.WriteLine("Values in the jagged array by row are");

      // loop through each row                           
      foreach (var row in array)
      {
         // loop through each element in current row     
         foreach (var element in row)
         {
            Console.Write($"{element}  ");
         }

         Console.WriteLine(); // start new line of output
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
