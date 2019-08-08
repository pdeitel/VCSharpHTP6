// BalanceInquiry.cs
// Represents a balance inquiry ATM transaction
public class BalanceInquiry : Transaction
{
   // five-parameter constructor initializes base class variables
   public BalanceInquiry(int userAccountNumber, 
      Screen atmScreen, BankDatabase atmBankDatabase)
      : base(userAccountNumber, atmScreen, atmBankDatabase) {}

   // performs transaction; overrides Transaction's abstract method
   public override void Execute()
   {
      // get the available balance for the current user's Account
      decimal availableBalance = 
         Database.GetAvailableBalance(AccountNumber);

      // get the total balance for the current user's Account
      decimal totalBalance = Database.GetTotalBalance(AccountNumber);

      // display the balance information on the screen
      UserScreen.DisplayMessageLine("\nBalance Information:");
      UserScreen.DisplayMessage(" - Available balance: ");
      UserScreen.DisplayDollarAmount(availableBalance);
      UserScreen.DisplayMessage("\n - Total balance: ");
      UserScreen.DisplayDollarAmount(totalBalance);
      UserScreen.DisplayMessageLine("");
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
