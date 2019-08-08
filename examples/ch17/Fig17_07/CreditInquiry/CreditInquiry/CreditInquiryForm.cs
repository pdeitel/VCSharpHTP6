// Fig. 17.7: CreditInquiryForm.cs
// Read a file sequentially and display contents based on
// account type specified by user (credit, debit or zero balances).
using System;
using System.Windows.Forms;
using System.IO;
using BankLibrary;

namespace CreditInquiry
{
   public partial class CreditInquiryForm : Form
   {
      private FileStream input; // maintains the connection to the file
      private StreamReader fileReader; // reads data from text file    

      // parameterless constructor
      public CreditInquiryForm()
      {
         InitializeComponent();
      }

      // invoked when user clicks Open File button
      private void openButton_Click(object sender, EventArgs e)
      {
         // create dialog box enabling user to open file         
         DialogResult result;
         string fileName;

         using (OpenFileDialog fileChooser = new OpenFileDialog())
         {
            result = fileChooser.ShowDialog();
            fileName = fileChooser.FileName;
         }

         // exit event handler if user clicked Cancel
         if (result == DialogResult.OK)
         {
            // show error if user specified invalid file
            if (string.IsNullOrEmpty(fileName))
            {
               MessageBox.Show("Invalid File Name", "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               // create FileStream to obtain read access to file
               input = new FileStream(fileName,
                  FileMode.Open, FileAccess.Read);

               // set file from where data is read
               fileReader = new StreamReader(input);

               // enable all GUI buttons, except for Open File button
               openButton.Enabled = false;
               creditButton.Enabled = true;
               debitButton.Enabled = true;
               zeroButton.Enabled = true;
            }
         }
      }

      // invoked when user clicks credit balances,
      // debit balances or zero balances button
      private void getBalances_Click(object sender, System.EventArgs e)
      {
         // convert sender explicitly to object of type button
         Button senderButton = (Button)sender;

         // get text from clicked Button, which stores account type
         string accountType = senderButton.Text;

         // read and display file information
         try
         {
            // go back to the beginning of the file
            input.Seek(0, SeekOrigin.Begin);

            displayTextBox.Text =
               $"Accounts with {accountType}{Environment.NewLine}";

            // traverse file until end of file
            while (true)
            {
               // get next Record available in file
               string inputRecord = fileReader.ReadLine();

               // when at the end of file, exit method
               if (inputRecord == null)
               {
                  return;
               }

               // parse input
               string[] inputFields = inputRecord.Split(',');

               // create Record from input
               var record =
                  new Record(int.Parse(inputFields[0]), inputFields[1],
                     inputFields[2], decimal.Parse(inputFields[3]));

               // determine whether to display balance
               if (ShouldDisplay(record.Balance, accountType))
               {
                  // display record
                  displayTextBox.AppendText($"{record.Account}\t" +
                     $"{record.FirstName}\t{record.LastName}\t" +
                     $"{record.Balance:C}{Environment.NewLine}");
               }
            }
         }
         catch (IOException)
         {
            MessageBox.Show("Cannot Read File", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }

      // determine whether to display given record
      private bool ShouldDisplay(decimal balance, string accountType)
      {
         if (balance > 0M && accountType == "Credit Balances")
         {
            return true; // should display credit balances
         }
         else if (balance < 0M && accountType == "Debit Balances")
         {
            return true; // should display debit balances
         }
         else if (balance == 0 && accountType == "Zero Balances")
         {
            return true; // should display zero balances
         }

         return false;
      }

      // invoked when user clicks Done button
      private void doneButton_Click(object sender, EventArgs e)
      {
         // close file and StreamReader
         try
         {
            fileReader?.Close(); // close StreamReader and underlying file
         }
         catch (IOException)
         {
            // notify user of error closing file
            MessageBox.Show("Cannot close file", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
         }

         Application.Exit();
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
