// Fig. 10.15: ComplexTest.cs
// Overloading operators for complex numbers.
using System;

class ComplexTest
{
   static void Main()
   {
      // prompt the user to enter the first complex number
      Console.Write("Enter the real part of complex number x: ");
      double realPart = double.Parse(Console.ReadLine());
      Console.Write("Enter the imaginary part of complex number x: ");
      double imaginaryPart = double.Parse(Console.ReadLine());
      var x = new ComplexNumber(realPart, imaginaryPart);

      // prompt the user to enter the second complex number
      Console.Write("\nEnter the real part of complex number y: ");
      realPart = double.Parse(Console.ReadLine());
      Console.Write("Enter the imaginary part of complex number y: ");
      imaginaryPart = double.Parse(Console.ReadLine());
      var y = new ComplexNumber(realPart, imaginaryPart);

      // display the results of calculations with x and y
      Console.WriteLine();
      Console.WriteLine($"{x} + {y} = {x + y}");
      Console.WriteLine($"{x} - {y} = {x - y}");
      Console.WriteLine($"{x} * {y} = {x * y}");
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
