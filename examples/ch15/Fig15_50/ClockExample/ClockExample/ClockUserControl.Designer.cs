namespace ClockExample
{
   partial class ClockUserControl
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

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         this.clockTimer = new System.Windows.Forms.Timer(this.components);
         this.displayLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // clockTimer
         // 
         this.clockTimer.Enabled = true;
         this.clockTimer.Interval = 1000;
         this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
         // 
         // displayLabel
         // 
         this.displayLabel.BackColor = System.Drawing.SystemColors.Window;
         this.displayLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.displayLabel.ForeColor = System.Drawing.Color.Black;
         this.displayLabel.Location = new System.Drawing.Point(4, 10);
         this.displayLabel.Name = "displayLabel";
         this.displayLabel.Size = new System.Drawing.Size(143, 52);
         this.displayLabel.TabIndex = 3;
         this.displayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // ClockUserControl
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.Controls.Add(this.displayLabel);
         this.Name = "ClockUserControl";
         this.Size = new System.Drawing.Size(150, 72);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Timer clockTimer;
      internal System.Windows.Forms.Label displayLabel;
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
