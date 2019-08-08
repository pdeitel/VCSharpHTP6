// Fig. 21.6: Delegates.cs
// Using delegates to pass functions as arguments.
using System;
using System.Collections.Generic;

class Delegates
{
   // delegate for a function that receives an int and returns a bool
   public delegate bool NumberPredicate(int number);

   static void Main()
   {
      int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

      // create an instance of the NumberPredicate delegate type
      NumberPredicate evenPredicate = IsEven;

      // call IsEven using a delegate variable
      Console.WriteLine(
         $"Call IsEven using a delegate variable: {evenPredicate(4)}");

      // filter the even numbers using method IsEven                  
      List<int> evenNumbers = FilterArray(numbers, evenPredicate);

      // display the result
      DisplayList("Use IsEven to filter even numbers: ", evenNumbers);

      // filter the odd numbers using method IsOdd           
      List<int> oddNumbers = FilterArray(numbers, IsOdd);

      // display the result
      DisplayList("Use IsOdd to filter odd numbers: ", oddNumbers);

      // filter numbers greater than 5 using method IsOver5      
      List<int> numbersOver5 = FilterArray(numbers, IsOver5);

      // display the result
      DisplayList("Use IsOver5 to filter numbers over 5: ", numbersOver5);
   }

   // select an array's elements that satisfy the predicate
   private static List<int> FilterArray(int[] intArray,
      NumberPredicate predicate)
   {
      // hold the selected elements
      var result = new List<int>();

      // iterate over each element in the array
      foreach (var item in intArray)
      {
         // if the element satisfies the predicate
         if (predicate(item)) // invokes method referenced by predicate
         {
            result.Add(item); // add the element to the result
         }
      }

      return result; // return the result
   }

   // determine whether an int is even
   private static bool IsEven(int number) => number % 2 == 0;

   // determine whether an int is odd
   private static bool IsOdd(int number) => number % 2 == 1;

   // determine whether an int greater than 5
   private static bool IsOver5(int number) => number > 5;

   // display the elements of a List
   private static void DisplayList(string description, List<int> list)
   {
      Console.Write(description); // display the output's description

      // iterate over each element in the List
      foreach (var item in list)
      {
         Console.Write($"{item} "); // print item followed by a space
      }

      Console.WriteLine(); // add a new line
   }
} 

/**************************************************************************
 * (C) Copyright 1992-2014 by Deitel & Associates, Inc. and               *
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
