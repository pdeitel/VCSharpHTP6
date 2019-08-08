// Fig. 8.24: InitArray.cs
// Using command-line arguments to initialize an array.
using System;

class InitArray
{
   static void Main(string[] args)
   {
      // check number of command-line arguments
      if (args.Length != 3)
      {
         Console.WriteLine(
            "Error: Please re-enter the entire command, including\n" +
            "an array size, initial value and increment.");
      }
      else
      {
         // get array size from first command-line argument
         var arrayLength = int.Parse(args[0]);
         var array = new int[arrayLength]; // create array

         // get initial value and increment from command-line argument
         var initialValue = int.Parse(args[1]);
         var increment = int.Parse(args[2]);

         // calculate value for each array element                 
         for (var counter = 0; counter < array.Length; ++counter)
         {
            array[counter] = initialValue + increment * counter;
         }

         Console.WriteLine($"{"Index"}{"Value",8}");

         // display array index and value
         for (int counter = 0; counter < array.Length; ++counter)
         {
            Console.WriteLine($"{counter,5}{array[counter],8}");
         }
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
