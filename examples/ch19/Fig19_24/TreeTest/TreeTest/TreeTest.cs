// Fig. 19.24: TreeTest.cs
// Testing class Tree with IComparable objects.
using System;
using BinaryTreeLibrary2;

// class TreeTest declaration
class TreeTest
{
   // test class Tree
   static void Main()
   {
      int[] intArray = {8, 2, 4, 3, 1, 7, 5, 6};
      double[] doubleArray = {8.8, 2.2, 4.4, 3.3, 1.1, 7.7, 5.5, 6.6};
      string[] stringArray =
         {"eight", "two", "four","three", "one", "seven", "five", "six"};

      // create int Tree
      Tree intTree = new Tree();
      PopulateTree(intArray, intTree, nameof(intTree));
      TraverseTree(intTree, nameof(intTree));

      // create double Tree
      Tree doubleTree = new Tree();
      PopulateTree(doubleArray, doubleTree, nameof(doubleTree));
      TraverseTree(doubleTree, nameof(doubleTree));

      // create string Tree
      Tree stringTree = new Tree();
      PopulateTree(stringArray, stringTree, nameof(stringTree));
      TraverseTree(stringTree, nameof(stringTree));
   }

   // populate Tree with array elements
   private static void PopulateTree(Array array, Tree tree, string name)
   {
      Console.WriteLine($"\n\n\nInserting into {name}:");

      foreach (IComparable data in array)
      {
         Console.Write($"{data} ");
         tree.InsertNode(data);
      }
   }

   // perform traversals
   private static void TraverseTree(Tree tree, string treeType)
   {
      // perform preorder traversal of tree
      Console.WriteLine($"\n\nPreorder traversal of {treeType}");
      tree.PreorderTraversal();

      // perform inorder traversal of tree
      Console.WriteLine($"\n\nInorder traversal of {treeType}");
      tree.InorderTraversal();

      // perform postorder traversal of tree
      Console.WriteLine($"\n\nPostorder traversal of {treeType}");
      tree.PostorderTraversal();
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