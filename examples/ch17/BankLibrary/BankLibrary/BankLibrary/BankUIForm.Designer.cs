namespace BankLibrary
{
   partial class BankUIForm
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
         this.balanceTextBox = new System.Windows.Forms.TextBox();
         this.lastNameTextBox = new System.Windows.Forms.TextBox();
         this.firstNameTextBox = new System.Windows.Forms.TextBox();
         this.accountTextBox = new System.Windows.Forms.TextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // balanceTextBox
         // 
         this.balanceTextBox.Location = new System.Drawing.Point( 150, 190 );
         this.balanceTextBox.Name = "balanceTextBox";
         this.balanceTextBox.Size = new System.Drawing.Size( 153, 20 );
         this.balanceTextBox.TabIndex = 15;
         // 
         // lastNameTextBox
         // 
         this.lastNameTextBox.Location = new System.Drawing.Point( 150, 144 );
         this.lastNameTextBox.Name = "lastNameTextBox";
         this.lastNameTextBox.Size = new System.Drawing.Size( 153, 20 );
         this.lastNameTextBox.TabIndex = 14;
         // 
         // firstNameTextBox
         // 
         this.firstNameTextBox.Location = new System.Drawing.Point( 150, 97 );
         this.firstNameTextBox.Name = "firstNameTextBox";
         this.firstNameTextBox.Size = new System.Drawing.Size( 153, 20 );
         this.firstNameTextBox.TabIndex = 13;
         // 
         // accountTextBox
         // 
         this.accountTextBox.Location = new System.Drawing.Point( 150, 50 );
         this.accountTextBox.Name = "accountTextBox";
         this.accountTextBox.Size = new System.Drawing.Size( 153, 20 );
         this.accountTextBox.TabIndex = 12;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point( 50, 193 );
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size( 46, 13 );
         this.label4.TabIndex = 11;
         this.label4.Text = "Balance";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point( 50, 151 );
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size( 58, 13 );
         this.label3.TabIndex = 10;
         this.label3.Text = "Last Name";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point( 51, 104 );
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size( 57, 13 );
         this.label2.TabIndex = 9;
         this.label2.Text = "First Name";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point( 51, 59 );
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size( 47, 13 );
         this.label1.TabIndex = 8;
         this.label1.Text = "Account";
         // 
         // BankUIForm
         // 
         this.ClientSize = new System.Drawing.Size( 353, 261 );
         this.Controls.Add( this.balanceTextBox );
         this.Controls.Add( this.lastNameTextBox );
         this.Controls.Add( this.firstNameTextBox );
         this.Controls.Add( this.accountTextBox );
         this.Controls.Add( this.label4 );
         this.Controls.Add( this.label3 );
         this.Controls.Add( this.label2 );
         this.Controls.Add( this.label1 );
         this.Name = "BankUIForm";
         this.ResumeLayout( false );
         this.PerformLayout();

      }

      #endregion

      public System.Windows.Forms.TextBox balanceTextBox;
      public System.Windows.Forms.TextBox lastNameTextBox;
      public System.Windows.Forms.TextBox firstNameTextBox;
      public System.Windows.Forms.TextBox accountTextBox;
      public System.Windows.Forms.Label label4;
      public System.Windows.Forms.Label label3;
      public System.Windows.Forms.Label label2;
      public System.Windows.Forms.Label label1;
   }
}