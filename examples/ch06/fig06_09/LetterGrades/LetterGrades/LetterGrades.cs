// Fig. 6.9: LetterGrades.cs
// Using a switch statement to count letter grades.
using System;

class GradeBook
{
   static void Main()
   {
      int total = 0; // sum of grades                  
      int gradeCounter = 0; // number of grades entered
      int aCount = 0; // count of A grades             
      int bCount = 0; // count of B grades             
      int cCount = 0; // count of C grades             
      int dCount = 0; // count of D grades             
      int fCount = 0; // count of F grades             

      Console.WriteLine("Enter the integer grades in the range 0-100.");
      Console.WriteLine(
         "Type <Ctrl> z and press Enter to terminate input:");

      string input = Console.ReadLine(); // read user input

      // loop until user enters the end-of-file indicator (<Ctrl> z)
      while (input != null)
      {
         int grade = int.Parse(input); // read grade off user input
         total += grade; // add grade to total
         ++gradeCounter; // increment number of grades

         // determine which grade was entered     
         switch (grade / 10)
         {
            case 9: // grade was in the 90s       
            case 10: // grade was 100             
               ++aCount; // increment aCount      
               break; // necessary to exit switch 
            case 8: // grade was between 80 and 89
               ++bCount; // increment bCount      
               break; // exit switch              
            case 7: // grade was between 70 and 79
               ++cCount; // increment cCount      
               break; // exit switch              
            case 6: // grade was between 60 and 69
               ++dCount; // increment dCount      
               break; // exit switch              
            default: // grade was less than 60    
               ++fCount; // increment fCount      
               break; // exit switch              
         }

         input = Console.ReadLine(); // read user input
      }

      Console.WriteLine("\nGrade Report:");

      // if user entered at least one grade...
      if (gradeCounter != 0)
      {
         // calculate average of all grades entered
         double average = (double)total / gradeCounter;

         // output summary of results
         Console.WriteLine(
            $"Total of the {gradeCounter} grades entered is {total}");
         Console.WriteLine($"Class average is {average:F}");
         Console.WriteLine("Number of students who received each grade:");
         Console.WriteLine($"A: {aCount}"); // display number of A grades
         Console.WriteLine($"B: {bCount}"); // display number of B grades
         Console.WriteLine($"C: {cCount}"); // display number of C grades
         Console.WriteLine($"D: {dCount}"); // display number of D grades
         Console.WriteLine($"F: {fCount}"); // display number of F grades
      }
      else // no grades were entered, so output appropriate message
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
