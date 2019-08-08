// Fig. 19.21: TreeTest.cs
// Testing class Tree with a binary tree.
using System;
using BinaryTreeLibrary;

// class TreeTest declaration
class TreeTest
{
   // test class Tree
   static void Main()
   {
      Tree tree = new Tree();
      int insertValue;

      Console.WriteLine("Inserting values: ");
      Random random = new Random();

      // insert 10 random integers from 0-99 in tree 
      for (var i = 1; i <= 10; i++)
      {
         insertValue = random.Next(100);
         Console.Write($"{insertValue} ");

         tree.InsertNode(insertValue);
      }

      // perform preorder traversal of tree
      Console.WriteLine("\n\nPreorder traversal");
      tree.PreorderTraversal();

      // perform inorder traversal of tree
      Console.WriteLine("\n\nInorder traversal");
      tree.InorderTraversal();

      // perform postorder traversal of tree
      Console.WriteLine("\n\nPostorder traversal");
      tree.PostorderTraversal();
      Console.WriteLine();
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
