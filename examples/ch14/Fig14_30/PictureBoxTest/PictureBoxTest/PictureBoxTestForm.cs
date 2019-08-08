// Fig. 14.30: PictureBoxTestForm.cs
// Using a PictureBox to display images.
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PictureBoxTest
{
   // Form to display different images when Button is clicked
   public partial class PictureBoxTestForm : Form
   {
      private int ImageNumber { get; set; } = -1; // image to display

      // default constructor
      public PictureBoxTestForm()
      {
         InitializeComponent();
      }

      // change image whenever Next Button is clicked
      private void nextButton_Click(object sender, EventArgs e)
      {
         ImageNumber = (ImageNumber + 1) % 3; // cycles from 0 to 2

         // retrieve image from resources and load into PictureBox
         imagePictureBox.Image =
            (Image)(Properties.Resources.ResourceManager.GetObject(    
            $"image{ImageNumber}"));
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
