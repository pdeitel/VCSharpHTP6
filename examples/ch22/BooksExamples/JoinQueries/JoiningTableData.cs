// Fig. 22.30: JoiningTableData.cs
// Using LINQ to perform a join and aggregate data across tables.
using System;
using System.Linq;
using System.Windows.Forms;

namespace JoinQueries
{
   public partial class JoiningTableData : Form
   {
      public JoiningTableData()
      {
         InitializeComponent();
      }

      private void JoiningTableData_Load(object sender, EventArgs e)
      {
         // Entity Framework DbContext
         var dbcontext = new BooksExamples.BooksEntities();

         // get authors and ISBNs of each book they co-authored
         var authorsAndISBNs =
            from author in dbcontext.Authors
            from book in author.Titles
            orderby author.LastName, author.FirstName
            select new { author.FirstName, author.LastName, book.ISBN };

         outputTextBox.AppendText("Authors and ISBNs:");

         // display authors and ISBNs in tabular format
         foreach (var element in authorsAndISBNs)
         {
            outputTextBox.AppendText($"\r\n\t{element.FirstName,-10} " +
               $"{element.LastName,-10} {element.ISBN,-10}");
         }

         // get authors and titles of each book they co-authored
         var authorsAndTitles =
            from book in dbcontext.Titles
            from author in book.Authors
            orderby author.LastName, author.FirstName, book.Title1
            select new { author.FirstName, author.LastName, book.Title1 };

         outputTextBox.AppendText("\r\n\r\nAuthors and titles:");

         // display authors and titles in tabular format
         foreach (var element in authorsAndTitles)
         {
            outputTextBox.AppendText($"\r\n\t{element.FirstName,-10} " +
               $"{element.LastName,-10} {element.Title1}");
         }

         // get authors and titles of each book 
         // they co-authored; group by author
         var titlesByAuthor =
            from author in dbcontext.Authors
            orderby author.LastName, author.FirstName
            select new {Name = author.FirstName + " " + author.LastName,
               Titles =
                  from book in author.Titles
                  orderby book.Title1
                  select book.Title1};

         outputTextBox.AppendText("\r\n\r\nTitles grouped by author:");

         // display titles written by each author, grouped by author
         foreach (var author in titlesByAuthor)
         {
            // display author's name
            outputTextBox.AppendText($"\r\n\t{author.Name}:");

            // display titles written by that author
            foreach (var title in author.Titles)
            {
               outputTextBox.AppendText($"\r\n\t\t{title}");
            }
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
