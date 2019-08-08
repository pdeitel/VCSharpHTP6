namespace FlickrViewer
{
   partial class FlickrViewerForm
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
         this.inputTextBox = new System.Windows.Forms.TextBox();
         this.pictureBox = new System.Windows.Forms.PictureBox();
         this.searchButton = new System.Windows.Forms.Button();
         this.imagesListBox = new System.Windows.Forms.ListBox();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 16);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(145, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Enter Flickr search tags here:";
         // 
         // inputTextBox
         // 
         this.inputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.inputTextBox.Location = new System.Drawing.Point(163, 13);
         this.inputTextBox.Name = "inputTextBox";
         this.inputTextBox.Size = new System.Drawing.Size(428, 20);
         this.inputTextBox.TabIndex = 1;
         // 
         // pictureBox
         // 
         this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.pictureBox.Location = new System.Drawing.Point(163, 40);
         this.pictureBox.Name = "pictureBox";
         this.pictureBox.Size = new System.Drawing.Size(503, 524);
         this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox.TabIndex = 3;
         this.pictureBox.TabStop = false;
         // 
         // searchButton
         // 
         this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.searchButton.Location = new System.Drawing.Point(597, 11);
         this.searchButton.Name = "searchButton";
         this.searchButton.Size = new System.Drawing.Size(70, 23);
         this.searchButton.TabIndex = 4;
         this.searchButton.Text = "Search";
         this.searchButton.UseVisualStyleBackColor = true;
         this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
         // 
         // imagesListBox
         // 
         this.imagesListBox.FormattingEnabled = true;
         this.imagesListBox.Location = new System.Drawing.Point(15, 40);
         this.imagesListBox.Name = "imagesListBox";
         this.imagesListBox.Size = new System.Drawing.Size(142, 524);
         this.imagesListBox.TabIndex = 5;
         this.imagesListBox.SelectedIndexChanged += new System.EventHandler(this.imagesListBox_SelectedIndexChanged);
         // 
         // FickrViewerForm
         // 
         this.AcceptButton = this.searchButton;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(679, 574);
         this.Controls.Add(this.imagesListBox);
         this.Controls.Add(this.searchButton);
         this.Controls.Add(this.pictureBox);
         this.Controls.Add(this.inputTextBox);
         this.Controls.Add(this.label1);
         this.Name = "FickrViewerForm";
         this.Text = "Flickr Viewer";
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox inputTextBox;
      private System.Windows.Forms.PictureBox pictureBox;
      private System.Windows.Forms.Button searchButton;
      private System.Windows.Forms.ListBox imagesListBox;
   }
}

