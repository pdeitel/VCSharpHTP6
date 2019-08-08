// Fig. 23.6: FindPrimes.cs
// Displaying an asynchronous task's progress and intermediate results
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindPrimes
{
   public partial class FindPrimesForm : Form
   {
      // used to enable cancelation of the async task
      private bool Canceled { get; set; } = false;
      private bool[] primes; // array used to determine primes

      public FindPrimesForm()
      {
         InitializeComponent();
         progressBar.Minimum = 2; // 2 is the smallest prime number
         percentageLabel.Text = $"{0:P0}"; // display 0 %
      }

      // handles getPrimesButton's click event
      private async void getPrimesButton_Click(object sender, EventArgs e)
      {
         // get user input
         var maximum = int.Parse(maxValueTextBox.Text);

         // create array for determining primes
         primes = Enumerable.Repeat(true, maximum).ToArray();

         // reset Canceled and GUI
         Canceled = false;
         getPrimesButton.Enabled = false; // disable getPrimesButton
         cancelButton.Enabled = true; // enable cancelButton
         primesTextBox.Text = string.Empty; // clear primesTextBox
         statusLabel.Text = string.Empty; // clear statusLabel
         percentageLabel.Text = $"{0:P0}"; // display 0 %
         progressBar.Value = progressBar.Minimum; // reset progressBar min
         progressBar.Maximum = maximum; // set progressBar max

         // show primes up to maximum
         int count = await FindPrimes(maximum);
         statusLabel.Text = $"Found {count} prime(s)";
      }

      // displays prime numbers in primesTextBox
      private async Task<int> FindPrimes(int maximum)
      {
         var primeCount = 0;

         // find primes less than maximum
         for (var i = 2; i < maximum && !Canceled; ++i)
         {
            // if i is prime, display it
            if (await Task.Run(() => IsPrime(i)))
            {
               ++primeCount; // increment number of primes found
               primesTextBox.AppendText($"{i}{Environment.NewLine}");
            }

            var percentage = (double)progressBar.Value /
               (progressBar.Maximum - progressBar.Minimum + 1);
            percentageLabel.Text = $"{percentage:P0}";
            progressBar.Value = i + 1; // update progress
         }

         // display message if operation was canceled
         if (Canceled)
         {
            primesTextBox.AppendText($"Canceled{Environment.NewLine}");
         }

         getPrimesButton.Enabled = true; // enable getPrimesButton
         cancelButton.Enabled = false; // disable cancelButton
         return primeCount;
      }

      // check whether value is a prime number 
      // and mark all multiples as not prime
      public bool IsPrime(int value)
      {
         // if value is prime, mark all of multiples
         // as not prime and return true
         if (primes[value])
         {
            // mark all multiples of value as not prime
            for (var i = value + value; i < primes.Length; i += value)
            {
               primes[i] = false; // i is not prime
            }

            return true;
         }
         else
         {
            return false;
         }
      }

      // if user clicks Cancel Button, stop displaying primes
      private void cancelButton_Click(object sender, EventArgs e)
      {
         Canceled = true;
         getPrimesButton.Enabled = true; // enable getPrimesButton
         cancelButton.Enabled = false; // disable cancelButton
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
 **************************************************************************/
