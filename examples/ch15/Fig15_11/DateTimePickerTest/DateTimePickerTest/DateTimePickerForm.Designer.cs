namespace DateTimePickerTest 
{
   partial class DateTimePickerForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.dropOffLabel = new System.Windows.Forms.Label();
         this.deliveryLabel = new System.Windows.Forms.Label();
         this.outputLabel = new System.Windows.Forms.Label();
         this.dropOffDateTimePicker = new System.Windows.Forms.DateTimePicker();
         this.SuspendLayout();
         // 
         // dropOffLabel
         // 
         this.dropOffLabel.AutoSize = true;
         this.dropOffLabel.Location = new System.Drawing.Point(12, 9);
         this.dropOffLabel.Name = "dropOffLabel";
         this.dropOffLabel.Size = new System.Drawing.Size(83, 15);
         this.dropOffLabel.TabIndex = 15;
         this.dropOffLabel.Text = "Drop Off Date:";
         // 
         // deliveryLabel
         // 
         this.deliveryLabel.AutoSize = true;
         this.deliveryLabel.Location = new System.Drawing.Point(12, 66);
         this.deliveryLabel.Name = "deliveryLabel";
         this.deliveryLabel.Size = new System.Drawing.Size(134, 15);
         this.deliveryLabel.TabIndex = 14;
         this.deliveryLabel.Text = "Estimated Delivery Date:";
         // 
         // outputLabel
         // 
         this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.outputLabel.Location = new System.Drawing.Point(12, 84);
         this.outputLabel.Name = "outputLabel";
         this.outputLabel.Size = new System.Drawing.Size(212, 23);
         this.outputLabel.TabIndex = 13;
         this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // dropOffDateTimePicker
         // 
         this.dropOffDateTimePicker.Location = new System.Drawing.Point(12, 27);
         this.dropOffDateTimePicker.Name = "dropOffDateTimePicker";
         this.dropOffDateTimePicker.Size = new System.Drawing.Size(212, 23);
         this.dropOffDateTimePicker.TabIndex = 12;
         this.dropOffDateTimePicker.ValueChanged += new System.EventHandler(this.dropOffDateTimePicker_ValueChanged);
         // 
         // DateTimePickerForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(236, 122);
         this.Controls.Add(this.dropOffLabel);
         this.Controls.Add(this.deliveryLabel);
         this.Controls.Add(this.outputLabel);
         this.Controls.Add(this.dropOffDateTimePicker);
         this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Name = "DateTimePickerForm";
         this.Text = "DateTimePickerTest";
         this.Load += new System.EventHandler(this.DateTimePickerForm_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      internal System.Windows.Forms.Label dropOffLabel;
      internal System.Windows.Forms.Label deliveryLabel;
      internal System.Windows.Forms.Label outputLabel;
      private System.Windows.Forms.DateTimePicker dropOffDateTimePicker;

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

