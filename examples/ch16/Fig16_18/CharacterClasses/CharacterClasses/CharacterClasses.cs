// Fig. 16.18: CharacterClasses.cs
// Demonstrate using character classes and quantifiers.
using System;
using System.Text.RegularExpressions;

class CharacterClasses
{
   static void Main( string[] args )
   {
      string testString = "abc, DEF, 123";
      Console.WriteLine( "The test string is: \"{0}\"", testString );

      // find the digits in the test string
      Console.WriteLine( "Match any digit" );
      DisplayMatches( testString, @"\d" );

      // find anything that isn't a digit
      Console.WriteLine( "\nMatch any non-digit" );
      DisplayMatches( testString, @"\D" );

      // find the word characters in the test string
      Console.WriteLine( "\nMatch any word character" );
      DisplayMatches( testString, @"\w" );

      // find sequences of word characters
      Console.WriteLine( 
         "\nMatch a group of at least one word character" );
      DisplayMatches( testString, @"\w+" );

      // use a lazy quantifier
      Console.WriteLine( 
         "\nMatch a group of at least one word character (lazy)" );
      DisplayMatches( testString, @"\w+?" );

      // match characters from 'a' to 'f'
      Console.WriteLine( "\nMatch anything from 'a' - 'f'" );
      DisplayMatches( testString, "[a-f]" );

      // match anything that isn't in the range 'a' to 'f'
      Console.WriteLine( "\nMatch anything not from 'a' - 'f'" );
      DisplayMatches( testString, "[^a-f]" );

      // match any sequence of letters in any case
      Console.WriteLine( "\nMatch a group of at least one letter" );
      DisplayMatches( testString, "[a-zA-Z]+" );

      // use the . (dot) metacharacter to match any character
      Console.WriteLine( "\nMatch a group of any characters" );
      DisplayMatches( testString, ".*" );
   } // end Main

   // display the matches to a regular expression
   private static void DisplayMatches( string input, string expression )
   {
      foreach ( var regexMatch in Regex.Matches( input, expression ) )
         Console.Write( "{0} ", regexMatch );

      Console.WriteLine(); // move to the next line
   } // end method DisplayMatches
} // end class CharacterClasses

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