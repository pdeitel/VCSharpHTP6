// Fig. 15.50: ClockUserControl.cs
// User-defined control with a timer and a Label.
using System;
using System.Windows.Forms;

namespace ClockExample
{
   // UserControl that displays the time on a Label
   public partial class ClockUserControl : UserControl
   {
      // constructor
      public ClockUserControl()
      {
         InitializeComponent();
      } // end constructor

      // update Label at every tick
      private void clockTimer_Tick( object sender, EventArgs e )
      {
         // get current time (Now), convert to string
         displayLabel.Text = DateTime.Now.ToLongTimeString();
      } // end method clockTimer_Tick
   } // end class ClockUserControl
} // end namespace ClockExample

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