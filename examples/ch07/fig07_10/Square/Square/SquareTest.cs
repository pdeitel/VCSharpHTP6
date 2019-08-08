// Fig. 7.10: SquareTest.cs
// Square method used to demonstrate the method 
// call stack and activation records.
using System;

class SquareTest
{
   static void Main()
   {
      int x = 10; // value to square (local variable in main)
      Console.WriteLine($"x squared: {Square(x)}");
   }

   // returns the square of an integer
   static int Square(int y) // y is a local variable
   { 
      return y * y; // calculate square of y and return result
   }
}
