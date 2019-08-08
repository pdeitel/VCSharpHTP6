// Fig. 8.10: Card.cs
// Card class represents a playing card.
class Card
{
   private string Face { get; } // Card’s face ("Ace", "Deuce", ...)
   private string Suit { get; } // Card’s suit ("Hearts", "Diamonds", ...)

   // two-parameter constructor initializes card's Face and Suit
   public Card(string face, string suit)
   {
      Face = face; // initialize face of card
      Suit = suit; // initialize suit of card
   }

   // return string representation of Card
   public override string ToString() => $"{Face} of {Suit}";
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
