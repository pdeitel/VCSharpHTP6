// Fig. 14.36: InterestCalculatorForm.cs
// Demonstrating the NumericUpDown control.
using System;
using System.Windows.Forms;

namespace NumericUpDownTest
{
   public partial class InterestCalculatorForm : Form
   {
      // default constructor
      public InterestCalculatorForm()
      {
         InitializeComponent();
      }

      private void calculateButton_Click(object sender, EventArgs e)
      {
         // retrieve user input
         decimal principal = decimal.Parse(principalTextBox.Text);
         double rate = double.Parse(interestTextBox.Text);
         int year = (int) yearUpDown.Value;

         // set output header
         string output = "Year\tAmount on Deposit\r\n";

         // calculate amount after each year and append to output
         for (int yearCounter = 1; yearCounter <= year; ++yearCounter)
         {
            decimal amount = principal *
              ((decimal)Math.Pow((1 + rate / 100), yearCounter));
            output += $"{yearCounter}\t{amount:C}\r\n";
         }

         displayTextBox.Text = output; // display result
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
