// Fig. 5.12: Analysis.cs
// Analysis of examination results, using nested control statements.
using System;

class Analysis
{
   static void Main()
   {
      // initialize variables in declarations   
      int passes = 0; // number of passes       
      int failures = 0; // number of failures   
      int studentCounter = 1; // student counter

      // process 10 students using counter-controlled iteration
      while (studentCounter <= 10)
      {
         // prompt user for input and obtain a value from the user
         Console.Write("Enter result (1 = pass, 2 = fail): ");
         int result = int.Parse(Console.ReadLine());

         // if...else is nested in the while statement           
         if (result == 1)
         {
            passes = passes + 1; // increment passes      
         }
         else
         {
            failures = failures + 1; // increment failures
         }

         // increment studentCounter so loop eventually terminates
         studentCounter = studentCounter + 1;
      } 

      // termination phase; prepare and display results
      Console.WriteLine($"Passed: {passes}\nFailed: {failures}");

      // determine whether more than 8 students passed
      if (passes > 8)
      {
         Console.WriteLine("Bonus to instructor!");
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
