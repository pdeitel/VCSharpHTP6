// Fig. 7.20: ReferenceAndOutputParameters.cs
// Reference, output and value parameters.
using System;

class ReferenceAndOutputParameters
{
   // call methods with reference, output and value parameters
   static void Main()
   {
      int y = 5; // initialize y to 5
      int z; // declares z, but does not initialize it

      // display original values of y and z
      Console.WriteLine($"Original value of y: {y}");
      Console.WriteLine("Original value of z: uninitialized\n");

      // pass y and z by reference               
      SquareRef(ref y); // must use keyword ref
      SquareOut(out z); // must use keyword out

      // display values of y and z after they’re modified by 
      // methods SquareRef and SquareOut, respectively
      Console.WriteLine($"Value of y after SquareRef: {y}");
      Console.WriteLine($"Value of z after SquareOut: {z}\n");

      // pass y and z by value
      Square(y);
      Square(z);

      // display values of y and z after they’re passed to method Square
      // to demonstrate that arguments passed by value are not modified
      Console.WriteLine($"Value of y after Square: {y}");
      Console.WriteLine($"Value of z after Square: {z}");
   }

   // uses reference parameter x to modify caller's variable
   static void SquareRef(ref int x)
   {
      x = x * x; // squares value of caller's variable
   }

   // uses output parameter x to assign a value 
   // to an uninitialized variable
   static void SquareOut(out int x)
   {
      x = 6; // assigns a value to caller's variable
      x = x * x; // squares value of caller's variable
   }

   // parameter x receives a copy of the value passed as an argument,
   // so this method cannot modify the caller's variable
   static void Square(int x)
   {
      x = x * x;
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
