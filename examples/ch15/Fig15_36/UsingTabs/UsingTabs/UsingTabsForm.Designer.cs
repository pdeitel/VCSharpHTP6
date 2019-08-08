namespace UsingTabs
{
   partial class UsingTabsForm
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
         this.displayLabel = new System.Windows.Forms.Label();
         this.textOptionsTabControl = new System.Windows.Forms.TabControl();
         this.colorTabPage = new System.Windows.Forms.TabPage();
         this.greenRadioButton = new System.Windows.Forms.RadioButton();
         this.redRadioButton = new System.Windows.Forms.RadioButton();
         this.blackRadioButton = new System.Windows.Forms.RadioButton();
         this.sizeTabPage = new System.Windows.Forms.TabPage();
         this.size20RadioButton = new System.Windows.Forms.RadioButton();
         this.size16RadioButton = new System.Windows.Forms.RadioButton();
         this.size12RadioButton = new System.Windows.Forms.RadioButton();
         this.messageTabPage = new System.Windows.Forms.TabPage();
         this.aboutTabPage = new System.Windows.Forms.TabPage();
         this.messageLabel = new System.Windows.Forms.Label();
         this.goodbyeRadioButton = new System.Windows.Forms.RadioButton();
         this.helloRadioButton = new System.Windows.Forms.RadioButton();
         this.textOptionsTabControl.SuspendLayout();
         this.colorTabPage.SuspendLayout();
         this.sizeTabPage.SuspendLayout();
         this.messageTabPage.SuspendLayout();
         this.aboutTabPage.SuspendLayout();
         this.SuspendLayout();
         // 
         // displayLabel
         // 
         this.displayLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.displayLabel.Location = new System.Drawing.Point(12, 129);
         this.displayLabel.Name = "displayLabel";
         this.displayLabel.Size = new System.Drawing.Size(240, 42);
         this.displayLabel.TabIndex = 7;
         this.displayLabel.Text = "Hello!";
         this.displayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // textOptionsTabControl
         // 
         this.textOptionsTabControl.Controls.Add(this.colorTabPage);
         this.textOptionsTabControl.Controls.Add(this.sizeTabPage);
         this.textOptionsTabControl.Controls.Add(this.messageTabPage);
         this.textOptionsTabControl.Controls.Add(this.aboutTabPage);
         this.textOptionsTabControl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.textOptionsTabControl.Location = new System.Drawing.Point(12, 12);
         this.textOptionsTabControl.Name = "textOptionsTabControl";
         this.textOptionsTabControl.SelectedIndex = 0;
         this.textOptionsTabControl.Size = new System.Drawing.Size(240, 114);
         this.textOptionsTabControl.TabIndex = 6;
         // 
         // colorTabPage
         // 
         this.colorTabPage.Controls.Add(this.greenRadioButton);
         this.colorTabPage.Controls.Add(this.redRadioButton);
         this.colorTabPage.Controls.Add(this.blackRadioButton);
         this.colorTabPage.Location = new System.Drawing.Point(4, 24);
         this.colorTabPage.Name = "colorTabPage";
         this.colorTabPage.Padding = new System.Windows.Forms.Padding(3);
         this.colorTabPage.Size = new System.Drawing.Size(232, 86);
         this.colorTabPage.TabIndex = 0;
         this.colorTabPage.Text = "Color";
         // 
         // greenRadioButton
         // 
         this.greenRadioButton.AutoSize = true;
         this.greenRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.greenRadioButton.Location = new System.Drawing.Point(6, 56);
         this.greenRadioButton.Name = "greenRadioButton";
         this.greenRadioButton.Size = new System.Drawing.Size(56, 19);
         this.greenRadioButton.TabIndex = 2;
         this.greenRadioButton.Text = "Green";
         this.greenRadioButton.CheckedChanged += new System.EventHandler(this.greenRadioButton_CheckedChanged);
         // 
         // redRadioButton
         // 
         this.redRadioButton.AutoSize = true;
         this.redRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.redRadioButton.Location = new System.Drawing.Point(6, 31);
         this.redRadioButton.Name = "redRadioButton";
         this.redRadioButton.Size = new System.Drawing.Size(45, 19);
         this.redRadioButton.TabIndex = 1;
         this.redRadioButton.Text = "Red";
         this.redRadioButton.CheckedChanged += new System.EventHandler(this.redRadioButton_CheckedChanged);
         // 
         // blackRadioButton
         // 
         this.blackRadioButton.AutoSize = true;
         this.blackRadioButton.Checked = true;
         this.blackRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.blackRadioButton.Location = new System.Drawing.Point(6, 6);
         this.blackRadioButton.Name = "blackRadioButton";
         this.blackRadioButton.Size = new System.Drawing.Size(53, 19);
         this.blackRadioButton.TabIndex = 0;
         this.blackRadioButton.TabStop = true;
         this.blackRadioButton.Text = "Black";
         this.blackRadioButton.CheckedChanged += new System.EventHandler(this.blackRadioButton_CheckedChanged);
         // 
         // sizeTabPage
         // 
         this.sizeTabPage.Controls.Add(this.size20RadioButton);
         this.sizeTabPage.Controls.Add(this.size16RadioButton);
         this.sizeTabPage.Controls.Add(this.size12RadioButton);
         this.sizeTabPage.Location = new System.Drawing.Point(4, 24);
         this.sizeTabPage.Name = "sizeTabPage";
         this.sizeTabPage.Padding = new System.Windows.Forms.Padding(3);
         this.sizeTabPage.Size = new System.Drawing.Size(232, 86);
         this.sizeTabPage.TabIndex = 1;
         this.sizeTabPage.Text = "Size";
         // 
         // size20RadioButton
         // 
         this.size20RadioButton.AutoSize = true;
         this.size20RadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.size20RadioButton.Location = new System.Drawing.Point(6, 56);
         this.size20RadioButton.Name = "size20RadioButton";
         this.size20RadioButton.Size = new System.Drawing.Size(68, 19);
         this.size20RadioButton.TabIndex = 2;
         this.size20RadioButton.Text = "20 point";
         this.size20RadioButton.CheckedChanged += new System.EventHandler(this.size20RadioButton_CheckedChanged);
         // 
         // size16RadioButton
         // 
         this.size16RadioButton.AutoSize = true;
         this.size16RadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.size16RadioButton.Location = new System.Drawing.Point(6, 31);
         this.size16RadioButton.Name = "size16RadioButton";
         this.size16RadioButton.Size = new System.Drawing.Size(68, 19);
         this.size16RadioButton.TabIndex = 1;
         this.size16RadioButton.Text = "16 point";
         this.size16RadioButton.CheckedChanged += new System.EventHandler(this.size16RadioButton_CheckedChanged);
         // 
         // size12RadioButton
         // 
         this.size12RadioButton.AutoSize = true;
         this.size12RadioButton.Checked = true;
         this.size12RadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.size12RadioButton.Location = new System.Drawing.Point(6, 6);
         this.size12RadioButton.Name = "size12RadioButton";
         this.size12RadioButton.Size = new System.Drawing.Size(68, 19);
         this.size12RadioButton.TabIndex = 0;
         this.size12RadioButton.TabStop = true;
         this.size12RadioButton.Text = "12 point";
         this.size12RadioButton.CheckedChanged += new System.EventHandler(this.size12RadioButton_CheckedChanged);
         // 
         // messageTabPage
         // 
         this.messageTabPage.Controls.Add(this.goodbyeRadioButton);
         this.messageTabPage.Controls.Add(this.helloRadioButton);
         this.messageTabPage.Location = new System.Drawing.Point(4, 24);
         this.messageTabPage.Name = "messageTabPage";
         this.messageTabPage.Size = new System.Drawing.Size(232, 86);
         this.messageTabPage.TabIndex = 2;
         this.messageTabPage.Text = "Message";
         // 
         // aboutTabPage
         // 
         this.aboutTabPage.Controls.Add(this.messageLabel);
         this.aboutTabPage.Location = new System.Drawing.Point(4, 24);
         this.aboutTabPage.Name = "aboutTabPage";
         this.aboutTabPage.Size = new System.Drawing.Size(232, 86);
         this.aboutTabPage.TabIndex = 3;
         this.aboutTabPage.Text = "About";
         // 
         // messageLabel
         // 
         this.messageLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.messageLabel.Location = new System.Drawing.Point(6, 6);
         this.messageLabel.Name = "messageLabel";
         this.messageLabel.Size = new System.Drawing.Size(227, 46);
         this.messageLabel.TabIndex = 0;
         this.messageLabel.Text = "Tabs are used to organize controls and conserve screen space.";
         // 
         // goodbyeRadioButton
         // 
         this.goodbyeRadioButton.AutoSize = true;
         this.goodbyeRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.goodbyeRadioButton.Location = new System.Drawing.Point(6, 31);
         this.goodbyeRadioButton.Name = "goodbyeRadioButton";
         this.goodbyeRadioButton.Size = new System.Drawing.Size(76, 19);
         this.goodbyeRadioButton.TabIndex = 3;
         this.goodbyeRadioButton.Text = "Goodbye!";
         this.goodbyeRadioButton.CheckedChanged += new System.EventHandler(this.goodbyeRadioButton_CheckedChanged);
         // 
         // helloRadioButton
         // 
         this.helloRadioButton.AutoSize = true;
         this.helloRadioButton.Checked = true;
         this.helloRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.helloRadioButton.Location = new System.Drawing.Point(6, 6);
         this.helloRadioButton.Name = "helloRadioButton";
         this.helloRadioButton.Size = new System.Drawing.Size(56, 19);
         this.helloRadioButton.TabIndex = 2;
         this.helloRadioButton.TabStop = true;
         this.helloRadioButton.Text = "Hello!";
         this.helloRadioButton.CheckedChanged += new System.EventHandler(this.helloRadioButton_CheckedChanged);
         // 
         // UsingTabsForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(264, 182);
         this.Controls.Add(this.displayLabel);
         this.Controls.Add(this.textOptionsTabControl);
         this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Name = "UsingTabsForm";
         this.Text = "Using Tabs";
         this.textOptionsTabControl.ResumeLayout(false);
         this.colorTabPage.ResumeLayout(false);
         this.colorTabPage.PerformLayout();
         this.sizeTabPage.ResumeLayout(false);
         this.sizeTabPage.PerformLayout();
         this.messageTabPage.ResumeLayout(false);
         this.messageTabPage.PerformLayout();
         this.aboutTabPage.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      internal System.Windows.Forms.Label displayLabel;
      internal System.Windows.Forms.TabControl textOptionsTabControl;
      internal System.Windows.Forms.TabPage colorTabPage;
      internal System.Windows.Forms.RadioButton greenRadioButton;
      internal System.Windows.Forms.RadioButton redRadioButton;
      internal System.Windows.Forms.RadioButton blackRadioButton;
      internal System.Windows.Forms.TabPage sizeTabPage;
      internal System.Windows.Forms.RadioButton size20RadioButton;
      internal System.Windows.Forms.RadioButton size16RadioButton;
      internal System.Windows.Forms.RadioButton size12RadioButton;
      internal System.Windows.Forms.TabPage messageTabPage;
      internal System.Windows.Forms.TabPage aboutTabPage;
      internal System.Windows.Forms.Label messageLabel;
      internal System.Windows.Forms.RadioButton goodbyeRadioButton;
      internal System.Windows.Forms.RadioButton helloRadioButton;

   }
}

/**************************************************************************
 * (C) Copyright 1992-2017 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/
