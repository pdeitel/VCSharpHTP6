// Fig. 23.2: SynchronousTestForm.cs
// Fibonacci calculations performed sequentially
using System;
using System.Windows.Forms;

namespace FibonacciSynchronous
{
   public partial class SynchronousTestForm : Form
   {
      public SynchronousTestForm()
      {
         InitializeComponent();
      }

      // start sequential calls to Fibonacci
      private void startButton_Click(object sender, EventArgs e)
      {
         // calculate Fibonacci (46)
         outputTextBox.Text = "Calculating Fibonacci(46)\r\n";
         outputTextBox.Refresh(); // force outputTextBox to repaint
         DateTime startTime1 = DateTime.Now; // time before calculation
         long result1 = Fibonacci(46); // synchronous call
         DateTime endTime1 = DateTime.Now; // time after calculation

         // display results for Fibonacci(46) 
         outputTextBox.AppendText($"Fibonacci(46) = {result1}\r\n");
         double minutes = (endTime1 - startTime1).TotalMinutes;
         outputTextBox.AppendText(
            $"Calculation time = {minutes:F6} minutes\r\n\r\n");

         // calculate Fibonacci (45)
         outputTextBox.AppendText("Calculating Fibonacci(45)\r\n");
         outputTextBox.Refresh(); // force outputTextBox to repaint
         DateTime startTime2 = DateTime.Now;
         long result2 = Fibonacci(45); // synchronous call
         DateTime endTime2 = DateTime.Now;

         // display results for Fibonacci(45) 
         outputTextBox.AppendText($"Fibonacci(45) = {result2}\r\n");
         minutes = (endTime2 - startTime2).TotalMinutes;
         outputTextBox.AppendText(
            $"Calculation time = {minutes:F6} minutes\r\n\r\n");

         // show total calculation time
         double totalMinutes = (endTime2 - startTime1).TotalMinutes;
         outputTextBox.AppendText(
            $"Total calculation time = {totalMinutes:F6} minutes\r\n");
      }

      // Recursively calculates Fibonacci numbers
      public long Fibonacci(long n)
      {
         if (n == 0 || n == 1)
         {
            return n;
         }
         else
         {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
         }
      }
   }
}


/*************************************************************************
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
