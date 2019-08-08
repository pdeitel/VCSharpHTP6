namespace CheckBoxTest
{
   partial class CheckBoxTestForm
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
         this.italicCheckBox = new System.Windows.Forms.CheckBox();
         this.boldCheckBox = new System.Windows.Forms.CheckBox();
         this.outputLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // italicCheckBox
         // 
         this.italicCheckBox.AutoSize = true;
         this.italicCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.italicCheckBox.Location = new System.Drawing.Point(138, 39);
         this.italicCheckBox.Name = "italicCheckBox";
         this.italicCheckBox.Size = new System.Drawing.Size(51, 19);
         this.italicCheckBox.TabIndex = 14;
         this.italicCheckBox.Text = "Italic";
         this.italicCheckBox.CheckedChanged += new System.EventHandler(this.italicCheckBox_CheckedChanged);
         // 
         // boldCheckBox
         // 
         this.boldCheckBox.AutoSize = true;
         this.boldCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.boldCheckBox.Location = new System.Drawing.Point(58, 39);
         this.boldCheckBox.Name = "boldCheckBox";
         this.boldCheckBox.Size = new System.Drawing.Size(50, 19);
         this.boldCheckBox.TabIndex = 13;
         this.boldCheckBox.Text = "Bold";
         this.boldCheckBox.CheckedChanged += new System.EventHandler(this.boldCheckBox_CheckedChanged);
         // 
         // outputLabel
         // 
         this.outputLabel.AutoSize = true;
         this.outputLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.outputLabel.Location = new System.Drawing.Point(47, 9);
         this.outputLabel.Name = "outputLabel";
         this.outputLabel.Size = new System.Drawing.Size(155, 15);
         this.outputLabel.TabIndex = 12;
         this.outputLabel.Text = "Watch the font style change";
         // 
         // CheckBoxTestForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(249, 70);
         this.Controls.Add(this.italicCheckBox);
         this.Controls.Add(this.boldCheckBox);
         this.Controls.Add(this.outputLabel);
         this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Name = "CheckBoxTestForm";
         this.Text = "CheckBox Test";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      internal System.Windows.Forms.CheckBox italicCheckBox;
      internal System.Windows.Forms.CheckBox boldCheckBox;
      internal System.Windows.Forms.Label outputLabel;
   }
}

