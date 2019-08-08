namespace UnicodeDemo
{
   partial class UnicodeForm
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
         this.chineseLabel = new System.Windows.Forms.Label();
         this.spanishLabel = new System.Windows.Forms.Label();
         this.russianLabel = new System.Windows.Forms.Label();
         this.portugueseLabel = new System.Windows.Forms.Label();
         this.japaneseLabel = new System.Windows.Forms.Label();
         this.germanLabel = new System.Windows.Forms.Label();
         this.frenchLabel = new System.Windows.Forms.Label();
         this.englishLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // chineseLabel
         // 
         this.chineseLabel.AutoSize = true;
         this.chineseLabel.Location = new System.Drawing.Point( 14, 192 );
         this.chineseLabel.Name = "chineseLabel";
         this.chineseLabel.Size = new System.Drawing.Size( 38, 15 );
         this.chineseLabel.TabIndex = 15;
         this.chineseLabel.Text = "label8";
         // 
         // spanishLabel
         // 
         this.spanishLabel.AutoSize = true;
         this.spanishLabel.Location = new System.Drawing.Point( 14, 166 );
         this.spanishLabel.Name = "spanishLabel";
         this.spanishLabel.Size = new System.Drawing.Size( 38, 15 );
         this.spanishLabel.TabIndex = 14;
         this.spanishLabel.Text = "label7";
         // 
         // russianLabel
         // 
         this.russianLabel.AutoSize = true;
         this.russianLabel.Location = new System.Drawing.Point( 14, 141 );
         this.russianLabel.Name = "russianLabel";
         this.russianLabel.Size = new System.Drawing.Size( 38, 15 );
         this.russianLabel.TabIndex = 13;
         this.russianLabel.Text = "label6";
         // 
         // portugueseLabel
         // 
         this.portugueseLabel.AutoSize = true;
         this.portugueseLabel.Location = new System.Drawing.Point( 14, 115 );
         this.portugueseLabel.Name = "portugueseLabel";
         this.portugueseLabel.Size = new System.Drawing.Size( 38, 15 );
         this.portugueseLabel.TabIndex = 12;
         this.portugueseLabel.Text = "label5";
         // 
         // japaneseLabel
         // 
         this.japaneseLabel.AutoSize = true;
         this.japaneseLabel.Location = new System.Drawing.Point( 14, 90 );
         this.japaneseLabel.Name = "japaneseLabel";
         this.japaneseLabel.Size = new System.Drawing.Size( 38, 15 );
         this.japaneseLabel.TabIndex = 11;
         this.japaneseLabel.Text = "label4";
         // 
         // germanLabel
         // 
         this.germanLabel.AutoSize = true;
         this.germanLabel.Location = new System.Drawing.Point( 14, 65 );
         this.germanLabel.Name = "germanLabel";
         this.germanLabel.Size = new System.Drawing.Size( 38, 15 );
         this.germanLabel.TabIndex = 10;
         this.germanLabel.Text = "label3";
         // 
         // frenchLabel
         // 
         this.frenchLabel.AutoSize = true;
         this.frenchLabel.Location = new System.Drawing.Point( 14, 39 );
         this.frenchLabel.Name = "frenchLabel";
         this.frenchLabel.Size = new System.Drawing.Size( 38, 15 );
         this.frenchLabel.TabIndex = 9;
         this.frenchLabel.Text = "label2";
         // 
         // englishLabel
         // 
         this.englishLabel.AutoSize = true;
         this.englishLabel.Location = new System.Drawing.Point( 14, 14 );
         this.englishLabel.Name = "englishLabel";
         this.englishLabel.Size = new System.Drawing.Size( 38, 15 );
         this.englishLabel.TabIndex = 8;
         this.englishLabel.Text = "label1";
         // 
         // UnicodeForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF( 7F, 15F );
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size( 350, 218 );
         this.Controls.Add( this.chineseLabel );
         this.Controls.Add( this.spanishLabel );
         this.Controls.Add( this.russianLabel );
         this.Controls.Add( this.portugueseLabel );
         this.Controls.Add( this.japaneseLabel );
         this.Controls.Add( this.germanLabel );
         this.Controls.Add( this.frenchLabel );
         this.Controls.Add( this.englishLabel );
         this.Font = new System.Drawing.Font( "Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.Name = "UnicodeForm";
         this.Text = "Demonstrating Unicode Encodings";
         this.Load += new System.EventHandler( this.UnicodeForm_Load );
         this.ResumeLayout( false );
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label chineseLabel;
      private System.Windows.Forms.Label spanishLabel;
      private System.Windows.Forms.Label russianLabel;
      private System.Windows.Forms.Label portugueseLabel;
      private System.Windows.Forms.Label japaneseLabel;
      private System.Windows.Forms.Label germanLabel;
      private System.Windows.Forms.Label frenchLabel;
      private System.Windows.Forms.Label englishLabel;
   }
}

