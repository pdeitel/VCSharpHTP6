// Fig. 5.11: ClassAverage.cs
// Solving the class-average problem using sentinel-controlled iteration. 
using System;

class ClassAverage
{
   static void Main()
   {
      // initialization phase
      int total = 0; // initialize sum of grades
      int gradeCounter = 0; // initialize # of grades entered so far

      // processing phase
      // prompt for input and read grade from user    
      Console.Write("Enter grade or -1 to quit: ");
      int grade = int.Parse(Console.ReadLine());

      // loop until sentinel value is read from the user
      while (grade != -1)
      {
         total = total + grade; // add grade to total
         gradeCounter = gradeCounter + 1; // increment counter

         // prompt for input and read grade from user 
         Console.Write("Enter grade or -1 to quit: ");
         grade = int.Parse(Console.ReadLine());
      }

      // termination phase
      // if the user entered at least one grade...
      if (gradeCounter != 0)
      {
         // use number with decimal point to calculate average of grades
         double average = (double)total / gradeCounter;

         // display the total and average (with two digits of precision)
         Console.WriteLine(
            $"\nTotal of the {gradeCounter} grades entered is {total}");
         Console.WriteLine($"Class average is {average:F}");
      }
      else // no grades were entered, so output error message
      {
         Console.WriteLine("No grades were entered");
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
