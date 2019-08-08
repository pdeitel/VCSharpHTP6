// Fig. 8.15: GradeBook.cs
// Grade book using an array to store test grades.
using System;

class GradeBook
{
   private int[] grades; // array of student grades

   // getter-only auto-implemented property CourseName
   public string CourseName { get; }

   // two-parameter constructor initializes  
   // auto-implemented property CourseName and grades array
   public GradeBook(string name, int[] gradesArray)
   {
      CourseName = name; // set CourseName to name
      grades = gradesArray; // initialize grades array
   }

   // display a welcome message to the GradeBook user
   public void DisplayMessage()
   {
      // auto-implemented property CourseName gets the name of course
      Console.WriteLine(
         $"Welcome to the grade book for\n{CourseName}!\n");
   }

   // perform various operations on the data
   public void ProcessGrades()
   {
      // output grades array
      OutputGrades();

      // call method GetAverage to calculate the average grade      
      Console.WriteLine($"\nClass average is {GetAverage():F}");

      // call methods GetMinimum and GetMaximum
      Console.WriteLine($"Lowest grade is {GetMinimum()}");
      Console.WriteLine($"Highest grade is {GetMaximum()}\n");

      // call OutputBarChart to display grade distribution chart
      OutputBarChart();
   }

   // find minimum grade
   public int GetMinimum()
   {
      var lowGrade = grades[0]; // assume grades[0] is smallest

      // loop through grades array                             
      foreach (var grade in grades)
      {
         // if grade lower than lowGrade, assign it to lowGrade
         if (grade < lowGrade)
         {
            lowGrade = grade; // new lowest grade              
         }
      }

      return lowGrade; // return lowest grade
   }

   // find maximum grade
   public int GetMaximum()
   {
      var highGrade = grades[0]; // assume grades[0] is largest

      // loop through grades array
      foreach (var grade in grades)
      {
         // if grade greater than highGrade, assign it to highGrade
         if (grade > highGrade)
         {
            highGrade = grade; // new highest grade
         }
      }

      return highGrade; // return highest grade
   }

   // determine average grade for test
   public double GetAverage()
   {
      var total = 0.0; // initialize total as a double

      // sum students' grades  
      foreach (var grade in grades)
      {
         total += grade;
      }

      // return average of grades
      return total / grades.Length;
   }

   // output bar chart displaying grade distribution
   public void OutputBarChart()
   {
      Console.WriteLine("Grade distribution:");

      // stores frequency of grades in each range of 10 grades
      var frequency = new int[11];

      // for each grade, increment the appropriate frequency
      foreach (var grade in grades)
      {
         ++frequency[grade / 10];
      }

      // for each grade frequency, display bar in chart
      for (var count = 0; count < frequency.Length; ++count)
      {
         // output bar label ("00-09: ", ..., "90-99: ", "100: ")
         if (count == 10)
         {
            Console.Write("  100: ");
         }
         else
         {
            Console.Write($"{count * 10:D2}-{count * 10 + 9:D2}: ");
         }

         // display bar of asterisks
         for (var stars = 0; stars < frequency[count]; ++stars)
         {
            Console.Write("*");
         }

         Console.WriteLine(); // start a new line of output
      }
   }

   // output the contents of the grades array
   public void OutputGrades()
   {
      Console.WriteLine("The grades are:\n");

      // output each student's grade                             
      for (var student = 0; student < grades.Length; ++student)
      {
         Console.WriteLine(
            $"Student {student + 1, 2}: {grades[student],3}");
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
