// Fig. 11.7: BasePlusCommissionEmployeeTest.cs
// Testing class BasePlusCommissionEmployee.
using System;

public class BasePlusCommissionEmployeeTest
{
   static void Main()
   {
      // instantiate BasePlusCommissionEmployee object
      var employee = new BasePlusCommissionEmployee("Bob", "Lewis",
         "333-33-3333", 5000.00M, .04M, 300.00M);

      // display BasePlusCommissionEmployee's data
      Console.WriteLine(
         "Employee information obtained by properties and methods: \n");
      Console.WriteLine($"First name is {employee.FirstName}");
      Console.WriteLine($"Last name is {employee.LastName}");
      Console.WriteLine(
         $"Social security number is {employee.SocialSecurityNumber}");
      Console.WriteLine($"Gross sales are {employee.GrossSales:C}");
      Console.WriteLine(
         $"Commission rate is {employee.CommissionRate:F2}");
      Console.WriteLine($"Earnings are {employee.Earnings():C}");
      Console.WriteLine($"Base salary is {employee.BaseSalary:C}");

      employee.BaseSalary = 1000.00M; // set base salary

      Console.WriteLine(
         "\nUpdated employee information obtained by ToString:\n");
      Console.WriteLine(employee);
      Console.WriteLine($"earnings: {employee.Earnings():C}");
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
