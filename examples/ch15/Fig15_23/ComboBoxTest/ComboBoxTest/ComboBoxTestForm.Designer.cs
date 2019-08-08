namespace ComboBoxTest
{
   partial class ComboBoxTestForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose( bool disposing )
      {
         if ( disposing && ( components != null ) )
         {
            components.Dispose();
         }
         base.Dispose( disposing );
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.imageComboBox = new System.Windows.Forms.ComboBox();
         this.SuspendLayout();
         // 
         // imageComboBox
         // 
         this.imageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.imageComboBox.Font = new System.Drawing.Font( "Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.imageComboBox.FormattingEnabled = true;
         this.imageComboBox.Items.AddRange( new object[] {
            "Circle",
            "Square",
            "Ellipse",
            "Pie",
            "Filled Circle",
            "Filled Square",
            "Filled Ellipse",
            "Filled Pie"} );
         this.imageComboBox.Location = new System.Drawing.Point( 12, 12 );
         this.imageComboBox.Name = "imageComboBox";
         this.imageComboBox.Size = new System.Drawing.Size( 151, 23 );
         this.imageComboBox.TabIndex = 3;
         this.imageComboBox.SelectedIndexChanged += new System.EventHandler( this.imageComboBox_SelectedIndexChanged );
         // 
         // ComboBoxTestForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF( 7F, 15F );
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.ClientSize = new System.Drawing.Size( 308, 249 );
         this.Controls.Add( this.imageComboBox );
         this.Font = new System.Drawing.Font( "Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.Name = "ComboBoxTestForm";
         this.Text = "ComboBoxTest";
         this.ResumeLayout( false );

      }

      #endregion

      internal System.Windows.Forms.ComboBox imageComboBox;

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
