// Fig. 6.2: ForCounter.cs
// Counter-controlled repetition with the for iteration statement.
using System;

class ForCounter
{
   static void Main()
   {
      // for statement header includes initialization,  
      // loop-continuation condition and increment
      for (int counter = 1; counter <= 10; ++counter)
      {
         Console.Write($"{counter}  ");
      }

      Console.WriteLine(); 
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
