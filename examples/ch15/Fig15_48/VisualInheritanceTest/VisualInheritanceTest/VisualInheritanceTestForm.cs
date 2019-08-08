// Fig. 15.48: VisualInheritanceTestForm.cs
// Derived Form using visual inheritance.
using System;
using System.Windows.Forms;

namespace VisualInheritanceTest
{
   // derived form using visual inheritance
   public partial class VisualInheritanceTestForm : 
      VisualInheritanceBase.VisualInheritanceBaseForm
   {
      // constructor
      public VisualInheritanceTestForm()
      {
         InitializeComponent();
      } 

      // display MessageBox when Button is clicked
      private void aboutButton_Click( object sender, EventArgs e )
      {
         MessageBox.Show(
            "This program was created by Deitel & Associates.",
            "About This Program", MessageBoxButtons.OK,
            MessageBoxIcon.Information );
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