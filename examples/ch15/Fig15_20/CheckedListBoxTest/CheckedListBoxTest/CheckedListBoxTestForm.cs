// Fig. 15.20: CheckedListBoxTestForm.cs
// Using a CheckedListBox to add items to a display ListBox

using System.Windows.Forms;

namespace CheckedListBoxTest
{
   // Form uses a checked ListBox to add items to a display ListBox
   public partial class CheckedListBoxTestForm : Form
   {
      // constructor
      public CheckedListBoxTestForm()
      {
         InitializeComponent();
      }

      // item checked or unchecked
      // add or remove from display ListBox
      private void itemCheckedListBox_ItemCheck(
         object sender, ItemCheckEventArgs e)
      {
         // obtain reference of selected item
         string item = itemCheckedListBox.SelectedItem.ToString();

         // if item checked, add to ListBox
         // otherwise remove from ListBox
         if (e.NewValue == CheckState.Checked)
         {
            displayListBox.Items.Add(item);
         }
         else
         {
            displayListBox.Items.Remove(item);
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
