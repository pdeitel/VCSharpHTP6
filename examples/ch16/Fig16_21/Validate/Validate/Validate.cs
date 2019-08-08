// Fig. 16.21: Validate.cs
// Validate user information using regular expressions.
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Validate
{
   public partial class ValidateForm : Form
   {
      public ValidateForm()
      {
         InitializeComponent();
      } // end constructor

      // handles OK Button's Click event
      private void okButton_Click( object sender, EventArgs e )
      {
         // find blank TextBoxes and order by TabIndex
         var emptyBoxes =
            from Control currentControl in Controls
            where currentControl is TextBox
            let box = currentControl as TextBox
            where String.IsNullOrEmpty( box.Text )
            orderby box.TabIndex
            select box;

         // if there are any empty TextBoxes
         if ( emptyBoxes.Count() > 0 )
         {
            // display message box indicating missing information
            MessageBox.Show( "Please fill in all fields",
               "Missing Information", MessageBoxButtons.OK,
               MessageBoxIcon.Error );

            emptyBoxes.First().Select(); // select first empty TextBox
         } // end if
         else
         {
            // check for invalid input
            if ( !ValidateInput( lastNameTextBox.Text,
               "^[A-Z][a-zA-Z]*$", "Invalid last name" ) )

               lastNameTextBox.Select(); // select invalid TextBox
            else if ( !ValidateInput( firstNameTextBox.Text,
               "^[A-Z][a-zA-Z]*$", "Invalid first name" ) )

               firstNameTextBox.Select(); // select invalid TextBox
            else if ( !ValidateInput( addressTextBox.Text,
               @"^[0-9]+\s+([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$",
               "Invalid address" ) )

               addressTextBox.Select(); // select invalid TextBox
            else if ( !ValidateInput( cityTextBox.Text,
               @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$", "Invalid city" ) )

               cityTextBox.Select(); // select invalid TextBox
            else if ( !ValidateInput( stateTextBox.Text,
               @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$", "Invalid state" ) )

               stateTextBox.Select(); // select invalid TextBox
            else if ( !ValidateInput( zipCodeTextBox.Text,
               @"^\d{5}$", "Invalid zip code" ) )

               zipCodeTextBox.Select(); // select invalid TextBox
            else if ( !ValidateInput( phoneTextBox.Text,
               @"^[1-9]\d{2}-[1-9]\d{2}-\d{4}$", 
               "Invalid phone number" ) )

               phoneTextBox.Select(); // select invalid TextBox
            else // if all input is valid
            {
               this.Hide(); // hide main window
               MessageBox.Show( "Thank You!", "Information Correct",
                  MessageBoxButtons.OK, MessageBoxIcon.Information );
               Application.Exit(); // exit the application
            } // end else            
         } // end else
      } // end method okButton_Click

      // use regular expressions to validate user input
      private bool ValidateInput(
         string input, string expression, string message )
      {
         // store whether the input is valid
         bool valid = Regex.Match( input, expression ).Success;

         // if the input doesn't match the regular expression
         if ( !valid )
         {
            // signal the user that input was invalid
            MessageBox.Show( message, "Invalid Input",
               MessageBoxButtons.OK, MessageBoxIcon.Error );
         } // end if

         return valid; // return whether the input is valid
      } // end method ValidateInput
   } // end class ValidateForm
} // end namespace Validate

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