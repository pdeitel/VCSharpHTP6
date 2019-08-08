namespace TransformTest
{
   partial class TransformTestForm
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
         this.consoleTextBox = new System.Windows.Forms.TextBox();
         this.transformButton = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // consoleTextBox
         // 
         this.consoleTextBox.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                     | System.Windows.Forms.AnchorStyles.Left )
                     | System.Windows.Forms.AnchorStyles.Right ) ) );
         this.consoleTextBox.Location = new System.Drawing.Point( 12, 48 );
         this.consoleTextBox.Multiline = true;
         this.consoleTextBox.Name = "consoleTextBox";
         this.consoleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.consoleTextBox.Size = new System.Drawing.Size( 309, 206 );
         this.consoleTextBox.TabIndex = 3;
         // 
         // transformButton
         // 
         this.transformButton.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
                     | System.Windows.Forms.AnchorStyles.Right ) ) );
         this.transformButton.Location = new System.Drawing.Point( 12, 12 );
         this.transformButton.Name = "transformButton";
         this.transformButton.Size = new System.Drawing.Size( 309, 30 );
         this.transformButton.TabIndex = 2;
         this.transformButton.Text = "Transform XML";
         this.transformButton.UseVisualStyleBackColor = true;
         this.transformButton.Click += new System.EventHandler( this.transformButton_Click );
         // 
         // TransformTestForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size( 333, 266 );
         this.Controls.Add( this.consoleTextBox );
         this.Controls.Add( this.transformButton );
         this.Name = "TransformTestForm";
         this.Text = "Transform Test";
         this.Load += new System.EventHandler( this.TransformTestForm_Load );
         this.ResumeLayout( false );
         this.PerformLayout();

      }

      #endregion

      internal System.Windows.Forms.TextBox consoleTextBox;
      internal System.Windows.Forms.Button transformButton;
   }
}

