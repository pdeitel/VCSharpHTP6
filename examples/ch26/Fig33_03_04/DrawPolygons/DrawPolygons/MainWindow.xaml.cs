// Fig. 33.4: MainWindow.xaml.cs
// Drawing Polylines and Polygons.
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace DrawPolygons
{
   public partial class MainWindow : Window
   {
      // stores the collection of points for the multi-sided shapes
      private PointCollection points = new PointCollection();

      // initialize the points of the shapes
      public MainWindow()
      {
         InitializeComponent();

         polyLine.Points = points; // assign Polyline points
         polygon.Points = points; // assign Polygon points
         filledPolygon.Points = points; // assign filled Polygon points
      } // end constructor

      // adds a new point when the user clicks on the canvas
      private void drawCanvas_MouseDown( object sender, 
         MouseButtonEventArgs e )
      {
         // add point to collection
         points.Add( e.GetPosition( drawCanvas ) );
      } // end method drawCanvas_MouseDown

      // when the clear Button is clicked
      private void clearButton_Click( object sender, RoutedEventArgs e )
      {
         points.Clear(); // clear the points from the collection
      } // end method clearButton_Click

      // when the user selects the Polyline
      private void lineRadio_Checked( object sender, RoutedEventArgs e )
      {
         // Polyline is visible, the other two are not
         polyLine.Visibility = Visibility.Visible;
         polygon.Visibility = Visibility.Collapsed;
         filledPolygon.Visibility = Visibility.Collapsed;
      } // end method lineRadio_Checked

      //  when the user selects the Polygon
      private void polygonRadio_Checked( object sender, 
         RoutedEventArgs e )
      {
         // Polygon is visible, the other two are not
         polyLine.Visibility = Visibility.Collapsed;
         polygon.Visibility = Visibility.Visible;
         filledPolygon.Visibility = Visibility.Collapsed;
      } // end method polygonRadio_Checked

      // when the user selects the filled Polygon
      private void filledPolygonRadio_Checked( object sender, 
         RoutedEventArgs e )
      {
         // filled Polygon is visible, the other two are not
         polyLine.Visibility = Visibility.Collapsed;
         polygon.Visibility = Visibility.Collapsed;
         filledPolygon.Visibility = Visibility.Visible;
      } // end method filledPolygonRadio_Checked
   } // end class MainWindow
} // end namespace DrawPolygons

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