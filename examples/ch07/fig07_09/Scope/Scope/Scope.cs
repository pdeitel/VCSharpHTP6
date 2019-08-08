// Fig. 7.9: Scope.cs
// Scope class demonstrates static and local variable scopes.
using System;

class Scope
{
   // static variable that’s accessible to all methods of this class
   private static int x = 1;

   // Main creates and initializes local variable x 
   // and calls methods UseLocalVariable and UseStaticVariable
   static void Main()
   {
      int x = 5; // method's local variable x hides static variable x

      Console.WriteLine($"local x in method Main is {x}");

      // UseLocalVariable has its own local x
      UseLocalVariable();

      // UseStaticVariable uses class Scope's static variable x
      UseStaticVariable();

      // UseLocalVariable reinitializes its own local x
      UseLocalVariable();

      // class Scope's static variable x retains its value
      UseStaticVariable();

      Console.WriteLine($"\nlocal x in method Main is {x}");
   }

   // create and initialize local variable x during each call
   static void UseLocalVariable()
   {
      int x = 25; // initialized each time UseLocalVariable is called

      Console.WriteLine(
         $"\nlocal x on entering method UseLocalVariable is {x}");
      ++x; // modifies this method's local variable x
      Console.WriteLine(
         $"local x before exiting method UseLocalVariable is {x}");
   }

   // modify class Scope's static variable x during each call
   static void UseStaticVariable()
   {
      Console.WriteLine("\nstatic variable x on entering method " +
         $"UseStaticVariable is {x}");
      x *= 10; // modifies class Scope's static variable x
      Console.WriteLine("static variable x before exiting " +
         $"method UseStaticVariable is {x}");
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
