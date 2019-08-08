namespace FibonacciSynchronous
{
   partial class SynchronousTestForm
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
         this.label1 = new System.Windows.Forms.Label();
         this.outputTextBox = new System.Windows.Forms.TextBox();
         this.startButton = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(13, 13);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(248, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Sequential calls to Fibonacci(46) and Fibonacci(45)";
         // 
         // outputTextBox
         // 
         this.outputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.outputTextBox.Location = new System.Drawing.Point(13, 59);
         this.outputTextBox.Multiline = true;
         this.outputTextBox.Name = "outputTextBox";
         this.outputTextBox.Size = new System.Drawing.Size(250, 191);
         this.outputTextBox.TabIndex = 1;
         // 
         // startButton
         // 
         this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.startButton.Location = new System.Drawing.Point(12, 30);
         this.startButton.Name = "startButton";
         this.startButton.Size = new System.Drawing.Size(251, 23);
         this.startButton.TabIndex = 2;
         this.startButton.Text = "Start Sequential Fibonacci Calls";
         this.startButton.UseVisualStyleBackColor = true;
         this.startButton.Click += new System.EventHandler(this.startButton_Click);
         // 
         // SynchronousTestForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(275, 262);
         this.Controls.Add(this.startButton);
         this.Controls.Add(this.outputTextBox);
         this.Controls.Add(this.label1);
         this.Name = "SynchronousTestForm";
         this.Text = "Synchronous Test";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox outputTextBox;
      private System.Windows.Forms.Button startButton;
   }
}

