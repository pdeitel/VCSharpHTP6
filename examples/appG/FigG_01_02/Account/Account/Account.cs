// Fig. G.1: Account.cs
// Account class with a Debit method that withdraws money from account.
using System;

public class Account
{
   private decimal balance; // instance variable that stores the balance

   // constructor  
   public Account(decimal initialBalance)
   {
      Balance = initialBalance; // set balance using property
   }

   // credits (adds) an amount to the account
   public void Credit(decimal amount)
   {
      Balance = Balance + amount; // add amount to balance 
   }

   // debit (subtracts) an amount from the account
   public void Debit(decimal amount)
   {
      if (amount > Balance)
      {
         Console.WriteLine("Debit amount exceeded account balance.");
      }

      if (amount <= Balance)
      {
         Balance = Balance - amount; // subtract amount from balance 
      }
   }

   // property to get the balance
   public decimal Balance
   {
      get
      {
         return balance;
      }
      set
      {
         // validate that value is greater than or equal to 0; 
         // if it is not, balance is left unchanged
         if (value >= 0)
         {
            balance = value;
         }
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
