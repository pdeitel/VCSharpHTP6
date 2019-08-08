// Fig. 4.5: AccountTest.cs
// Creating and manipulating an Account object with properties.
using System;

class AccountTest
{
   static void Main()
   {
      // create an Account object and assign it to myAccount
      Account myAccount = new Account();

      // display myAccount's initial name 
      Console.WriteLine($"Initial name is: {myAccount.Name}");

      // prompt for and read the name, then put the name in the object
      Console.Write("Please enter the name: "); // prompt
      string theName = Console.ReadLine(); // read a line of text
      myAccount.Name = theName; // put theName in myAccount's Name

      // display the name stored in object myAccount
      Console.WriteLine($"myAccount's name is: {myAccount.Name}");
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
