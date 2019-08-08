namespace VisualInheritanceBase
{
   partial class VisualInheritanceBaseForm
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
         this.learnMoreButton = new System.Windows.Forms.Button();
         this.twoLabel = new System.Windows.Forms.Label();
         this.oneLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // learnMoreButton
         // 
         this.learnMoreButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.learnMoreButton.Location = new System.Drawing.Point(12, 83);
         this.learnMoreButton.Name = "learnMoreButton";
         this.learnMoreButton.Size = new System.Drawing.Size(145, 59);
         this.learnMoreButton.TabIndex = 20;
         this.learnMoreButton.Text = "Learn More";
         this.learnMoreButton.Click += new System.EventHandler(this.learnMoreButton_Click);
         // 
         // twoLabel
         // 
         this.twoLabel.BackColor = System.Drawing.Color.LightYellow;
         this.twoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.twoLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.twoLabel.ForeColor = System.Drawing.Color.MidnightBlue;
         this.twoLabel.Location = new System.Drawing.Point(12, 156);
         this.twoLabel.Name = "twoLabel";
         this.twoLabel.Size = new System.Drawing.Size(300, 25);
         this.twoLabel.TabIndex = 19;
         this.twoLabel.Text = "Copyright 2017, by Deitel && Associates, Inc.";
         this.twoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // oneLabel
         // 
         this.oneLabel.BackColor = System.Drawing.Color.LightYellow;
         this.oneLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.oneLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.oneLabel.ForeColor = System.Drawing.Color.MidnightBlue;
         this.oneLabel.Location = new System.Drawing.Point(12, 19);
         this.oneLabel.Name = "oneLabel";
         this.oneLabel.Size = new System.Drawing.Size(300, 47);
         this.oneLabel.TabIndex = 18;
         this.oneLabel.Text = "Bugs, Bugs, Bugs";
         this.oneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // VisualInheritanceBaseForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(324, 201);
         this.Controls.Add(this.learnMoreButton);
         this.Controls.Add(this.twoLabel);
         this.Controls.Add(this.oneLabel);
         this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Name = "VisualInheritanceBaseForm";
         this.Text = "Visual Inheritance Base";
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button learnMoreButton;
      private System.Windows.Forms.Label twoLabel;
      private System.Windows.Forms.Label oneLabel;

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
