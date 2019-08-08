// Fig. 24.20: XDocumentTestForm.cs
// Reading an XML document and displaying it in a TextBox.
using System;
using System.Xml.Linq;
using System.Windows.Forms;

namespace XDocumentTest
{
   public partial class XDocumentTestForm : Form
   {
      public XDocumentTestForm()
      {
         InitializeComponent();
      }

      // read XML document and display its content
      private void XDocumentTestForm_Load(object sender, EventArgs e)
      {
         // load the XML file into an XDocument
         XDocument xmlFile = XDocument.Load("article.xml");
         int indentLevel = 0; // no indentation for root element

         // print elements recursively
         PrintElement(xmlFile.Root, indentLevel);
      }

      // display an element (and its children, if any) in the TextBox
      private void PrintElement(XElement element, int indentLevel)
      {
         // get element name without namespace
         string name = element.Name.LocalName;

         // display the element's name within its tag
         IndentOutput(indentLevel); // indent correct amount
         outputTextBox.AppendText('<' + name + ">\n");

         // check for child elements and print value if none contained
         if (element.HasElements)
         {
            // print all child elements at the next indentation level
            foreach (var child in element.Elements())
            {
               PrintElement(child, indentLevel + 1);
            }
         }
         else
         {
            // increase the indentation amount for text elements
            IndentOutput(indentLevel + 1);

            // display the text inside this element
            outputTextBox.AppendText(element.Value.Trim() + '\n');
         }

         // display end tag
         IndentOutput(indentLevel);
         outputTextBox.AppendText("</" + name + ">\n");
      }

      // add the specified amount of indentation to the current line
      private void IndentOutput(int number)
      {
         for (int i = 0; i < number; ++i)
         {
            outputTextBox.AppendText("   ");
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
 **************************************************************************/
