namespace LinkLabelTest
{
   partial class LinkLabelTestForm
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
         this.notepadLinkLabel = new System.Windows.Forms.LinkLabel();
         this.deitelLinkLabel = new System.Windows.Forms.LinkLabel();
         this.cDriveLinkLabel = new System.Windows.Forms.LinkLabel();
         this.SuspendLayout();
         // 
         // notepadLinkLabel
         // 
         this.notepadLinkLabel.AutoSize = true;
         this.notepadLinkLabel.Font = new System.Drawing.Font( "Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.notepadLinkLabel.Location = new System.Drawing.Point( 25, 88 );
         this.notepadLinkLabel.Name = "notepadLinkLabel";
         this.notepadLinkLabel.Size = new System.Drawing.Size( 117, 15 );
         this.notepadLinkLabel.TabIndex = 11;
         this.notepadLinkLabel.TabStop = true;
         this.notepadLinkLabel.Text = "Click to run Notepad";
         this.notepadLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler( this.notepadLinkLabel_LinkClicked );
         // 
         // deitelLinkLabel
         // 
         this.deitelLinkLabel.AutoSize = true;
         this.deitelLinkLabel.Font = new System.Drawing.Font( "Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.deitelLinkLabel.Location = new System.Drawing.Point( 25, 57 );
         this.deitelLinkLabel.Name = "deitelLinkLabel";
         this.deitelLinkLabel.Size = new System.Drawing.Size( 160, 15 );
         this.deitelLinkLabel.TabIndex = 10;
         this.deitelLinkLabel.TabStop = true;
         this.deitelLinkLabel.Text = "Click to visit www.deitel.com";
         this.deitelLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler( this.deitelLinkLabel_LinkClicked );
         // 
         // cDriveLinkLabel
         // 
         this.cDriveLinkLabel.AutoSize = true;
         this.cDriveLinkLabel.Font = new System.Drawing.Font( "Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.cDriveLinkLabel.Location = new System.Drawing.Point( 25, 27 );
         this.cDriveLinkLabel.Name = "cDriveLinkLabel";
         this.cDriveLinkLabel.Size = new System.Drawing.Size( 107, 15 );
         this.cDriveLinkLabel.TabIndex = 9;
         this.cDriveLinkLabel.TabStop = true;
         this.cDriveLinkLabel.Text = "Click to browse C:\\";
         this.cDriveLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler( this.cDriveLinkLabel_LinkClicked );
         // 
         // LinkLabelTestForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF( 7F, 15F );
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size( 210, 130 );
         this.Controls.Add( this.notepadLinkLabel );
         this.Controls.Add( this.deitelLinkLabel );
         this.Controls.Add( this.cDriveLinkLabel );
         this.Font = new System.Drawing.Font( "Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.Name = "LinkLabelTestForm";
         this.Text = "LinkLabelTest";
         this.ResumeLayout( false );
         this.PerformLayout();

      }

      #endregion

      internal System.Windows.Forms.LinkLabel notepadLinkLabel;
      internal System.Windows.Forms.LinkLabel deitelLinkLabel;
      internal System.Windows.Forms.LinkLabel cDriveLinkLabel;

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
