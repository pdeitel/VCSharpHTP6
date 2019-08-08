// Fig. 17.13: FileTestForm.cs
// Using classes File and Directory.
using System;
using System.Windows.Forms;
using System.IO;

namespace FileTest
{
   // displays contents of files and directories
   public partial class FileTestForm : Form
   {
      // parameterless constructor
      public FileTestForm()
      {
         InitializeComponent();
      }

      // invoked when user presses key
      private void inputTextBox_KeyDown(object sender, KeyEventArgs e)
      {
         // determine whether user pressed Enter key
         if (e.KeyCode == Keys.Enter)
         {
            // get user-specified file or directory
            string fileName = inputTextBox.Text;

            // determine whether fileName is a file
            if (File.Exists(fileName))
            {
               // get file's creation date, modification date, etc.
               GetInformation(fileName);

               // display file contents through StreamReader
               try
               {
                  // obtain reader and file contents
                  using (var stream = new StreamReader(fileName))
                  {
                     outputTextBox.AppendText(stream.ReadToEnd());
                  }
               }
               catch (IOException)
               {
                  MessageBox.Show("Error reading from file",
                     "File Error", MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
               }
            }
            // determine whether fileName is a directory
            else if (Directory.Exists(fileName))
            {
               // get directory's creation date, 
               // modification date, etc.
               GetInformation(fileName);

               // obtain directory list of specified directory
               string[] directoryList =
                  Directory.GetDirectories(fileName);

               outputTextBox.AppendText("Directory contents:\n");

               // output directoryList contents
               foreach (var directory in directoryList)
               {
                  outputTextBox.AppendText($"{directory}\n");
               }
            }
            else
            {
               // notify user that neither file nor directory exists
               MessageBox.Show(
                  $"{inputTextBox.Text} does not exist", "File Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }
      }

      // get information on file or directory,
      // and output it to outputTextBox
      private void GetInformation(string fileName)
      {
         outputTextBox.Clear();

         // output that file or directory exists
         outputTextBox.AppendText($"{fileName} exists" +
            Environment.NewLine);

         // output when file or directory was created
         outputTextBox.AppendText(
            $"Created: {File.GetCreationTime(fileName)}" +
            Environment.NewLine);

         // output when file or directory was last modified
         outputTextBox.AppendText(
            $"Last modified: {File.GetLastWriteTime(fileName)}" +
            Environment.NewLine);

         // output when file or directory was last accessed
         outputTextBox.AppendText(
            $"Last accessed: {File.GetLastAccessTime(fileName)}" +
            Environment.NewLine);
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
