// Fig. 15.23: ComboBoxTestForm.cs
// Using ComboBox to select a shape to draw.
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ComboBoxTest
{
   // Form uses a ComboBox to select different shapes to draw
   public partial class ComboBoxTestForm : Form
   {
      // constructor
      public ComboBoxTestForm()
      {
         InitializeComponent();
      }

      // get index of selected shape, draw shape
      private void imageComboBox_SelectedIndexChanged(
         object sender, EventArgs e)
      {
         // create graphics object, Pen and SolidBrush
         using (Graphics myGraphics = base.CreateGraphics())

         // create Pen using color DarkRed
         using (Pen myPen = new Pen(Color.DarkRed))
         
         // create SolidBrush using color DarkRed
         using (SolidBrush mySolidBrush = new SolidBrush(Color.DarkRed))
         {
            // clear drawing area, setting it to color white
            myGraphics.Clear(Color.White);

            // find index, draw proper shape
            switch (imageComboBox.SelectedIndex)
            {
               case 0: // case Circle is selected
                  myGraphics.DrawEllipse(myPen, 50, 50, 150, 150);
                  break;
               case 1: // case Rectangle is selected
                  myGraphics.DrawRectangle(myPen, 50, 50, 150, 150);
                  break;
               case 2: // case Ellipse is selected
                  myGraphics.DrawEllipse(myPen, 50, 85, 150, 115);
                  break;
               case 3: // case Pie is selected
                  myGraphics.DrawPie(myPen, 50, 50, 150, 150, 0, 45);
                  break;
               case 4: // case Filled Circle is selected
                  myGraphics.FillEllipse(mySolidBrush, 50, 50, 150, 150);
                  break;
               case 5: // case Filled Rectangle is selected
                  myGraphics.FillRectangle(
                     mySolidBrush, 50, 50, 150, 150);
                  break;
               case 6: // case Filled Ellipse is selected
                  myGraphics.FillEllipse(mySolidBrush, 50, 85, 150, 115);
                  break;
               case 7: // case Filled Pie is selected
                  myGraphics.FillPie(
                     mySolidBrush, 50, 50, 150, 150, 0, 45);
                  break;
            }
         }
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
