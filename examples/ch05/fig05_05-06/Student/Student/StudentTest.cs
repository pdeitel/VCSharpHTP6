// Fig. 5.6: StudentTest.cs
// Create and test Student objects.
using System;

class StudentTest
{
   static void Main()
   {
      Student student1 = new Student("Jane Green", 93);
      Student student2 = new Student("John Blue", 72);

      Console.Write($"{student1.Name}'s letter grade equivalent of ");
      Console.WriteLine($"{student1.Average} is {student1.LetterGrade}");
      Console.Write($"{student2.Name}'s letter grade equivalent of ");
      Console.WriteLine($"{student2.Average} is {student2.LetterGrade}");
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
