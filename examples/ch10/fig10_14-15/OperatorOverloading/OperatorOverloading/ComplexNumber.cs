// Fig. 10.14: ComplexNumber.cs
// Value type that overloads operators for adding, subtracting
// and multiplying complex numbers.
using System;

public struct ComplexNumber
{
   // read-only properties that get the real and imaginary components
   public double Real { get; }
   public double Imaginary { get; }

   // constructor
   public ComplexNumber(double real, double imaginary)
   {
      Real = real;
      Imaginary = imaginary;
   }

   // return string representation of ComplexNumber
   public override string ToString() =>
      $"({Real} {(Imaginary < 0 ? "-" : "+")} {Math.Abs(Imaginary)}i)";

   // overload the addition operator
   public static ComplexNumber operator+(ComplexNumber x, ComplexNumber y)
   {
      return new ComplexNumber(x.Real + y.Real,
         x.Imaginary + y.Imaginary);
   }

   // overload the subtraction operator         
   public static ComplexNumber operator-(ComplexNumber x, ComplexNumber y)
   {
      return new ComplexNumber(x.Real - y.Real,
         x.Imaginary - y.Imaginary);
   }

   // overload the multiplication operator
   public static ComplexNumber operator*(ComplexNumber x, ComplexNumber y)
   {
      return new ComplexNumber(
         x.Real * y.Real - x.Imaginary * y.Imaginary,
         x.Real * y.Imaginary + y.Real * x.Imaginary);
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
