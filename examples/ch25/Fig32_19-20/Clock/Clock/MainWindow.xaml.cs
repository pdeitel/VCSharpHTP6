// Fig. 32.20: MainWindow.xaml.cs
// Creating a custom window and using a timer (code-behind).
using System;
using System.Windows;
using System.Windows.Input;

namespace Clock
{
   public partial class MainWindow : Window
   {
      // create a timer to control clock
      private System.Windows.Threading.DispatcherTimer timer = 
         new System.Windows.Threading.DispatcherTimer();
      
      // constructor
      public MainWindow()
      {
         InitializeComponent();

         timer.Interval = TimeSpan.FromSeconds( 1 ); // tick every second
         timer.IsEnabled = true; // enable timer

         timer.Tick += timer_Tick;
      } // end constructor

      // drag Window when the left mouse button is held down
      private void clockWindow_MouseLeftButtonDown( object sender, 
         MouseButtonEventArgs e )
      {
         this.DragMove(); // moves the window
      } // end method clockWindow_MouseLeftButtonDown

      // update the time when the timer ticks
      private void timer_Tick( object sender, EventArgs e )
      {
         DateTime currentTime = DateTime.Now; // get the current time

         // display the time as hh:mm:ss
         timeTextBox.Text = currentTime.ToLongTimeString();
      } // end method timer_Tick
   } // end class MainWindow
} // end namespace Clock

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