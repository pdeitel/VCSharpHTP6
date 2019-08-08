// Fig. 16.22: RegexSubstitution.cs
// Using Regex methods Replace and Split.
using System;
using System.Text.RegularExpressions;

class RegexSubstitution
{
   static void Main( string[] args )
   {
      string testString1 = "This sentence ends in 5 stars *****";
      string testString2 = "1, 2, 3, 4, 5, 6, 7, 8";
      Regex testRegex1 = new Regex( @"\d" );
      string output = String.Empty;

      Console.WriteLine( "First test string: {0}", testString1 );

      // replace every '*' with a '^' and display the result
      testString1 = Regex.Replace( testString1, @"\*", "^" );
      Console.WriteLine( "^ substituted for *: {0}", testString1 );

      // replace the word "stars" with "carets" and display the result
      testString1 = Regex.Replace( testString1, "stars", "carets" );
      Console.WriteLine( "\"carets\" substituted for \"stars\": {0}",
         testString1 );

      // replace every word with "word" and display the result
      Console.WriteLine( "Every word replaced by \"word\": {0}",
         Regex.Replace( testString1, @"\w+", "word" ) );

      Console.WriteLine( "\nSecond test string: {0}", testString2 );

      // replace the first three digits with the word "digit"
      Console.WriteLine( "Replace first 3 digits by \"digit\": {0}",
         testRegex1.Replace( testString2, "digit", 3 ) );

      Console.Write( "String split at commas [" );

      // split the string into individual strings, each containing a digit
      string[] result = Regex.Split( testString2, @",\s" );

      // add each digit to the output string
      foreach( var resultString in result )
         output += "\"" + resultString + "\", ";

      // delete ", " at the end of output string
      Console.WriteLine( output.Substring( 0, output.Length - 2 ) + "]" );
   } // end Main
} // end class RegexSubstitution

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