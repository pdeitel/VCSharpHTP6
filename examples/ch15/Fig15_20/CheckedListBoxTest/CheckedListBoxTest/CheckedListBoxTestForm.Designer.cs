namespace CheckedListBoxTest
{
   partial class CheckedListBoxTestForm
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
         this.displayListBox = new System.Windows.Forms.ListBox();
         this.itemCheckedListBox = new System.Windows.Forms.CheckedListBox();
         this.SuspendLayout();
         // 
         // displayListBox
         // 
         this.displayListBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.displayListBox.FormattingEnabled = true;
         this.displayListBox.ItemHeight = 15;
         this.displayListBox.Location = new System.Drawing.Point(182, 17);
         this.displayListBox.Name = "displayListBox";
         this.displayListBox.Size = new System.Drawing.Size(141, 124);
         this.displayListBox.TabIndex = 7;
         // 
         // itemCheckedListBox
         // 
         this.itemCheckedListBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.itemCheckedListBox.FormattingEnabled = true;
         this.itemCheckedListBox.Items.AddRange(new object[] {
            "C HTP",
            "C++ HTP",
            "Internet & WWW HTP",
            "Java HTP",
            "Visaul Basic HTP",
            "Visual C++ HTP",
            "Visual C# HTP"});
         this.itemCheckedListBox.Location = new System.Drawing.Point(12, 14);
         this.itemCheckedListBox.Name = "itemCheckedListBox";
         this.itemCheckedListBox.Size = new System.Drawing.Size(150, 130);
         this.itemCheckedListBox.TabIndex = 6;
         this.itemCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.itemCheckedListBox_ItemCheck);
         // 
         // CheckedListBoxTestForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(335, 159);
         this.Controls.Add(this.displayListBox);
         this.Controls.Add(this.itemCheckedListBox);
         this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Name = "CheckedListBoxTestForm";
         this.Text = "CheckedListBoxTest";
         this.ResumeLayout(false);

      }

      #endregion

      internal System.Windows.Forms.ListBox displayListBox;
      internal System.Windows.Forms.CheckedListBox itemCheckedListBox;

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
