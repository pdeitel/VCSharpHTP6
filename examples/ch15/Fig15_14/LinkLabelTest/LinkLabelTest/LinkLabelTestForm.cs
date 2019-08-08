// Fig. 15.14: LinkLabelTestForm.cs
// Using LinkLabels to create hyperlinks.
using System;
using System.Windows.Forms;

namespace LinkLabelTest
{
   // Form using LinkLabels to browse the C:\ drive,
   // load a web page and run Notepad
   public partial class LinkLabelTestForm : Form
   {
      // constructor
      public LinkLabelTestForm()
      {
         InitializeComponent();
      } 
   
      // browse C:\ drive
      private void cDriveLinkLabel_LinkClicked(object sender,
         LinkLabelLinkClickedEventArgs e)
      {
         // change LinkColor after it has been clicked
         cDriveLinkLabel.LinkVisited = true;         
                                                    
         System.Diagnostics.Process.Start(@"C:\");
      } 
   
      // load www.deitel.com in web browser
      private void deitelLinkLabel_LinkClicked(object sender,
         LinkLabelLinkClickedEventArgs e)
      {
         // change LinkColor after it has been clicked
         deitelLinkLabel.LinkVisited = true;                         
                                                                     
         System.Diagnostics.Process.Start("http://www.deitel.com");
      } 
   
      // run app Notepad
      private void notepadLinkLabel_LinkClicked(object sender,
         LinkLabelLinkClickedEventArgs e)
      {
         // change LinkColor after it has been clicked
         notepadLinkLabel.LinkVisited = true;          
                                                       
         // program called as if in run                
         // menu and full path not needed              
         System.Diagnostics.Process.Start("notepad");
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
