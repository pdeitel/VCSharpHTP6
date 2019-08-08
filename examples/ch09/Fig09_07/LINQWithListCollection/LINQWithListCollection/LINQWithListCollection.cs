// Fig. 9.7: LINQWithListCollection.cs
// LINQ to Objects using a List<string>.
using System;
using System.Linq;
using System.Collections.Generic;

class LINQWithListCollection
{
   static void Main()
   {
      // populate a List of strings 
      var items = new List<string>();
      items.Add("aQua"); // add "aQua" to the end of the List
      items.Add("RusT"); // add "RusT" to the end of the List
      items.Add("yElLow"); // add "yElLow" to the end of the List
      items.Add("rEd"); // add "rEd" to the end of the List

      // display initial List
      Console.Write("items contains:");
      foreach (var item in items)
      {
         Console.Write($" {item}");
      }

      Console.WriteLine(); // output end of line

      // convert to uppercase, select those starting with "R" and sort
      var startsWithR =
         from item in items
            let uppercaseString = item.ToUpper()
            where uppercaseString.StartsWith("R")
            orderby uppercaseString
            select uppercaseString;

      // display query results
      Console.Write("results of query startsWithR:");
      foreach (var item in startsWithR)
      {
         Console.Write($" {item}");
      }

      Console.WriteLine(); // output end of line

      items.Add("rUbY"); // add "rUbY" to the end of the List      
      items.Add("SaFfRon"); // add "SaFfRon" to the end of the List

      // display initial List
      Console.Write("items contains:");
      foreach (var item in items)
      {
         Console.Write($" {item}");
      }

      Console.WriteLine(); // output end of line

      // display updated query results
      Console.Write("results of query startsWithR:");
      foreach (var item in startsWithR)
      {
         Console.Write($" {item}");
      }

      Console.WriteLine(); // output end of line
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
