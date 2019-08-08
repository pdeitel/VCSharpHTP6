// Fig. 33.13: MainWindow.xaml.cs
// TV GUI showing the versatility of WPF customization (code-behind).
using System.Windows;

namespace TV
{
   public partial class MainWindow : Window
   {
      // constructor
      public MainWindow()
      {
         InitializeComponent();
      } // end constructor

      // turns "on" the TV
      private void powerCheckBox_Checked( object sender, 
         RoutedEventArgs e )
      {
         // render the reflection visible
         reflectionRectangle.Visibility = Visibility.Visible;

         // enable play, pause, and stop buttons
         playRadioButton.IsEnabled = true;
         pauseRadioButton.IsEnabled = true;
         stopRadioButton.IsEnabled = true;
      } // end method powerCheckBox_Checked

      // turns "off" the TV
      private void powerCheckBox_Unchecked( object sender, 
         RoutedEventArgs e )
      {
         // shut down the screen
         videoMediaElement.Close();         

         // hide the reflection
         reflectionRectangle.Visibility = Visibility.Hidden;

         // disable the play, pause, and stop buttons
         playRadioButton.IsChecked = false;
         pauseRadioButton.IsChecked = false;
         stopRadioButton.IsChecked = false;
         playRadioButton.IsEnabled = false;
         pauseRadioButton.IsEnabled = false;
         stopRadioButton.IsEnabled = false;
      } // end method powerCheckBox_Unchecked

      // plays the video
      private void playRadioButton_Checked( object sender, 
         RoutedEventArgs e )
      {
         videoMediaElement.Play();
      } // end method playRadioButton_Checked

      // pauses the video
      private void pauseRadioButton_Checked( object sender, 
         RoutedEventArgs e )
      {
         videoMediaElement.Pause();
      } // end method pauseRadioButton_Checked

      // stops the video
      private void stopRadioButton_Checked( object sender, 
         RoutedEventArgs e )
      {
         videoMediaElement.Stop();
      } // end method stopRadioButton_Checked
   } // end class MainWindow
} // end namespace TV

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