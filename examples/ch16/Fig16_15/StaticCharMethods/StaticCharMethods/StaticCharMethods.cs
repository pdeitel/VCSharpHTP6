// Fig. 16.15: StaticCharMethods.cs
// Demonstrates static character-testing and case-conversion methods 
// from Char struct
using System;

class StaticCharMethods
{
   static void Main(string[] args)
   {
      Console.Write("Enter a character: ");
      var character = char.Parse(Console.ReadLine());

      Console.WriteLine($"is digit: {char.IsDigit(character)}");
      Console.WriteLine($"is letter: {char.IsLetter(character)}");
      Console.WriteLine(
         $"is letter or digit: {char.IsLetterOrDigit(character)}");
      Console.WriteLine($"is lower case: {char.IsLower(character)}");
      Console.WriteLine($"is upper case: {char.IsUpper(character)}");
      Console.WriteLine($"to upper case: {char.ToUpper(character)}");
      Console.WriteLine($"to lower case: {char.ToLower(character)}");
      Console.WriteLine(
         $"is punctuation: {char.IsPunctuation(character)}");
      Console.WriteLine($"is symbol: {char.IsSymbol(character)}");
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
