// Fig. 32.16: MainWindow.xaml.cs
// Color chooser app showing the use of styles (code-behind).
using System.Windows;
using System.Windows.Media;

namespace ColorChooser
{
   public partial class MainWindow : Window
   {
      public MainWindow()
      {
         InitializeComponent();
         alphaSlider.Value = 255; // override Value from style
      } // constructor

      // handles the ValueChanged event for the Sliders
      private void slider_ValueChanged( object sender, 
         RoutedPropertyChangedEventArgs< double > e )
      {
         // generates new color
         SolidColorBrush backgroundColor = new SolidColorBrush();
         backgroundColor.Color = Color.FromArgb( 
            ( byte ) alphaSlider.Value, ( byte ) redSlider.Value, 
            ( byte ) greenSlider.Value, ( byte ) blueSlider.Value );

         // set colorLabel's background to new color
         colorLabel.Background = backgroundColor;
      } // end method slider_ValueChanged
   } // end class MainWindow
} // end namespace ColorChooser

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
