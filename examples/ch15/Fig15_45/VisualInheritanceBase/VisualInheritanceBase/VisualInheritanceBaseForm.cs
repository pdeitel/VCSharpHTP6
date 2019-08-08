// Fig. 15.45: VisualInheritanceBaseForm.cs
// Base Form for use with visual inheritance.
using System;
using System.Windows.Forms;

namespace VisualInheritanceBase
{
   // base Form used to demonstrate visual inheritance
   public partial class VisualInheritanceBaseForm : Form
   {
      // constructor
      public VisualInheritanceBaseForm()
      {
         InitializeComponent();
      }

      // display MessageBox when Button is clicked
      private void learnMoreButton_Click(object sender, EventArgs e)
      {
         MessageBox.Show(
            "Bugs, Bugs, Bugs is a product of deitel.com",
            "Learn More", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
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
