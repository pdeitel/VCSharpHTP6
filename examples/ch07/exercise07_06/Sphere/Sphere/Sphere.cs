// Exercise 7.6 Solution: Sphere.cs
// Calculate the volume of a sphere.
using System;

class Sphere
{
   // obtain radius from user and display volume of sphere
   static void Main()
   {
      Console.Write("Enter radius of sphere: ");
      double radius = double.Parse(Console.ReadLine());
      Console.WriteLine($"Volume is {SphereVolume(radius):F3}");
   }

   // calculate and return sphere volume
   static double SphereVolume(double radius) =>
      (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
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
