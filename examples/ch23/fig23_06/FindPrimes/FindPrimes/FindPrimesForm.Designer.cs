namespace FindPrimes
{
   partial class FindPrimesForm
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
         this.getPrimesButton = new System.Windows.Forms.Button();
         this.maxValueTextBox = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.primesTextBox = new System.Windows.Forms.TextBox();
         this.progressBar = new System.Windows.Forms.ProgressBar();
         this.cancelButton = new System.Windows.Forms.Button();
         this.statusLabel = new System.Windows.Forms.Label();
         this.percentageLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // getPrimesButton
         // 
         this.getPrimesButton.Location = new System.Drawing.Point(229, 13);
         this.getPrimesButton.Name = "getPrimesButton";
         this.getPrimesButton.Size = new System.Drawing.Size(75, 23);
         this.getPrimesButton.TabIndex = 0;
         this.getPrimesButton.Text = "Get Primes";
         this.getPrimesButton.UseVisualStyleBackColor = true;
         this.getPrimesButton.Click += new System.EventHandler(this.getPrimesButton_Click);
         // 
         // maxValueTextBox
         // 
         this.maxValueTextBox.Location = new System.Drawing.Point(123, 15);
         this.maxValueTextBox.Name = "maxValueTextBox";
         this.maxValueTextBox.Size = new System.Drawing.Size(100, 20);
         this.maxValueTextBox.TabIndex = 1;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 18);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(105, 13);
         this.label1.TabIndex = 2;
         this.label1.Text = "Find primes less than";
         // 
         // primesTextBox
         // 
         this.primesTextBox.Location = new System.Drawing.Point(12, 43);
         this.primesTextBox.Multiline = true;
         this.primesTextBox.Name = "primesTextBox";
         this.primesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.primesTextBox.Size = new System.Drawing.Size(291, 163);
         this.primesTextBox.TabIndex = 3;
         // 
         // progressBar
         // 
         this.progressBar.Location = new System.Drawing.Point(12, 213);
         this.progressBar.Name = "progressBar";
         this.progressBar.Size = new System.Drawing.Size(169, 23);
         this.progressBar.TabIndex = 4;
         // 
         // cancelButton
         // 
         this.cancelButton.Enabled = false;
         this.cancelButton.Location = new System.Drawing.Point(228, 213);
         this.cancelButton.Name = "cancelButton";
         this.cancelButton.Size = new System.Drawing.Size(75, 23);
         this.cancelButton.TabIndex = 6;
         this.cancelButton.Text = "Cancel";
         this.cancelButton.UseVisualStyleBackColor = true;
         this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
         // 
         // statusLabel
         // 
         this.statusLabel.Location = new System.Drawing.Point(12, 246);
         this.statusLabel.Name = "statusLabel";
         this.statusLabel.Size = new System.Drawing.Size(292, 13);
         this.statusLabel.TabIndex = 7;
         // 
         // percentageLabel
         // 
         this.percentageLabel.AutoSize = true;
         this.percentageLabel.Location = new System.Drawing.Point(187, 218);
         this.percentageLabel.Name = "percentageLabel";
         this.percentageLabel.Size = new System.Drawing.Size(21, 13);
         this.percentageLabel.TabIndex = 8;
         this.percentageLabel.Text = "0%";
         // 
         // FindPrimesForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(316, 272);
         this.Controls.Add(this.percentageLabel);
         this.Controls.Add(this.statusLabel);
         this.Controls.Add(this.cancelButton);
         this.Controls.Add(this.progressBar);
         this.Controls.Add(this.primesTextBox);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.maxValueTextBox);
         this.Controls.Add(this.getPrimesButton);
         this.Name = "FindPrimesForm";
         this.Text = "Finding Primes";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox maxValueTextBox;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.ProgressBar progressBar;
      private System.Windows.Forms.Button cancelButton;
      private System.Windows.Forms.TextBox primesTextBox;
      private System.Windows.Forms.Button getPrimesButton;
      private System.Windows.Forms.Label statusLabel;
      private System.Windows.Forms.Label percentageLabel;
   }
}

