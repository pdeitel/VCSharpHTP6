// Fig. 6.19: LogicalOperators.cs
// Logical operators.
using System;

class LogicalOperators
{
   static void Main()
   {
      // create truth table for && (conditional AND) operator
      Console.WriteLine("Conditional AND (&&)");
      Console.WriteLine($"false && false: {false && false}");
      Console.WriteLine($"false && true: {false && true}");
      Console.WriteLine($"true && false: {true && false}");
      Console.WriteLine($"true && true: {true && true}\n");

      // create truth table for || (conditional OR) operator
      Console.WriteLine("Conditional OR (||)");
      Console.WriteLine($"false || false: {false || false}");
      Console.WriteLine($"false || true: {false || true}");
      Console.WriteLine($"true || false: {true || false}");
      Console.WriteLine($"true || true: {true || true}\n");

      // create truth table for & (boolean logical AND) operator
      Console.WriteLine("Boolean logical AND (&)");
      Console.WriteLine($"false & false: {false & false}");
      Console.WriteLine($"false & true: {false & true}");
      Console.WriteLine($"true & false: {true & false}");
      Console.WriteLine($"true & true: {true & true}\n");

      // create truth table for | (boolean logical inclusive OR) operator
      Console.WriteLine("Boolean logical inclusive OR (|)");
      Console.WriteLine($"false | false: {false | false}");
      Console.WriteLine($"false | true: {false | true}");
      Console.WriteLine($"true | false: {true | false}");
      Console.WriteLine($"true | true: {true | true}\n");

      // create truth table for ^ (boolean logical exclusive OR) operator
      Console.WriteLine("Boolean logical exclusive OR (^)");
      Console.WriteLine($"false ^ false: {false ^ false}");
      Console.WriteLine($"false ^ true: {false ^ true}");
      Console.WriteLine($"true ^ false: {true ^ false}");
      Console.WriteLine($"true ^ true: {true ^ true}\n");

      // create truth table for ! (logical negation) operator
      Console.WriteLine("Logical negation (!)");
      Console.WriteLine($"!false: {!false}");
      Console.WriteLine($"!true: {!true}");
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
