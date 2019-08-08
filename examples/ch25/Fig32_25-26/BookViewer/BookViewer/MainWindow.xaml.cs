// Fig. 32.26: MainWindow.xaml.cs
// Using data binding (code-behind).
using System.Collections.Generic;
using System.Windows;

namespace BookViewer
{
   public partial class MainWindow : Window
   {
      private List< Book > books = new List< Book >();

      public MainWindow()
      {
         InitializeComponent();

         // add Book objects to the List
         books.Add( new Book( "C How to Program", "013299044X",
            "images/small/chtp.jpg", "images/large/chtp.jpg" ) );
         books.Add( new Book( "C++ How to Program", "0133378713",
            "images/small/cpphtp.jpg", "images/large/cpphtp.jpg" ) );
         books.Add( new Book(
            "Internet and World Wide Web How to Program", "0132151006", 
            "images/small/iw3htp.jpg", "images/large/iw3htp.jpg" ) );
         books.Add( new Book( "Java How to Program", "0132940949",
            "images/small/jhtp.jpg", "images/large/jhtp.jpg" ) );
         books.Add( new Book( "Visual Basic How to Program", "0133406954",
            "images/small/vbhtp.jpg", "images/large/vbhtp.jpg" ) );
         books.Add( new Book( "Visual C# How to Program", "0133379337",
            "images/small/vcshtp.jpg", "images/large/vcshtp.jpg" ) );

         booksListView.ItemsSource = books; // bind data to the list
      } // end constructor
   } // end class MainWindow
} // end namespace BookViewer

/**************************************************************************
 * (C) Copyright 1992-2014 by Deitel & Associates, Inc. and               *
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