// Fig. 19.15: StackCompositionLibrary.cs  
// StackComposition class encapsulates functionality of class List.
using LinkedListLibrary;

namespace StackCompositionLibrary
{
   // class StackComposition encapsulates List's capabilities
   public class StackComposition
   {
      private List stack;

      // construct empty stack
      public StackComposition()
      {
         stack = new List("stack");
      }

      // add object to stack
      public void Push(object dataValue)
      {
         stack.InsertAtFront(dataValue);
      }

      // remove object from stack
      public object Pop()
      {
         return stack.RemoveFromFront();
      }

      // determine whether stack is empty
      public bool IsEmpty()
      {
         return stack.IsEmpty();
      }

      // output stack contents
      public void Display()
      {
         stack.Display();
      }
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
