// Fig. 15.11: DateTimePickerForm.cs
// Using a DateTimePicker to select a drop-off time.
using System;
using System.Windows.Forms;

namespace DateTimePickerTest
{
   // Form lets user select a drop-off date using a DateTimePicker
   // and displays an estimated delivery date
   public partial class DateTimePickerForm : Form
   {
      // constructor
      public DateTimePickerForm()
      {
         InitializeComponent();
      }

      private void dropOffDateTimePicker_ValueChanged(
         object sender, EventArgs e)
      {
         DateTime dropOffDate = dropOffDateTimePicker.Value;

         // add extra time when items are dropped off Sunday
         if (dropOffDate.DayOfWeek == DayOfWeek.Friday ||
            dropOffDate.DayOfWeek == DayOfWeek.Saturday ||
            dropOffDate.DayOfWeek == DayOfWeek.Sunday)
         {
            //estimate three days for delivery
            outputLabel.Text = dropOffDate.AddDays(3).ToLongDateString();
         }
         else
         {
            // otherwise estimate only two days for delivery
            outputLabel.Text = dropOffDate.AddDays(2).ToLongDateString();
         }
      }

      private void DateTimePickerForm_Load(object sender, EventArgs e)
      {
         // user cannot select days before today
         dropOffDateTimePicker.MinDate = DateTime.Today;

         // user can only select days up to one year in the future
         dropOffDateTimePicker.MaxDate = DateTime.Today.AddYears(1);
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

