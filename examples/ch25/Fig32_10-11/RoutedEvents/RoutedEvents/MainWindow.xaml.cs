// Fig. 32.11: MainWindow.xaml.cs
// Routed-events example (code-behind).
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace RoutedEvents
{
   public partial class MainWindow : Window
   {
      int bubblingEventStep = 1; // step counter for Bubbling
      int tunnelingEventStep = 1; // step counter for Tunneling
      string tunnelingLogText = string.Empty; // temporary Tunneling log

      public MainWindow()
      {
         InitializeComponent();
      } // end constructor

      // PreviewMouseUp is a tunneling event
      private void Tunneling( object sender, MouseButtonEventArgs e )
      {
         // append step number and sender
         tunnelingLogText = string.Format( "{0}({1}): {2}\n", 
            tunnelingLogText, tunnelingEventStep,
            ( ( Control ) sender ).Name );
         ++tunnelingEventStep; // increment counter

         // execution goes from parent to child, ending with the source
         if ( e.Source.Equals( sender ) )
         {
            tunnelingLogText = string.Format( 
               "This is a tunneling event:\n{0}", tunnelingLogText );
            logTextBox.Text = tunnelingLogText; // set LogTextBox text
            tunnelingLogText = string.Empty; // clear temporary log
            tunnelingEventStep = 1; // reset counter
         } // end if
      } // end method Tunneling

      // MouseUp is a bubbling event
      private void Bubbling( object sender, MouseButtonEventArgs e )
      {
         // execution goes from child to parent, starting at the source
         if ( e.Source.Equals( sender ) )
         {
            logTextBox.Clear(); // clear the logTextBox
            bubblingEventStep = 1; // reset counter
            logTextBox.Text = "This is a bubbling event:\n";
         } // end if

         // append step number and sender
         logTextBox.Text = string.Format( "{0}({1}): {2}\n",
            logTextBox.Text, bubblingEventStep, 
            ( ( Control ) sender ).Name );
         ++bubblingEventStep;
      } // end method Bubbling
   } // end class MainWindow
} // end namespace RoutedEvents


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