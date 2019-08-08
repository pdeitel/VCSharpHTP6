// Fig. 4.11: Account.cs
// Account class with a balance and a Deposit method.

class Account
{
   public string Name { get; set; } // auto-implemented property
   private decimal balance; // instance variable

   // Account constructor that receives two parameters  
   public Account(string accountName, decimal initialBalance) 
   {
      Name = accountName;
      Balance = initialBalance; // Balance's set accessor validates
   }

   // Balance property with validation
   public decimal Balance
   {
      get
      {
         return balance;
      }
      private set // can be used only within the class
      {
         // validate that the balance is greater than 0.0; if it's not,
         // instance variable balance keeps its prior value
         if (value > 0.0m) // m indicates that 0.0 is a decimal literal
         {
            balance = value;
         }
      }
   }

   // method that deposits (adds) only a valid amount to the balance
   public void Deposit(decimal depositAmount)
   {
      if (depositAmount > 0.0m) // if the depositAmount is valid
      {
         Balance = Balance + depositAmount; // add it to the balance 
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
