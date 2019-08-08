namespace CreditInquiry
{
   partial class CreditInquiryForm
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
         this.zeroButton = new System.Windows.Forms.Button();
         this.doneButton = new System.Windows.Forms.Button();
         this.debitButton = new System.Windows.Forms.Button();
         this.creditButton = new System.Windows.Forms.Button();
         this.openButton = new System.Windows.Forms.Button();
         this.displayTextBox = new System.Windows.Forms.RichTextBox();
         this.SuspendLayout();
         // 
         // zeroButton
         // 
         this.zeroButton.Enabled = false;
         this.zeroButton.Location = new System.Drawing.Point( 364, 161 );
         this.zeroButton.Name = "zeroButton";
         this.zeroButton.Size = new System.Drawing.Size( 93, 31 );
         this.zeroButton.TabIndex = 11;
         this.zeroButton.Text = "Zero Balances";
         this.zeroButton.Click += new System.EventHandler( this.getBalances_Click );
         // 
         // doneButton
         // 
         this.doneButton.Location = new System.Drawing.Point( 476, 161 );
         this.doneButton.Name = "doneButton";
         this.doneButton.Size = new System.Drawing.Size( 93, 31 );
         this.doneButton.TabIndex = 10;
         this.doneButton.Text = "Done";
         this.doneButton.Click += new System.EventHandler( this.doneButton_Click );
         // 
         // debitButton
         // 
         this.debitButton.Enabled = false;
         this.debitButton.Location = new System.Drawing.Point( 249, 161 );
         this.debitButton.Name = "debitButton";
         this.debitButton.Size = new System.Drawing.Size( 93, 31 );
         this.debitButton.TabIndex = 9;
         this.debitButton.Text = "Debit Balances";
         this.debitButton.Click += new System.EventHandler( this.getBalances_Click );
         // 
         // creditButton
         // 
         this.creditButton.Enabled = false;
         this.creditButton.Location = new System.Drawing.Point( 134, 161 );
         this.creditButton.Name = "creditButton";
         this.creditButton.Size = new System.Drawing.Size( 97, 31 );
         this.creditButton.TabIndex = 8;
         this.creditButton.Text = "Credit Balances";
         this.creditButton.Click += new System.EventHandler( this.getBalances_Click );
         // 
         // openButton
         // 
         this.openButton.Location = new System.Drawing.Point( 12, 161 );
         this.openButton.Name = "openButton";
         this.openButton.Size = new System.Drawing.Size( 104, 31 );
         this.openButton.TabIndex = 7;
         this.openButton.Text = "Open File";
         this.openButton.Click += new System.EventHandler( this.openButton_Click );
         // 
         // displayTextBox
         // 
         this.displayTextBox.Location = new System.Drawing.Point( 12, 16 );
         this.displayTextBox.Name = "displayTextBox";
         this.displayTextBox.Size = new System.Drawing.Size( 557, 120 );
         this.displayTextBox.TabIndex = 6;
         this.displayTextBox.Text = "";
         // 
         // CreditInquiryForm
         // 
         this.ClientSize = new System.Drawing.Size( 581, 209 );
         this.Controls.Add( this.zeroButton );
         this.Controls.Add( this.doneButton );
         this.Controls.Add( this.debitButton );
         this.Controls.Add( this.creditButton );
         this.Controls.Add( this.openButton );
         this.Controls.Add( this.displayTextBox );
         this.Font = new System.Drawing.Font( "Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.Name = "CreditInquiryForm";
         this.Text = "Credit Inquiry";
         this.ResumeLayout( false );

      }

      #endregion

      private System.Windows.Forms.Button zeroButton;
      private System.Windows.Forms.Button doneButton;
      private System.Windows.Forms.Button debitButton;
      private System.Windows.Forms.Button creditButton;
      private System.Windows.Forms.Button openButton;
      private System.Windows.Forms.RichTextBox displayTextBox;
   }
}