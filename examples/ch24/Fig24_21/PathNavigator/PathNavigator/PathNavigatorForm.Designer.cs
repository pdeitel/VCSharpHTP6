namespace PathNavigator
{
   partial class PathNavigatorForm
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
         this.pathTreeView = new System.Windows.Forms.TreeView();
         this.locateGroupBox = new System.Windows.Forms.GroupBox();
         this.locateTextBox = new System.Windows.Forms.TextBox();
         this.locateComboBox = new System.Windows.Forms.ComboBox();
         this.navigateGroupBox = new System.Windows.Forms.GroupBox();
         this.nextButton = new System.Windows.Forms.Button();
         this.firstChildButton = new System.Windows.Forms.Button();
         this.parentButton = new System.Windows.Forms.Button();
         this.previousButton = new System.Windows.Forms.Button();
         this.locateGroupBox.SuspendLayout();
         this.navigateGroupBox.SuspendLayout();
         this.SuspendLayout();
         // 
         // pathTreeView
         // 
         this.pathTreeView.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                     | System.Windows.Forms.AnchorStyles.Left )
                     | System.Windows.Forms.AnchorStyles.Right ) ) );
         this.pathTreeView.FullRowSelect = true;
         this.pathTreeView.HideSelection = false;
         this.pathTreeView.Location = new System.Drawing.Point( 12, 312 );
         this.pathTreeView.Name = "pathTreeView";
         this.pathTreeView.Size = new System.Drawing.Size( 338, 131 );
         this.pathTreeView.TabIndex = 14;
         // 
         // locateGroupBox
         // 
         this.locateGroupBox.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
                     | System.Windows.Forms.AnchorStyles.Right ) ) );
         this.locateGroupBox.Controls.Add( this.locateTextBox );
         this.locateGroupBox.Controls.Add( this.locateComboBox );
         this.locateGroupBox.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F );
         this.locateGroupBox.Location = new System.Drawing.Point( 13, 12 );
         this.locateGroupBox.Name = "locateGroupBox";
         this.locateGroupBox.Size = new System.Drawing.Size( 336, 158 );
         this.locateGroupBox.TabIndex = 12;
         this.locateGroupBox.TabStop = false;
         this.locateGroupBox.Text = "Locate Element";
         // 
         // locateTextBox
         // 
         this.locateTextBox.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
                     | System.Windows.Forms.AnchorStyles.Right ) ) );
         this.locateTextBox.BackColor = System.Drawing.SystemColors.Info;
         this.locateTextBox.Location = new System.Drawing.Point( 6, 52 );
         this.locateTextBox.Multiline = true;
         this.locateTextBox.Name = "locateTextBox";
         this.locateTextBox.ReadOnly = true;
         this.locateTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this.locateTextBox.Size = new System.Drawing.Size( 324, 100 );
         this.locateTextBox.TabIndex = 2;
         this.locateTextBox.WordWrap = false;
         // 
         // locateComboBox
         // 
         this.locateComboBox.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
                     | System.Windows.Forms.AnchorStyles.Right ) ) );
         this.locateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.locateComboBox.FormattingEnabled = true;
         this.locateComboBox.Items.AddRange( new object[] {
            "/sports",
            "//game",
            "//name",
            "//paragraph",
            "//game[name=\'Cricket\']",
            "//game/@id"} );
         this.locateComboBox.Location = new System.Drawing.Point( 6, 21 );
         this.locateComboBox.Name = "locateComboBox";
         this.locateComboBox.Size = new System.Drawing.Size( 324, 24 );
         this.locateComboBox.TabIndex = 1;
         this.locateComboBox.SelectedIndexChanged += new System.EventHandler( this.locateComboBox_SelectedIndexChanged );
         // 
         // navigateGroupBox
         // 
         this.navigateGroupBox.Controls.Add( this.nextButton );
         this.navigateGroupBox.Controls.Add( this.firstChildButton );
         this.navigateGroupBox.Controls.Add( this.parentButton );
         this.navigateGroupBox.Controls.Add( this.previousButton );
         this.navigateGroupBox.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F );
         this.navigateGroupBox.Location = new System.Drawing.Point( 65, 176 );
         this.navigateGroupBox.Name = "navigateGroupBox";
         this.navigateGroupBox.Size = new System.Drawing.Size( 232, 130 );
         this.navigateGroupBox.TabIndex = 13;
         this.navigateGroupBox.TabStop = false;
         this.navigateGroupBox.Text = "Navigation Controls";
         // 
         // nextButton
         // 
         this.nextButton.Location = new System.Drawing.Point( 66, 94 );
         this.nextButton.Name = "nextButton";
         this.nextButton.Size = new System.Drawing.Size( 100, 30 );
         this.nextButton.TabIndex = 2;
         this.nextButton.Text = "Next";
         this.nextButton.Click += new System.EventHandler( this.nextButton_Click );
         // 
         // firstChildButton
         // 
         this.firstChildButton.Location = new System.Drawing.Point( 122, 59 );
         this.firstChildButton.Name = "firstChildButton";
         this.firstChildButton.Size = new System.Drawing.Size( 100, 30 );
         this.firstChildButton.TabIndex = 1;
         this.firstChildButton.Text = "First Child";
         this.firstChildButton.Click += new System.EventHandler( this.firstChildButton_Click );
         // 
         // parentButton
         // 
         this.parentButton.Location = new System.Drawing.Point( 7, 59 );
         this.parentButton.Name = "parentButton";
         this.parentButton.Size = new System.Drawing.Size( 100, 30 );
         this.parentButton.TabIndex = 2;
         this.parentButton.Text = "Parent";
         this.parentButton.Click += new System.EventHandler( this.parentButton_Click );
         // 
         // previousButton
         // 
         this.previousButton.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F );
         this.previousButton.Location = new System.Drawing.Point( 66, 22 );
         this.previousButton.Name = "previousButton";
         this.previousButton.Size = new System.Drawing.Size( 100, 30 );
         this.previousButton.TabIndex = 0;
         this.previousButton.Text = "Previous";
         this.previousButton.Click += new System.EventHandler( this.previousButton_Click );
         // 
         // PathNavigatorForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size( 362, 454 );
         this.Controls.Add( this.pathTreeView );
         this.Controls.Add( this.locateGroupBox );
         this.Controls.Add( this.navigateGroupBox );
         this.Name = "PathNavigatorForm";
         this.Text = "Path Navigator";
         this.Load += new System.EventHandler( this.PathNavigatorForm_Load );
         this.locateGroupBox.ResumeLayout( false );
         this.locateGroupBox.PerformLayout();
         this.navigateGroupBox.ResumeLayout( false );
         this.ResumeLayout( false );

      }

      #endregion

      private System.Windows.Forms.TreeView pathTreeView;
      private System.Windows.Forms.GroupBox locateGroupBox;
      private System.Windows.Forms.TextBox locateTextBox;
      private System.Windows.Forms.ComboBox locateComboBox;
      private System.Windows.Forms.GroupBox navigateGroupBox;
      private System.Windows.Forms.Button nextButton;
      private System.Windows.Forms.Button firstChildButton;
      private System.Windows.Forms.Button parentButton;
      private System.Windows.Forms.Button previousButton;
   }
}

