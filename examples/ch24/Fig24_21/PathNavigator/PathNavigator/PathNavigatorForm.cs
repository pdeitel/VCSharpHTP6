// Fig. 24.21: PathNavigatorForm.cs
// Document navigation using XNode.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml; // for XmlNodeType enumeration
using System.Xml.Linq; // for XNode and others
using System.Xml.XPath; // for XPathSelectElements
using System.Windows.Forms;

namespace PathNavigator
{
   public partial class PathNavigatorForm : Form
   {
      private XNode current; // currently selected node
      private XDocument document; // the document to navigate
      private TreeNode tree; // TreeNode used by TreeView control

      public PathNavigatorForm()
      {
         InitializeComponent();
      } 

      // initialize variables and TreeView control
      private void PathNavigatorForm_Load(object sender, EventArgs e)
      {
         document = XDocument.Load("sports.xml"); // load sports.xml

         // current node is the entire document
         current = document;

         // create root TreeNode and add to TreeView
         tree = new TreeNode(NodeText(current));
         pathTreeView.Nodes.Add(tree); // add TreeNode to TreeView
         TreeRefresh(); // reset the tree display
      } 

      // print the elements of the selected path
      private void locateComboBox_SelectedIndexChanged(
         object sender, EventArgs e)
      {
         // retrieve the set of elements to output
         switch (locateComboBox.SelectedIndex)
         {
            case 0: // print all sports elements
               PrintElements(document.Elements("sports"));
               break;
            case 1: // print all game elements
               PrintElements(document.Descendants("game"));
               break;
            case 2: // print all name elements
               PrintElements(document.XPathSelectElements("//name"));
               break;
            case 3: // print all paragraph elements
               PrintElements(document.Descendants("game")
                  .Elements("paragraph"));
               break;
            case 4: // print game elements with name element of "Cricket"
               // use LINQ to XML to retrieve the correct node
               var cricket =
                  from game in document.Descendants("game")
                  where game.Element("name").Value == "Cricket"
                  select game;
               PrintElements(cricket);
               break;
            case 5: // print all id attributes of game
               PrintIDs(document.Descendants("game"));
               break;
         } 
      }

      // traverse to first child
      private void firstChildButton_Click(object sender, EventArgs e)
      {
         // try to convert to an XContainer
         var container = current as XContainer;

         // if container has children, move to first child
         if (container != null && container.Nodes().Any())
         {
            current = container.Nodes().First(); // first child

            // create new TreeNode for this node with correct label
            var newNode = new TreeNode(NodeText(current));
            tree.Nodes.Add(newNode); // add node to TreeNode Nodes list
            tree = newNode; // move current selection to newNode
            TreeRefresh(); // reset the tree display
         } 
         else
         {
            // current is not a container or has no children
            MessageBox.Show("Current node has no children.", "Warning",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
         }
      }

      // traverse to node's parent
      private void parentButton_Click(object sender, EventArgs e)
      {
         // if current node is not the root, move to parent
         if (current.Parent != null)
            current = current.Parent; // get parent node
         else // node is at top level: move to document itself
            current = current.Document;

         // move TreeView if it is not already at the root
         if (tree.Parent != null)
         {
            tree = tree.Parent; // get parent in tree structure
            tree.Nodes.Clear(); // remove all children
            TreeRefresh(); // reset the tree display
         } 
      }

      // traverse to previous node
      private void previousButton_Click(object sender, EventArgs e)
      {
         // if current node is not first, move to previous node
         if (current.PreviousNode != null)
         {
            current = current.PreviousNode; // move to previous node
            var treeParent = tree.Parent; // get parent node
            treeParent.Nodes.Remove(tree); // delete current node
            tree = treeParent.LastNode; // set current display position
            TreeRefresh(); // reset the tree display
         }
         else // current element is first among its siblings
         {
            MessageBox.Show("Current node is first sibling.", "Warning",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
         }
      }

      // traverse to next node
      private void nextButton_Click(object sender, EventArgs e)
      {
         // if current node is not last, move to next node
         if (current.NextNode != null)
         {
            current = current.NextNode; // move to next node

            // create new TreeNode to display next node
            var newNode = new TreeNode(NodeText(current));
            var treeParent = tree.Parent; // get parent TreeNode
            treeParent.Nodes.Add(newNode); // add to parent node
            tree = newNode; // set current position for display
            TreeRefresh(); // reset the tree display
         } 
         else // current node is last among its siblings
         {
            MessageBox.Show("Current node is last sibling.", "Warning",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
         } 
      }

      // update TreeView control
      private void TreeRefresh()
      {
         pathTreeView.ExpandAll(); // expand tree node in TreeView
         pathTreeView.Refresh(); // force TreeView update
         pathTreeView.SelectedNode = tree; // highlight current node
      } 

      // print values in the given collection
      private void PrintElements(IEnumerable< XElement > elements)
      {
         locateTextBox.Clear(); // clear the text area

         // display text inside all elements
         foreach (var element in elements)
         {
            locateTextBox.AppendText(element.Value.Trim() + '\n');
         }
      }

      // print the ID numbers of all games in elements
      private void PrintIDs(IEnumerable< XElement > elements)
      {
         locateTextBox.Clear(); // clear the text area

         // display "id" attribute of all elements
         foreach (var element in elements)
         {
            locateTextBox.AppendText(
               element.Attribute("id").Value.Trim() + '\n');
         }
      } 

      // returns text used to represent an element in the tree
      private string NodeText(XNode node)
      {
         // different node types are displayed in different ways
         switch (node.NodeType)
         {
            case XmlNodeType.Document:
               // display the document root
               return "Document root";
            case XmlNodeType.Element:
               // represent node by tag name
               return '<' + (node as XElement).Name.LocalName + '>';
            case XmlNodeType.Text:
               // represent node by text stored in Value property
               return (node as XText).Value;
            case XmlNodeType.Comment:
               // represent node by comment text
               return (node as XComment).ToString();
            case XmlNodeType.ProcessingInstruction:
               // represent node by processing instruction text
               return (node as XProcessingInstruction).ToString();
            default:
               // all nodes in this example are already covered;
               // return a reasonable default value for other nodes
               return node.NodeType.ToString();
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
