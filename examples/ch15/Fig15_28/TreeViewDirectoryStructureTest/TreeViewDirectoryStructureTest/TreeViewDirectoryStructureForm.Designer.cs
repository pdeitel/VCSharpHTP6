namespace TreeViewDirectoryStructure
{
   partial class TreeViewDirectoryStructureForm
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
         this.enterButton = new System.Windows.Forms.Button();
         this.inputTextBox = new System.Windows.Forms.TextBox();
         this.promptLabel = new System.Windows.Forms.Label();
         this.directoryTreeView = new System.Windows.Forms.TreeView();
         this.SuspendLayout();
         // 
         // enterButton
         // 
         this.enterButton.Location = new System.Drawing.Point(221, 27);
         this.enterButton.Name = "enterButton";
         this.enterButton.Size = new System.Drawing.Size(100, 23);
         this.enterButton.TabIndex = 15;
         this.enterButton.Text = "Enter";
         this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
         // 
         // inputTextBox
         // 
         this.inputTextBox.Location = new System.Drawing.Point(12, 27);
         this.inputTextBox.Name = "inputTextBox";
         this.inputTextBox.Size = new System.Drawing.Size(203, 23);
         this.inputTextBox.TabIndex = 14;
         // 
         // promptLabel
         // 
         this.promptLabel.AutoSize = true;
         this.promptLabel.Location = new System.Drawing.Point(9, 9);
         this.promptLabel.Name = "promptLabel";
         this.promptLabel.Size = new System.Drawing.Size(309, 15);
         this.promptLabel.TabIndex = 13;
         this.promptLabel.Text = "Enter the full path to the directory you would like to view:";
         // 
         // directoryTreeView
         // 
         this.directoryTreeView.Location = new System.Drawing.Point(12, 56);
         this.directoryTreeView.Name = "directoryTreeView";
         this.directoryTreeView.Size = new System.Drawing.Size(309, 273);
         this.directoryTreeView.TabIndex = 12;
         // 
         // TreeViewDirectoryStructureForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(335, 342);
         this.Controls.Add(this.enterButton);
         this.Controls.Add(this.inputTextBox);
         this.Controls.Add(this.promptLabel);
         this.Controls.Add(this.directoryTreeView);
         this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Name = "TreeViewDirectoryStructureForm";
         this.Text = "TreeViewDirectoryStructure";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      internal System.Windows.Forms.Button enterButton;
      internal System.Windows.Forms.TextBox inputTextBox;
      internal System.Windows.Forms.Label promptLabel;
      internal System.Windows.Forms.TreeView directoryTreeView;

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
