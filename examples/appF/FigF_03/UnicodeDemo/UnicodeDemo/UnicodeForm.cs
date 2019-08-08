// Fig. G.3: UnicodeForm.cs
// Unicode enconding demonstration.
using System;
using System.Windows.Forms;

namespace UnicodeDemo
{
   public partial class UnicodeForm : Form
   {
      public UnicodeForm()
      {
         InitializeComponent();
      }

      // assign Unicode strings to each Label
      private void UnicodeForm_Load(object sender, EventArgs e)
      {
         // English
         char[] english = { '\u0057', '\u0065', '\u006C',  
            '\u0063', '\u006F', '\u006D', '\u0065', '\u0020',
            '\u0074', '\u006F', '\u0020' };
         englishLabel.Text = new string(english) +
            "Unicode" + '\u0021';

         // French
         char[] french = { '\u0042', '\u0069', '\u0065', 
            '\u006E', '\u0076', '\u0065', '\u006E', '\u0075',
            '\u0065', '\u0020', '\u0061', '\u0075', '\u0020' };
         frenchLabel.Text = new string(french) +
            "Unicode" + '\u0021';

         // German
         char[] german = { '\u0057', '\u0069', '\u006C', 
            '\u006B', '\u006F', '\u006D', '\u006D', '\u0065',
            '\u006E', '\u0020', '\u007A', '\u0075', '\u0020' };
         germanLabel.Text = new string(german) +
            "Unicode" + '\u0021';

         // Japanese
         char[] japanese = { '\u3078',  '\u3087', '\u3045',
            '\u3053', '\u305D', '\u0021' };
         japaneseLabel.Text = "Unicode" + new string(japanese);

         // Portuguese
         char[] portuguese = { '\u0053', '\u0065', '\u006A', 
            '\u0061', '\u0020', '\u0062', '\u0065', '\u006D',
            '\u0020', '\u0076', '\u0069', '\u006E', '\u0064',  
            '\u006F', '\u0020', '\u0061', '\u0020' };
         portugueseLabel.Text = new string(portuguese) +
            "Unicode" + '\u0021';

         // Russian
         char[] russian = { '\u0414', '\u043E', '\u0431', 
            '\u0440', '\u043E', '\u0020', '\u043F', '\u043E', 
            '\u0436', '\u0430', '\u043B', '\u043E', '\u0432',
            '\u0430', '\u0442', '\u044A', '\u0020', '\u0432', '\u0020' };
         russianLabel.Text = new string(russian) +
            "Unicode" + '\u0021';

         // Spanish
         char[] spanish = { '\u0042', '\u0069', '\u0065', 
            '\u006E', '\u0076', '\u0065', '\u006E', '\u0069', 
            '\u0064', '\u006F', '\u0020', '\u0061', '\u0020' };
         spanishLabel.Text = new string(spanish) +
            "Unicode" + '\u0021';

         // Simplified Chinese
         char[] chinese = { '\u6B22', '\u8FCE', '\u4F7F', 
            '\u7528', '\u0020' };
         chineseLabel.Text = new string(chinese) +
            "Unicode" + '\u0021';
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
