// Exercise 6.10 Solution: Printing.cs
using System;

class Printing
{
   static void Main()
   {
      for (int i = 1; i <= 10; ++i)
      {
         for (int j = 1; j <= 5; ++j)
         {
            Console.Write('@');
         }

         Console.WriteLine();
      }
   }
}