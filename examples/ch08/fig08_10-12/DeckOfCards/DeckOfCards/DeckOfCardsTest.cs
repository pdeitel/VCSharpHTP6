// Fig. 8.12: DeckOfCardsTest.cs
// Card shuffling and dealing app.
using System;

class DeckOfCardsTest
{
   // execute app
   static void Main()
   {
      var myDeckOfCards = new DeckOfCards();
      myDeckOfCards.Shuffle(); // place Cards in random order

      // display all 52 Cards in the order in which they are dealt
      for (var i = 0; i < 52; ++i)
      {
         Console.Write($"{myDeckOfCards.DealCard(),-19}");

         if ((i + 1) % 4 == 0)
         {
            Console.WriteLine();
         }
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
