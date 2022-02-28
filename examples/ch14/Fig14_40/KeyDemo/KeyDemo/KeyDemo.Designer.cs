namespace KeyDemo
{
   partial class KeyDemo
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
         this.keyInfoLabel = new System.Windows.Forms.Label();
         this.charLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // keyInfoLabel
         // 
         this.keyInfoLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.keyInfoLabel.Location = new System.Drawing.Point(12, 46);
         this.keyInfoLabel.Name = "keyInfoLabel";
         this.keyInfoLabel.Size = new System.Drawing.Size(168, 151);
         this.keyInfoLabel.TabIndex = 9;
         this.keyInfoLabel.Text = "A Key...";
         // 
         // charLabel
         // 
         this.charLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.charLabel.Location = new System.Drawing.Point(12, 9);
         this.charLabel.Name = "charLabel";
         this.charLabel.Size = new System.Drawing.Size(168, 20);
         this.charLabel.TabIndex = 8;
         this.charLabel.Text = "Just Press";
         // 
         // KeyDemo
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(229, 210);
         this.Controls.Add(this.keyInfoLabel);
         this.Controls.Add(this.charLabel);
         this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Name = "KeyDemo";
         this.Text = "Key Demo";
         this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDemo_KeyDown);
         this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyDemo_KeyPress);
         this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyDemo_KeyUp);
         this.ResumeLayout(false);

      }

      #endregion

      internal System.Windows.Forms.Label keyInfoLabel;
      internal System.Windows.Forms.Label charLabel;
   }
}

