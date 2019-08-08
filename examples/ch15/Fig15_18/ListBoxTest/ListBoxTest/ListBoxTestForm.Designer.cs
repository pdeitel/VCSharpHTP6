namespace ListBoxTest
{
   partial class ListBoxTestForm
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
         this.exitButton = new System.Windows.Forms.Button();
         this.clearButton = new System.Windows.Forms.Button();
         this.removeButton = new System.Windows.Forms.Button();
         this.addButton = new System.Windows.Forms.Button();
         this.inputTextBox = new System.Windows.Forms.TextBox();
         this.displayListBox = new System.Windows.Forms.ListBox();
         this.SuspendLayout();
         // 
         // exitButton
         // 
         this.exitButton.Location = new System.Drawing.Point( 171, 237 );
         this.exitButton.Name = "exitButton";
         this.exitButton.Size = new System.Drawing.Size( 100, 36 );
         this.exitButton.TabIndex = 23;
         this.exitButton.Text = "Exit";
         this.exitButton.Click += new System.EventHandler( this.exitButton_Click );
         // 
         // clearButton
         // 
         this.clearButton.Location = new System.Drawing.Point( 171, 184 );
         this.clearButton.Name = "clearButton";
         this.clearButton.Size = new System.Drawing.Size( 100, 36 );
         this.clearButton.TabIndex = 22;
         this.clearButton.Text = "Clear";
         this.clearButton.Click += new System.EventHandler( this.clearButton_Click );
         // 
         // removeButton
         // 
         this.removeButton.Location = new System.Drawing.Point( 171, 129 );
         this.removeButton.Name = "removeButton";
         this.removeButton.Size = new System.Drawing.Size( 100, 36 );
         this.removeButton.TabIndex = 21;
         this.removeButton.Text = "Remove";
         this.removeButton.Click += new System.EventHandler( this.removeButton_Click );
         // 
         // addButton
         // 
         this.addButton.Location = new System.Drawing.Point( 171, 74 );
         this.addButton.Name = "addButton";
         this.addButton.Size = new System.Drawing.Size( 100, 36 );
         this.addButton.TabIndex = 20;
         this.addButton.Text = "Add";
         this.addButton.Click += new System.EventHandler( this.addButton_Click );
         // 
         // inputTextBox
         // 
         this.inputTextBox.Location = new System.Drawing.Point( 171, 29 );
         this.inputTextBox.Name = "inputTextBox";
         this.inputTextBox.Size = new System.Drawing.Size( 100, 23 );
         this.inputTextBox.TabIndex = 19;
         // 
         // displayListBox
         // 
         this.displayListBox.FormattingEnabled = true;
         this.displayListBox.ItemHeight = 15;
         this.displayListBox.Location = new System.Drawing.Point( 35, 29 );
         this.displayListBox.Name = "displayListBox";
         this.displayListBox.Size = new System.Drawing.Size( 119, 244 );
         this.displayListBox.TabIndex = 18;
         // 
         // ListBoxTestForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF( 7F, 15F );
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size( 307, 302 );
         this.Controls.Add( this.exitButton );
         this.Controls.Add( this.clearButton );
         this.Controls.Add( this.removeButton );
         this.Controls.Add( this.addButton );
         this.Controls.Add( this.inputTextBox );
         this.Controls.Add( this.displayListBox );
         this.Font = new System.Drawing.Font( "Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.Name = "ListBoxTestForm";
         this.Text = "ListBoxTest";
         this.ResumeLayout( false );
         this.PerformLayout();

      }

      #endregion

      internal System.Windows.Forms.Button exitButton;
      internal System.Windows.Forms.Button clearButton;
      internal System.Windows.Forms.Button removeButton;
      internal System.Windows.Forms.Button addButton;
      internal System.Windows.Forms.TextBox inputTextBox;
      internal System.Windows.Forms.ListBox displayListBox;

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
