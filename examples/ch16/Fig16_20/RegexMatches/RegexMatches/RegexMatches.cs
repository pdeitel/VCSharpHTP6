// Fig. 16.20: RegexMatches.cs
// A more complex regular expression.
using System;
using System.Text.RegularExpressions;

class RegexMatches
{
   static void Main( string[] args )
   {
      // create a regular expression
      Regex expression = new Regex( @"J.*\d[\d-[4]]-\d\d-\d\d" );

      string testString =
         "Jane's Birthday is 05-12-75\n" +
         "Dave's Birthday is 11-04-68\n" +
         "John's Birthday is 04-28-73\n" +
         "Joe's Birthday is 12-17-77";

      // display all matches to the regular expression
      foreach ( var regexMatch in expression.Matches( testString ) )
         Console.WriteLine( regexMatch );
   } // end Main
} // end class RegexMatches

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