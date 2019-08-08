// Fig. 22.33: Contact.cs
// Manipulating an address book.
using System;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace AddressBook
{
   public partial class Contacts : Form
   {
      public Contacts()
      {
         InitializeComponent();
      }

      // Entity Framework DbContext
      private AddressExample.AddressBookEntities dbcontext = null;

      // fill our addressBindingSource with all rows, ordered by name
      private void RefreshContacts()
      {
         // Dispose old DbContext, if any
         if (dbcontext != null)
         {
            dbcontext.Dispose();
         }

         // create new DbContext so we can reorder records based on edits
         dbcontext = new AddressExample.AddressBookEntities();

         // use LINQ to order the Addresses table contents 
         // by last name, then first name
         dbcontext.Addresses
            .OrderBy(entry => entry.LastName)
            .ThenBy(entry => entry.FirstName)
            .Load();

         // specify DataSource for addressBindingSource
         addressBindingSource.DataSource = dbcontext.Addresses.Local;
         addressBindingSource.MoveFirst(); // go to first result     
         findTextBox.Clear(); // clear the Find TextBox              
      }

      // when the form loads, fill it with data from the database
      private void Contacts_Load(object sender, EventArgs e)
      {
         RefreshContacts(); // fill binding with data from database
      }

      // Click event handler for the Save Button in the 
      // BindingNavigator saves the changes made to the data
      private void addressBindingNavigatorSaveItem_Click(
         object sender, EventArgs e)
      {
         Validate(); // validate input fields
         addressBindingSource.EndEdit(); // complete current edit, if any

         // try to save changes
         try
         {
            dbcontext.SaveChanges(); // write changes to database file
         }
         catch (DbEntityValidationException)
         {
            MessageBox.Show("Columns cannot be empty",
               "Entity Validation Exception");
         }

         RefreshContacts(); // change back to initial unfiltered data 
      }

      // use LINQ to create a data source that contains only people
      // with last names that start with the specified text
      private void findButton_Click(object sender, EventArgs e)
      {
         // use LINQ to filter contacts with last names that
         // start with findTextBox contents
         var lastNameQuery =
            from address in dbcontext.Addresses
            where address.LastName.StartsWith(findTextBox.Text)
            orderby address.LastName, address.FirstName
            select address;

         // display matching contacts
         addressBindingSource.DataSource = lastNameQuery.ToList();
         addressBindingSource.MoveFirst(); // go to first result  

         // don't allow add/delete when contacts are filtered
         bindingNavigatorAddNewItem.Enabled = false;
         bindingNavigatorDeleteItem.Enabled = false;
      }

      // reload addressBindingSource with all rows
      private void browseAllButton_Click(object sender, EventArgs e)
      {
         // allow add/delete when contacts are not filtered
         bindingNavigatorAddNewItem.Enabled = true;
         bindingNavigatorDeleteItem.Enabled = true;
         RefreshContacts(); // change back to initial unfiltered data
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
