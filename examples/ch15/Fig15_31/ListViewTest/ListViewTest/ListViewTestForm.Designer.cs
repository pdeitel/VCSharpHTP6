namespace ListViewTest
{
   partial class ListViewTestForm
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
         this.components = new System.ComponentModel.Container();
         this.displayLabel = new System.Windows.Forms.Label();
         this.fileFolderImageList = new System.Windows.Forms.ImageList(this.components);
         this.currentLabel = new System.Windows.Forms.Label();
         this.browserListView = new System.Windows.Forms.ListView();
         this.SuspendLayout();
         // 
         // displayLabel
         // 
         this.displayLabel.AutoSize = true;
         this.displayLabel.Location = new System.Drawing.Point(64, 10);
         this.displayLabel.Name = "displayLabel";
         this.displayLabel.Size = new System.Drawing.Size(0, 15);
         this.displayLabel.TabIndex = 11;
         // 
         // fileFolderImageList
         // 
         this.fileFolderImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
         this.fileFolderImageList.ImageSize = new System.Drawing.Size(16, 16);
         this.fileFolderImageList.TransparentColor = System.Drawing.Color.Transparent;
         // 
         // currentLabel
         // 
         this.currentLabel.AutoSize = true;
         this.currentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.currentLabel.Location = new System.Drawing.Point(11, 10);
         this.currentLabel.Name = "currentLabel";
         this.currentLabel.Size = new System.Drawing.Size(51, 13);
         this.currentLabel.TabIndex = 10;
         this.currentLabel.Text = "Location:";
         // 
         // browserListView
         // 
         this.browserListView.Location = new System.Drawing.Point(12, 26);
         this.browserListView.Name = "browserListView";
         this.browserListView.Size = new System.Drawing.Size(561, 197);
         this.browserListView.SmallImageList = this.fileFolderImageList;
         this.browserListView.TabIndex = 9;
         this.browserListView.UseCompatibleStateImageBehavior = false;
         this.browserListView.View = System.Windows.Forms.View.List;
         this.browserListView.SelectedIndexChanged += new System.EventHandler(this.browserListView_Click);
         // 
         // ListViewTestForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(585, 236);
         this.Controls.Add(this.displayLabel);
         this.Controls.Add(this.currentLabel);
         this.Controls.Add(this.browserListView);
         this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Name = "ListViewTestForm";
         this.Text = "ListViewTest";
         this.Load += new System.EventHandler(this.ListViewTestForm_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      internal System.Windows.Forms.Label displayLabel;
      internal System.Windows.Forms.ImageList fileFolderImageList;
      internal System.Windows.Forms.Label currentLabel;
      internal System.Windows.Forms.ListView browserListView;

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
