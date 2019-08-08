namespace LINQToFileDirectory
{
   partial class LINQToFileDirectoryForm
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
         this.directoryLabel = new System.Windows.Forms.Label();
         this.directoryTextBox = new System.Windows.Forms.TextBox();
         this.resultsTextBox = new System.Windows.Forms.TextBox();
         this.searchButton = new System.Windows.Forms.Button();
         this.pathTextBox = new System.Windows.Forms.TextBox();
         this.instructionsLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // directoryLabel
         // 
         this.directoryLabel.AutoSize = true;
         this.directoryLabel.Location = new System.Drawing.Point(12, 88);
         this.directoryLabel.Name = "directoryLabel";
         this.directoryLabel.Size = new System.Drawing.Size(58, 15);
         this.directoryLabel.TabIndex = 5;
         this.directoryLabel.Text = "Directory:";
         // 
         // directoryTextBox
         // 
         this.directoryTextBox.Location = new System.Drawing.Point(76, 85);
         this.directoryTextBox.Name = "directoryTextBox";
         this.directoryTextBox.ReadOnly = true;
         this.directoryTextBox.Size = new System.Drawing.Size(228, 23);
         this.directoryTextBox.TabIndex = 2;
         // 
         // resultsTextBox
         // 
         this.resultsTextBox.Location = new System.Drawing.Point(12, 114);
         this.resultsTextBox.Multiline = true;
         this.resultsTextBox.Name = "resultsTextBox";
         this.resultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.resultsTextBox.Size = new System.Drawing.Size(292, 247);
         this.resultsTextBox.TabIndex = 3;
         // 
         // searchButton
         // 
         this.searchButton.Location = new System.Drawing.Point(178, 56);
         this.searchButton.Name = "searchButton";
         this.searchButton.Size = new System.Drawing.Size(126, 23);
         this.searchButton.TabIndex = 1;
         this.searchButton.Text = "Search Directory";
         this.searchButton.UseVisualStyleBackColor = true;
         this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
         // 
         // pathTextBox
         // 
         this.pathTextBox.Location = new System.Drawing.Point(12, 27);
         this.pathTextBox.Name = "pathTextBox";
         this.pathTextBox.Size = new System.Drawing.Size(292, 23);
         this.pathTextBox.TabIndex = 0;
         // 
         // instructionsLabel
         // 
         this.instructionsLabel.AutoSize = true;
         this.instructionsLabel.Location = new System.Drawing.Point(12, 9);
         this.instructionsLabel.Name = "instructionsLabel";
         this.instructionsLabel.Size = new System.Drawing.Size(115, 15);
         this.instructionsLabel.TabIndex = 4;
         this.instructionsLabel.Text = "Enter path to search:";
         // 
         // LINQToFileDirectoryForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(317, 374);
         this.Controls.Add(this.directoryLabel);
         this.Controls.Add(this.directoryTextBox);
         this.Controls.Add(this.resultsTextBox);
         this.Controls.Add(this.searchButton);
         this.Controls.Add(this.pathTextBox);
         this.Controls.Add(this.instructionsLabel);
         this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Name = "LINQToFileDirectoryForm";
         this.Text = "Search Directory";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      internal System.Windows.Forms.Label directoryLabel;
      internal System.Windows.Forms.TextBox directoryTextBox;
      internal System.Windows.Forms.TextBox resultsTextBox;
      internal System.Windows.Forms.Button searchButton;
      internal System.Windows.Forms.TextBox pathTextBox;
      internal System.Windows.Forms.Label instructionsLabel;
   }
}

