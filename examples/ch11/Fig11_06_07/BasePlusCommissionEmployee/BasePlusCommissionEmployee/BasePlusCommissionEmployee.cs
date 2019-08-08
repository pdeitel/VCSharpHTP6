// Fig. 11.6: BasePlusCommissionEmployee.cs
// BasePlusCommissionEmployee class represents an employee that receives
// a base salary in addition to a commission.
using System;

public class BasePlusCommissionEmployee
{
   public string FirstName { get; }
   public string LastName { get; }
   public string SocialSecurityNumber { get; }
   private decimal grossSales; // gross weekly sales 
   private decimal commissionRate; // commission percentage
   private decimal baseSalary; // base salary per week

   // six-parameter constructor
   public BasePlusCommissionEmployee(string firstName, string lastName,
      string socialSecurityNumber, decimal grossSales,
      decimal commissionRate, decimal baseSalary)
   {
      // implicit call to object constructor occurs here
      FirstName = firstName;
      LastName = lastName;
      SocialSecurityNumber = socialSecurityNumber;
      GrossSales = grossSales; // validates gross sales
      CommissionRate = commissionRate; // validates commission rate
      BaseSalary = baseSalary; // validates base salary
   }

   // property that gets and sets gross sales
   public decimal GrossSales
   {
      get
      {
         return grossSales;
      }
      set
      {
         if (value < 0) // validation
         {
            throw new ArgumentOutOfRangeException(nameof(value),
               value, $"{nameof(GrossSales)} must be >= 0");
         }

         grossSales = value;
      }
   }

   // property that gets and sets commission rate
   public decimal CommissionRate
   {
      get
      {
         return commissionRate;
      }
      set
      {
         if (value <= 0 || value >= 1) // validation
         {
            throw new ArgumentOutOfRangeException(nameof(value),
               value, $"{nameof(CommissionRate)} must be > 0 and < 1");
         }

         commissionRate = value;
      }
   }

   // property that gets and sets BasePlusCommissionEmployee's base salary
   public decimal BaseSalary
   {
      get
      {
         return baseSalary;
      }
      set
      {
         if (value < 0) // validation
         {
            throw new ArgumentOutOfRangeException(nameof(value),
               value, $"{nameof(BaseSalary)} must be >= 0");
         }

         baseSalary = value;
      }
   }

   // calculate earnings
   public decimal Earnings() =>
      baseSalary + (commissionRate * grossSales);

   // return string representation of BasePlusCommissionEmployee
   public override string ToString() =>
      $"base-salaried commission employee: {FirstName} {LastName}\n" +
      $"social security number: {SocialSecurityNumber}\n" +
      $"gross sales: {grossSales:C}\n" +
      $"commission rate: {commissionRate:F2}\n" +
      $"base salary: {baseSalary:C}";
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
