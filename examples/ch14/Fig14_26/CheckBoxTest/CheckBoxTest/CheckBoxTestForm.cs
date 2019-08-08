// Fig. 14.26: CheckBoxTestForm.cs
// Using CheckBoxes to toggle italic and bold styles.
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CheckBoxTest
{
   // Form contains CheckBoxes to allow the user to modify sample text
   public partial class CheckBoxTestForm : Form
   {
      // default constructor
      public CheckBoxTestForm()
      {
         InitializeComponent();
      }

      // toggle the font style between bold and        
      // not bold based on the  current setting        
      private void boldCheckBox_CheckedChanged(object sender, EventArgs e)
      {
         outputLabel.Font = new Font(outputLabel.Font,
            outputLabel.Font.Style ^ FontStyle.Bold);
      }

      // toggle the font style between italic and       
      // not italic based on the current setting        
      private void italicCheckBox_CheckedChanged(
         object sender, EventArgs e)
      {
         outputLabel.Font = new Font(outputLabel.Font,
            outputLabel.Font.Style ^ FontStyle.Italic);
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