// Fig. 8.11: DeckOfCards.cs
// DeckOfCards class represents a deck of playing cards.
using System;

class DeckOfCards
{
   // create one Random object to share among DeckOfCards objects
   private static Random randomNumbers = new Random();

   private const int NumberOfCards = 52; // number of cards in a deck
   private Card[] deck = new Card[NumberOfCards]; 
   private int currentCard = 0; // index of next Card to be dealt (0-51)

   // constructor fills deck of Cards
   public DeckOfCards()
   {
      string[] faces = {"Ace", "Deuce", "Three", "Four", "Five", "Six",
         "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King"};
      string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };

      // populate deck with Card objects                         
      for (var count = 0; count < deck.Length; ++count)
      {
         deck[count] = new Card(faces[count % 13], suits[count / 13]);
      }
   }

   // shuffle deck of Cards with one-pass algorithm
   public void Shuffle()
   {
      // after shuffling, dealing should start at deck[0] again
      currentCard = 0; // reinitialize currentCard

      // for each Card, pick another random Card and swap them
      for (var first = 0; first < deck.Length; ++first)
      {
         // select a random number between 0 and 51 
         var second = randomNumbers.Next(NumberOfCards);

         // swap current Card with randomly selected Card
         Card temp = deck[first];
         deck[first] = deck[second];
         deck[second] = temp;
      }
   }

   // deal one Card
   public Card DealCard()
   {
      // determine whether Cards remain to be dealt
      if (currentCard < deck.Length)
      {
         return deck[currentCard++]; // return current Card in array
      }
      else
      {
         return null; // indicate that all Cards were dealt
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
