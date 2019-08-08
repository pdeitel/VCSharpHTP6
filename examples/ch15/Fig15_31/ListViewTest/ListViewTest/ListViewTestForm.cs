// Fig. 15.31: ListViewTestForm.cs
// Displaying directories and their contents in a ListView.
using System;
using System.Windows.Forms;
using System.IO;

namespace ListViewTest
{
   // Form contains a ListView which displays
   // folders and files in a directory
   public partial class ListViewTestForm : Form
   {
      // store current directory
      string currentDirectory = Directory.GetCurrentDirectory();

      // constructor
      public ListViewTestForm()
      {
         InitializeComponent();
      }

      // browse directory user clicked or go up one level
      private void browserListView_Click(object sender, EventArgs e)
      {
         // ensure an item is selected
         if (browserListView.SelectedItems.Count != 0)
         {
            // if first item selected, go up one level
            if (browserListView.Items[0].Selected)
            {
               // create DirectoryInfo object for directory
               DirectoryInfo directoryObject =
                  new DirectoryInfo(currentDirectory);

               // if directory has parent, load it
               if (directoryObject.Parent != null)
               {
                  LoadFilesInDirectory(directoryObject.Parent.FullName);
               }
            }

            // selected directory or file
            else
            {
               // directory or file chosen
               string chosen = browserListView.SelectedItems[0].Text;

               // if item selected is directory, load selected directory
               if (Directory.Exists(
                  Path.Combine(currentDirectory, chosen)))
               {
                  LoadFilesInDirectory(
                     Path.Combine(currentDirectory, chosen));
               }
            }

            // update displayLabel
            displayLabel.Text = currentDirectory;
         }
      }

      // display files/subdirectories of current directory
      public void LoadFilesInDirectory(string currentDirectoryValue)
      {
         // load directory information and display
         try
         {
            // clear ListView and set first item
            browserListView.Items.Clear();
            browserListView.Items.Add("Go Up One Level");

            // update current directory
            currentDirectory = currentDirectoryValue;
            DirectoryInfo newCurrentDirectory =
               new DirectoryInfo(currentDirectory);

            // put files and directories into arrays
            DirectoryInfo[] directoryArray =
               newCurrentDirectory.GetDirectories();
            FileInfo[] fileArray = newCurrentDirectory.GetFiles();

            // add directory names to ListView
            foreach (DirectoryInfo dir in directoryArray)
            {
               // add directory to ListView
               ListViewItem newDirectoryItem =
                  browserListView.Items.Add(dir.Name);

               newDirectoryItem.ImageIndex = 0;  // set directory image
            }

            // add file names to ListView
            foreach (FileInfo file in fileArray)
            {
               // add file to ListView
               ListViewItem newFileItem =
                  browserListView.Items.Add(file.Name);

               newFileItem.ImageIndex = 1;  // set file image
            }
         }

         // access denied
         catch (UnauthorizedAccessException)
         {
            MessageBox.Show("Warning: Some files may not be " +
               "visible due to permission settings",
               "Attention", 0, MessageBoxIcon.Warning);
         }
      }

      // handle load event when Form displayed for first time
      private void ListViewTestForm_Load(object sender, EventArgs e)
      {
         // add icon images to ImageList
         fileFolderImageList.Images.Add(Properties.Resources.folder);
         fileFolderImageList.Images.Add(Properties.Resources.file);

         // load current directory into browserListView
         LoadFilesInDirectory(currentDirectory);
         displayLabel.Text = currentDirectory;
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
