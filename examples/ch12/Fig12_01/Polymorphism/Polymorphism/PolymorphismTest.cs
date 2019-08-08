// Fig. 12.1: PolymorphismTest.cs
// Assigning base-class and derived-class references to base-class and
// derived-class variables.
using System;

class PolymorphismTest
{
   static void Main()
   {
      // assign base-class reference to base-class variable
      var commissionEmployee = new CommissionEmployee(
         "Sue", "Jones", "222-22-2222", 10000.00M, .06M);

      // assign derived-class reference to derived-class variable
      var basePlusCommissionEmployee = new BasePlusCommissionEmployee(
         "Bob", "Lewis", "333-33-3333", 5000.00M, .04M, 300.00M);

      // invoke ToString and Earnings on base-class object 
      // using base-class variable
      Console.WriteLine(
         "Call CommissionEmployee's ToString and Earnings methods " +
         "with base-class reference to base class object\n");
      Console.WriteLine(commissionEmployee.ToString());
      Console.WriteLine($"earnings: {commissionEmployee.Earnings()}\n");

      // invoke ToString and Earnings on derived-class object 
      // using derived-class variable      
      Console.WriteLine("Call BasePlusCommissionEmployee's ToString and" +
         " Earnings methods with derived class reference to" +
         " derived-class object\n");
      Console.WriteLine(basePlusCommissionEmployee.ToString());
      Console.WriteLine(
         $"earnings: {basePlusCommissionEmployee.Earnings()}\n");

      // invoke ToString and Earnings on derived-class object 
      // using base-class variable
      CommissionEmployee commissionEmployee2 = basePlusCommissionEmployee;
      Console.WriteLine(
         "Call BasePlusCommissionEmployee's ToString and Earnings " +
         "methods with base class reference to derived-class object\n");
      Console.WriteLine(commissionEmployee2.ToString());
      Console.WriteLine(
         $"earnings: {basePlusCommissionEmployee.Earnings()}\n");
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
