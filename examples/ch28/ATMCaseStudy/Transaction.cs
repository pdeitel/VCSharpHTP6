// Transaction.cs
// Abstract base class Transaction represents an ATM transaction.
public abstract class Transaction
{
   private int accountNumber; // account involved in the transaction
   private Screen userScreen; // reference to ATM's screen
   private BankDatabase database; // reference to account info database

   // three-parameter constructor invoked by derived classes
   public Transaction(int userAccount, Screen theScreen, 
      BankDatabase theDatabase)
   {
      accountNumber = userAccount;
      userScreen = theScreen;
      database = theDatabase;
   } 

   // read-only property that gets the account number
   public int AccountNumber
   {
      get
      {
         return accountNumber;
      } 
   } 

   // read-only property that gets the screen reference
   public Screen UserScreen
   {
      get
      {
         return userScreen;
      } 
   } 

   // read-only property that gets the bank database reference
   public BankDatabase Database
   {
      get
      {
         return database;
      } 
   } 

   // perform the transaction (overridden by each derived class)
   public abstract void Execute(); // no implementation here
} 


/**************************************************************************
 * (C) Copyright 1992-2006 by Deitel & Associates, Inc. and               *
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
