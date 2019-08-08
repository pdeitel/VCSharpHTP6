// Fig. 10.10: Employee.cs
// static property used to maintain a count of the number of 
// Employee objects that have been created.
using System;

class Employee
{
   public static int Count { get; private set; } // objects in memory
   
   public string FirstName { get; }
   public string LastName { get; }

   // initialize employee, add 1 to static Count and 
   // output string indicating that constructor was called
   public Employee(string firstName, string lastName)
   {
      FirstName = firstName;
      LastName = lastName;
      ++Count; // increment static count of employees
      Console.WriteLine("Employee constructor: " +
         $"{FirstName} {LastName}; Count = {Count}");
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
