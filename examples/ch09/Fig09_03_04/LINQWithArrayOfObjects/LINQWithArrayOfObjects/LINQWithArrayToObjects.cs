// Fig. 9.4: LINQWithArrayOfObjects.cs
// LINQ to Objects querying an array of Employee objects.
using System;
using System.Linq;

class LINQWithArrayOfObjects
{
   static void Main()
   {
      // initialize array of employees
      var employees = new[] {
         new Employee("Jason", "Red", 5000M),
         new Employee("Ashley", "Green", 7600M),
         new Employee("Matthew", "Indigo", 3587.5M),
         new Employee("James", "Indigo", 4700.77M),
         new Employee("Luke", "Indigo", 6200M),
         new Employee("Jason", "Blue", 3200M),
         new Employee("Wendy", "Brown", 4236.4M)};

      // display all employees
      Console.WriteLine("Original array:");
      foreach (var element in employees)
      {
         Console.WriteLine(element);
      }

      // filter a range of salaries using && in a LINQ query
      var between4K6K =
         from e in employees
         where (e.MonthlySalary >= 4000M) && (e.MonthlySalary <= 6000M)
         select e;

      // display employees making between 4000 and 6000 per month
      Console.WriteLine("\nEmployees earning in the range " +
         $"{4000:C}-{6000:C} per month:");
      foreach (var element in between4K6K)
      {
         Console.WriteLine(element);
      }

      // order the employees by last name, then first name with LINQ
      var nameSorted =
         from e in employees
         orderby e.LastName, e.FirstName
         select e;

      // header
      Console.WriteLine("\nFirst employee when sorted by name:");

      // attempt to display the first result of the above LINQ query
      if (nameSorted.Any())
      {
         Console.WriteLine(nameSorted.First());
      }
      else
      {
         Console.WriteLine("not found");
      }

      // use LINQ to select employee last names
      var lastNames =
         from e in employees
         select e.LastName;

      // use method Distinct to select unique last names
      Console.WriteLine("\nUnique employee last names:");
      foreach (var element in lastNames.Distinct())
      {
         Console.WriteLine(element);
      }

      // use LINQ to select first and last names
      var names =
         from e in employees
         select new { e.FirstName, e.LastName };

      // display full names
      Console.WriteLine("\nNames only:");
      foreach (var element in names)
      {
         Console.WriteLine(element);
      }

      Console.WriteLine();
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
