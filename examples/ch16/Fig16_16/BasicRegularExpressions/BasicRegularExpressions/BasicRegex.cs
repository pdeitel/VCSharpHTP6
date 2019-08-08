// Fig 18.16: BasicRegex.cs
// Demonstrate basic regular expressions.
using System;
using System.Text.RegularExpressions;

class BasicRegex
{
   static void Main( string[] args )
   {
      string testString =
         "regular expressions are sometimes called regex or regexp";
      Console.WriteLine( "The test string is\n   \"{0}\"", testString );
      Console.Write( "Match 'e' in the test string: " );

      // match 'e' in the test string
      Regex expression = new Regex( "e" );
      Console.WriteLine( expression.Match( testString ) );
      Console.Write( "Match every 'e' in the test string: " );

      // match 'e' multiple times in the test string
      foreach ( var myMatch in expression.Matches( testString ) )
         Console.Write( "{0} ", myMatch );

      Console.Write( "\nMatch \"regex\" in the test string: " );

      // match 'regex' in the test string
      foreach ( var myMatch in Regex.Matches( testString, "regex" ) )
         Console.Write( "{0} ", myMatch );

      Console.Write( 
         "\nMatch \"regex\" or \"regexp\" using an optional 'p': " );

      // use the ? quantifier to include an optional 'p'
      foreach ( var myMatch in Regex.Matches( testString, "regexp?" ) )
         Console.Write( "{0} ", myMatch );

      // use alternation to match either 'cat' or 'hat'
      expression = new Regex( "(c|h)at" );
      Console.WriteLine(
         "\n\"hat cat\" matches {0}, but \"cat hat\" matches {1}",
         expression.Match( "hat cat" ), expression.Match( "cat hat" ) );
   } // end Main
} // end class BasicRegex


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