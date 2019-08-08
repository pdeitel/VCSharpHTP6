// Book.cs
// Class representing a book.
namespace BookViewer
{
   public class Book
   {
      // book title
      public string Title { get; set; }

      // book ISBN number
      public string ISBN { get; set; }

      // source of book cover's thumbnail image
      public string ThumbImage { get; set; }

      // source of book cover's fullsize image
      public string LargeImage { get; set; }
      
      public Book( string title, string isbn, string thumb, string large )
      {
         // set properties
         Title = title;
         ISBN = isbn;
         ThumbImage = thumb;
         LargeImage = large;
      } // end constructor
   } // end class Book
} // end namespace BookViewer

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
 **************************************************************************/
