// Fig. 14.24: GroupBoxPanelExampleForm.cs
// Using GroupBoxes and Panels to arrange Buttons.
using System;
using System.Windows.Forms;

namespace GroupBoxPanelExample
{
   // Form that displays a GroupBox and a Panel
   public partial class GroupBoxPanelExampleForm : Form
   {
      // default constructor
      public GroupBoxPanelExampleForm()
      {
         InitializeComponent();
      }

      // event handler for Hi Button
      private void hiButton_Click(object sender, EventArgs e)
      {
         messageLabel.Text = "Hi pressed"; // change text in Label
      }

      // event handler for Bye Button
      private void byeButton_Click(object sender, EventArgs e)
      {
         messageLabel.Text = "Bye pressed"; // change text in Label
      }

      // event handler for Far Left Button
      private void leftButton_Click(object sender, EventArgs e)
      {
         messageLabel.Text = "Far Left pressed"; // change text in Label
      }

      // event handler for Far Right Button
      private void rightButton_Click(object sender, EventArgs e)
      {
         messageLabel.Text = "Far Right pressed"; // change text in Label
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
