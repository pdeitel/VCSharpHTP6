namespace LabelTextBoxButtonTest
{
   partial class LabelTextBoxButtonTestForm
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
         this.displayPasswordButton = new System.Windows.Forms.Button();
         this.displayPasswordLabel = new System.Windows.Forms.Label();
         this.inputPasswordTextBox = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // displayPasswordButton
         // 
         this.displayPasswordButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.displayPasswordButton.Location = new System.Drawing.Point(123, 72);
         this.displayPasswordButton.Name = "displayPasswordButton";
         this.displayPasswordButton.Size = new System.Drawing.Size(75, 23);
         this.displayPasswordButton.TabIndex = 5;
         this.displayPasswordButton.Text = "Show Me";
         this.displayPasswordButton.Click += new System.EventHandler(this.displayPasswordButton_Click);
         // 
         // displayPasswordLabel
         // 
         this.displayPasswordLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.displayPasswordLabel.Location = new System.Drawing.Point(12, 42);
         this.displayPasswordLabel.Name = "displayPasswordLabel";
         this.displayPasswordLabel.Size = new System.Drawing.Size(297, 23);
         this.displayPasswordLabel.TabIndex = 4;
         this.displayPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // inputPasswordTextBox
         // 
         this.inputPasswordTextBox.Location = new System.Drawing.Point(12, 12);
         this.inputPasswordTextBox.Name = "inputPasswordTextBox";
         this.inputPasswordTextBox.Size = new System.Drawing.Size(297, 23);
         this.inputPasswordTextBox.TabIndex = 3;
         this.inputPasswordTextBox.UseSystemPasswordChar = true;
         // 
         // LabelTextBoxButtonTestForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(321, 107);
         this.Controls.Add(this.displayPasswordButton);
         this.Controls.Add(this.displayPasswordLabel);
         this.Controls.Add(this.inputPasswordTextBox);
         this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Name = "LabelTextBoxButtonTestForm";
         this.Text = "Label, TextBox and Button Test";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button displayPasswordButton;
      private System.Windows.Forms.Label displayPasswordLabel;
      private System.Windows.Forms.TextBox inputPasswordTextBox;
   }
}

