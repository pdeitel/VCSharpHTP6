// Fig. 33.9: MainWindow.xaml.cs
// Applying transforms to a Polygon.
using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace DrawStars
{
   public partial class MainWindow : Window
   {
      // constructor
      public MainWindow()
      {
         InitializeComponent();

         Random random = new Random(); // get random values for colors

         // create 18 more stars
         for ( int count = 0; count < 18; ++count )
         {
            Polygon newStar = new Polygon(); // create a polygon object
            newStar.Points = star.Points; // copy the points collection

            byte[] colorValues = new byte[ 4 ]; // create a Byte array
            random.NextBytes( colorValues ); // create four random values
            newStar.Fill = new SolidColorBrush( Color.FromArgb(
               colorValues[ 0 ], colorValues[ 1 ], colorValues[ 2 ],
               colorValues[ 3 ] ) ); // creates a random color brush

            // apply a rotation to the shape
            RotateTransform rotate =
               new RotateTransform( count * 20, 150, 150 );
            newStar.RenderTransform = rotate;
            mainCanvas.Children.Add( newStar );
         } // end for
      } // end constructor
   } // end class MainWindow
} // end namespace DrawStars


/*************************************************************************
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
*************************************************************************/