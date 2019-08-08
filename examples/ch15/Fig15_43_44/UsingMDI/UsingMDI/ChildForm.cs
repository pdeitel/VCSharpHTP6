// Fig. 15.44: ChildForm.cs
// Child window of MDI parent.

using System.Drawing;
using System.Windows.Forms;

namespace UsingMDI
{
   public partial class ChildForm : Form
   {
      public ChildForm(string title, string resourceName)
      {
         // Required for Windows Form Designer support
         InitializeComponent();

         Text = title; // set title text

         // set image to display in PictureBox
         displayPictureBox.Image =
            (Image)(Properties.Resources.ResourceManager.GetObject(
               resourceName));
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
