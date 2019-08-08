// Fig. 20.8: StackTest.cs
// Testing generic class Stack.
using System;

class StackTest
{
   // create arrays of doubles and ints
   private static double[] doubleElements =
      {1.1, 2.2, 3.3, 4.4, 5.5, 6.6};
   private static int[] intElements =
      {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};

   private static Stack<double> doubleStack; // stack stores doubles
   private static Stack<int> intStack; // stack stores ints  

   static void Main()
   {
      doubleStack = new Stack<double>(5); // stack of doubles
      intStack = new Stack<int>(10); // stack of ints

      TestPushDouble(); // push doubles onto doubleStack
      TestPopDouble(); // pop doubles from doubleStack
      TestPushInt(); // push ints onto intStack
      TestPopInt(); // pop ints from intStack
   }

   // test Push method with doubleStack
   private static void TestPushDouble()
   {
      // push elements onto stack
      try
      {
         Console.WriteLine("\nPushing elements onto doubleStack");

         // push elements onto stack
         foreach (var element in doubleElements)
         {
            Console.Write($"{element:F1} ");
            doubleStack.Push(element); // push onto doubleStack
         }
      }
      catch (FullStackException exception)
      {
         Console.Error.WriteLine($"\nMessage: {exception.Message}");
         Console.Error.WriteLine(exception.StackTrace);
      }
   }

   // test Pop method with doubleStack
   private static void TestPopDouble()
   {
      // pop elements from stack
      try
      {
         Console.WriteLine("\nPopping elements from doubleStack");

         double popValue; // store element removed from stack

         // remove all elements from stack
         while (true)
         {
            popValue = doubleStack.Pop(); // pop from doubleStack
            Console.Write($"{popValue:F1} ");
         }
      }
      catch (EmptyStackException exception)
      {
         Console.Error.WriteLine($"\nMessage: {exception.Message}");
         Console.Error.WriteLine(exception.StackTrace);
      }
   }

   // test Push method with intStack
   private static void TestPushInt()
   {
      // push elements onto stack
      try
      {
         Console.WriteLine("\nPushing elements onto intStack");

         // push elements onto stack
         foreach (var element in intElements)
         {
            Console.Write($"{element} ");
            intStack.Push(element); // push onto intStack
         }
      }
      catch (FullStackException exception)
      {
         Console.Error.WriteLine($"\nMessage: {exception.Message}");
         Console.Error.WriteLine(exception.StackTrace);
      }
   }

   // test Pop method with intStack
   private static void TestPopInt()
   {
      // pop elements from stack
      try
      {
         Console.WriteLine("\nPopping elements from intStack");

         int popValue; // store element removed from stack

         // remove all elements from stack
         while (true)
         {
            popValue = intStack.Pop(); // pop from intStack
            Console.Write($"{popValue:F1} ");
         }
      }
      catch (EmptyStackException exception)
      {
         Console.Error.WriteLine($"\nMessage: {exception.Message}");
         Console.Error.WriteLine(exception.StackTrace);
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
