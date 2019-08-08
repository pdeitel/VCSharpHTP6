namespace ReadSequentialAccessFile
{
   partial class ReadSequentialAccessFileForm
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
         this.nextButton = new System.Windows.Forms.Button();
         this.openButton = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // balanceTextBox
         // 
         this.balanceTextBox.Location = new System.Drawing.Point(175, 219);
         this.balanceTextBox.Size = new System.Drawing.Size(178, 23);
         // 
         // lastNameTextBox
         // 
         this.lastNameTextBox.Location = new System.Drawing.Point(175, 166);
         this.lastNameTextBox.Size = new System.Drawing.Size(178, 23);
         // 
         // firstNameTextBox
         // 
         this.firstNameTextBox.Location = new System.Drawing.Point(175, 112);
         this.firstNameTextBox.Size = new System.Drawing.Size(178, 23);
         // 
         // accountTextBox
         // 
         this.accountTextBox.Location = new System.Drawing.Point(175, 58);
         this.accountTextBox.Size = new System.Drawing.Size(178, 23);
         // 
         // label4
         // 
         this.label4.Location = new System.Drawing.Point(58, 223);
         this.label4.Size = new System.Drawing.Size(48, 15);
         // 
         // label3
         // 
         this.label3.Location = new System.Drawing.Point(58, 174);
         this.label3.Size = new System.Drawing.Size(63, 15);
         // 
         // label2
         // 
         this.label2.Location = new System.Drawing.Point(59, 120);
         this.label2.Size = new System.Drawing.Size(64, 15);
         // 
         // label1
         // 
         this.label1.Location = new System.Drawing.Point(59, 68);
         this.label1.Size = new System.Drawing.Size(52, 15);
         // 
         // nextButton
         // 
         this.nextButton.Enabled = false;
         this.nextButton.Location = new System.Drawing.Point(215, 272);
         this.nextButton.Name = "nextButton";
         this.nextButton.Size = new System.Drawing.Size(139, 51);
         this.nextButton.TabIndex = 17;
         this.nextButton.Text = "Next Record";
         this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
         // 
         // openButton
         // 
         this.openButton.Location = new System.Drawing.Point(62, 272);
         this.openButton.Name = "openButton";
         this.openButton.Size = new System.Drawing.Size(135, 51);
         this.openButton.TabIndex = 16;
         this.openButton.Text = "Open File";
         this.openButton.Click += new System.EventHandler(this.openButton_Click);
         // 
         // ReadSequentialAccessFileForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(419, 368);
         this.Controls.Add(this.nextButton);
         this.Controls.Add(this.openButton);
         this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Name = "ReadSequentialAccessFileForm";
         this.Text = "Reading a Sequential File";
         this.Controls.SetChildIndex(this.label1, 0);
         this.Controls.SetChildIndex(this.label2, 0);
         this.Controls.SetChildIndex(this.label3, 0);
         this.Controls.SetChildIndex(this.label4, 0);
         this.Controls.SetChildIndex(this.accountTextBox, 0);
         this.Controls.SetChildIndex(this.firstNameTextBox, 0);
         this.Controls.SetChildIndex(this.lastNameTextBox, 0);
         this.Controls.SetChildIndex(this.balanceTextBox, 0);
         this.Controls.SetChildIndex(this.openButton, 0);
         this.Controls.SetChildIndex(this.nextButton, 0);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button nextButton;
      private System.Windows.Forms.Button openButton;
   }
}