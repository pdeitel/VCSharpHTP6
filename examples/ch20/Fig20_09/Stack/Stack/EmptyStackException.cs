// Fig. 20.7: EmptyStackException.cs
// EmptyStackException indicates a stack is empty.
using System;

public class EmptyStackException : Exception
{
   // parameterless constructor
   public EmptyStackException() : base("Stack is empty")
   {
      // empty constructor
   }

   // one-parameter constructor
   public EmptyStackException(string exception) : base(exception)
   {
      // empty constructor
   }

   // two-parameter constructor
   public EmptyStackException(string exception, Exception inner)
      : base(exception, inner)
   {
      // empty constructor
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
