// Fig. 15.28: TreeViewDirectoryStructureForm.cs
// Using TreeView to display directory structure.
using System;
using System.Windows.Forms;
using System.IO;

namespace TreeViewDirectoryStructure
{
   // Form uses TreeView to display directory structure
   public partial class TreeViewDirectoryStructureForm : Form
   {
      string substringDirectory; // store last part of full path name

      // constructor
      public TreeViewDirectoryStructureForm()
      {
         InitializeComponent();
      }

      // populate current node with subdirectories
      public void PopulateTreeView(
          string directoryValue, TreeNode parentNode)
      {
         // array stores all subdirectories in the directory
         string[] directoryArray =
            Directory.GetDirectories(directoryValue);

         // populate current node with subdirectories
         try
         {
            // check to see if any subdirectories are present
            if (directoryArray.Length != 0)
            {
               // for every subdirectory, create new TreeNode,
               // add as a child of current node and recursively
               // populate child nodes with subdirectories
               foreach (string directory in directoryArray)
               {
                  // obtain last part of path name from the full path
                  // name by calling the GetFileNameWithoutExtension
                  // method of class Path
                  substringDirectory =
                     Path.GetFileNameWithoutExtension(directory);

                  // create TreeNode for current directory
                  TreeNode myNode = new TreeNode(substringDirectory);

                  // add current directory node to parent node
                  parentNode.Nodes.Add(myNode);

                  // recursively populate every subdirectory
                  PopulateTreeView(directory, myNode);
               }
            }
         }
         catch (UnauthorizedAccessException)
         {
            parentNode.Nodes.Add("Access denied");
         }
      }

      // handles enterButton click event
      private void enterButton_Click(object sender, EventArgs e)
      {
         // clear all nodes
         directoryTreeView.Nodes.Clear();

         // check if the directory entered by user exists
         // if it does, then fill in the TreeView,
         // if not, display error MessageBox
         if (Directory.Exists(inputTextBox.Text))
         {
            // add full path name to directoryTreeView
            directoryTreeView.Nodes.Add(inputTextBox.Text);

            // insert subfolders
            PopulateTreeView(
               inputTextBox.Text, directoryTreeView.Nodes[0]);
         }
         // display error MessageBox if directory not found
         else
         {
            MessageBox.Show(inputTextBox.Text + " could not be found.",
               "Directory Not Found", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
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
