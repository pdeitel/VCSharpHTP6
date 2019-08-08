// Fig. 5.5: Student.cs
// Student class that stores a student name and average.
using System;

class Student
{
   public string Name { get; set; } // property
   private int average; // instance variable

   // constructor initializes Name and Average properties
   public Student(string studentName, int studentAverage)
   {
      Name = studentName;
      Average = studentAverage; // sets average instance variable
   }

   // property to get and set instance variable average
   public int Average
   {
      get // returns the Student's average
      {
         return average;
      }
      set  // sets the Student's average
      {
         // validate that studentAverage is > 0 and <= 100; otherwise,
         // keep instance variable average's current value  
         if (value > 0)
         {
            if (value <= 100)
            {
               average = value; // assign to instance variable
            }
         }
      }
   }

   // returns the Student's letter grade, based on the average
   public string LetterGrade
   {
      get
      {
         string letterGrade = string.Empty; // string.Empty is ""

         if (average >= 90)
         {
            letterGrade = "A";
         }
         else if (average >= 80)
         {
            letterGrade = "B";
         }
         else if (average >= 70)
         {
            letterGrade = "C";
         }
         else if (average >= 60)
         {
            letterGrade = "D";
         }
         else 
         {
            letterGrade = "F";
         }

         return letterGrade;
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
