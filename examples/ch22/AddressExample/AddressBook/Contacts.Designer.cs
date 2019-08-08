namespace AddressBook
{
   partial class Contacts
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
         this.components = new System.ComponentModel.Container();
         System.Windows.Forms.Label addressIDLabel;
         System.Windows.Forms.Label emailLabel;
         System.Windows.Forms.Label firstNameLabel;
         System.Windows.Forms.Label lastNameLabel;
         System.Windows.Forms.Label phoneNumberLabel;
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contacts));
         this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.addressBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
         this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
         this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
         this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
         this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
         this.addressBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
         this.addressIDTextBox = new System.Windows.Forms.TextBox();
         this.emailTextBox = new System.Windows.Forms.TextBox();
         this.firstNameTextBox = new System.Windows.Forms.TextBox();
         this.lastNameTextBox = new System.Windows.Forms.TextBox();
         this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
         this.findGroupBox = new System.Windows.Forms.GroupBox();
         this.findButton = new System.Windows.Forms.Button();
         this.findTextBox = new System.Windows.Forms.TextBox();
         this.findLabel = new System.Windows.Forms.Label();
         this.browseAllButton = new System.Windows.Forms.Button();
         addressIDLabel = new System.Windows.Forms.Label();
         emailLabel = new System.Windows.Forms.Label();
         firstNameLabel = new System.Windows.Forms.Label();
         lastNameLabel = new System.Windows.Forms.Label();
         phoneNumberLabel = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.addressBindingNavigator)).BeginInit();
         this.addressBindingNavigator.SuspendLayout();
         this.findGroupBox.SuspendLayout();
         this.SuspendLayout();
         // 
         // addressIDLabel
         // 
         addressIDLabel.AutoSize = true;
         addressIDLabel.Location = new System.Drawing.Point(12, 37);
         addressIDLabel.Name = "addressIDLabel";
         addressIDLabel.Size = new System.Drawing.Size(62, 13);
         addressIDLabel.TabIndex = 1;
         addressIDLabel.Text = "Address ID:";
         // 
         // emailLabel
         // 
         emailLabel.AutoSize = true;
         emailLabel.Location = new System.Drawing.Point(12, 115);
         emailLabel.Name = "emailLabel";
         emailLabel.Size = new System.Drawing.Size(35, 13);
         emailLabel.TabIndex = 3;
         emailLabel.Text = "Email:";
         // 
         // firstNameLabel
         // 
         firstNameLabel.AutoSize = true;
         firstNameLabel.Location = new System.Drawing.Point(12, 63);
         firstNameLabel.Name = "firstNameLabel";
         firstNameLabel.Size = new System.Drawing.Size(60, 13);
         firstNameLabel.TabIndex = 5;
         firstNameLabel.Text = "First Name:";
         // 
         // lastNameLabel
         // 
         lastNameLabel.AutoSize = true;
         lastNameLabel.Location = new System.Drawing.Point(12, 89);
         lastNameLabel.Name = "lastNameLabel";
         lastNameLabel.Size = new System.Drawing.Size(61, 13);
         lastNameLabel.TabIndex = 7;
         lastNameLabel.Text = "Last Name:";
         // 
         // phoneNumberLabel
         // 
         phoneNumberLabel.AutoSize = true;
         phoneNumberLabel.Location = new System.Drawing.Point(12, 141);
         phoneNumberLabel.Name = "phoneNumberLabel";
         phoneNumberLabel.Size = new System.Drawing.Size(81, 13);
         phoneNumberLabel.TabIndex = 9;
         phoneNumberLabel.Text = "Phone Number:";
         // 
         // addressBindingSource
         // 
         this.addressBindingSource.DataSource = typeof(AddressExample.Address);
         // 
         // addressBindingNavigator
         // 
         this.addressBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
         this.addressBindingNavigator.BindingSource = this.addressBindingSource;
         this.addressBindingNavigator.CountItem = this.bindingNavigatorCountItem;
         this.addressBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
         this.addressBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.addressBindingNavigatorSaveItem});
         this.addressBindingNavigator.Location = new System.Drawing.Point(0, 0);
         this.addressBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
         this.addressBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
         this.addressBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
         this.addressBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
         this.addressBindingNavigator.Name = "addressBindingNavigator";
         this.addressBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
         this.addressBindingNavigator.Size = new System.Drawing.Size(286, 25);
         this.addressBindingNavigator.TabIndex = 5;
         this.addressBindingNavigator.Text = "bindingNavigator1";
         // 
         // bindingNavigatorAddNewItem
         // 
         this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
         this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
         this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorAddNewItem.Text = "Add new";
         // 
         // bindingNavigatorCountItem
         // 
         this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
         this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
         this.bindingNavigatorCountItem.Text = "of {0}";
         this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
         // 
         // bindingNavigatorDeleteItem
         // 
         this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
         this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
         this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorDeleteItem.Text = "Delete";
         // 
         // bindingNavigatorMoveFirstItem
         // 
         this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
         this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
         this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorMoveFirstItem.Text = "Move first";
         // 
         // bindingNavigatorMovePreviousItem
         // 
         this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
         this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
         this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorMovePreviousItem.Text = "Move previous";
         // 
         // bindingNavigatorSeparator
         // 
         this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
         this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
         // 
         // bindingNavigatorPositionItem
         // 
         this.bindingNavigatorPositionItem.AccessibleName = "Position";
         this.bindingNavigatorPositionItem.AutoSize = false;
         this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
         this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
         this.bindingNavigatorPositionItem.Text = "0";
         this.bindingNavigatorPositionItem.ToolTipText = "Current position";
         // 
         // bindingNavigatorSeparator1
         // 
         this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
         this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
         // 
         // bindingNavigatorMoveNextItem
         // 
         this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
         this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
         this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorMoveNextItem.Text = "Move next";
         // 
         // bindingNavigatorMoveLastItem
         // 
         this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
         this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
         this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorMoveLastItem.Text = "Move last";
         // 
         // bindingNavigatorSeparator2
         // 
         this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
         this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
         // 
         // addressBindingNavigatorSaveItem
         // 
         this.addressBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.addressBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("addressBindingNavigatorSaveItem.Image")));
         this.addressBindingNavigatorSaveItem.Name = "addressBindingNavigatorSaveItem";
         this.addressBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
         this.addressBindingNavigatorSaveItem.Text = "Save Data";
         this.addressBindingNavigatorSaveItem.Click += new System.EventHandler(this.addressBindingNavigatorSaveItem_Click);
         // 
         // addressIDTextBox
         // 
         this.addressIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "AddressID", true));
         this.addressIDTextBox.Location = new System.Drawing.Point(99, 34);
         this.addressIDTextBox.Name = "addressIDTextBox";
         this.addressIDTextBox.ReadOnly = true;
         this.addressIDTextBox.Size = new System.Drawing.Size(169, 20);
         this.addressIDTextBox.TabIndex = 0;
         // 
         // emailTextBox
         // 
         this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "Email", true));
         this.emailTextBox.Location = new System.Drawing.Point(99, 112);
         this.emailTextBox.Name = "emailTextBox";
         this.emailTextBox.Size = new System.Drawing.Size(169, 20);
         this.emailTextBox.TabIndex = 2;
         // 
         // firstNameTextBox
         // 
         this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "FirstName", true));
         this.firstNameTextBox.Location = new System.Drawing.Point(99, 60);
         this.firstNameTextBox.Name = "firstNameTextBox";
         this.firstNameTextBox.Size = new System.Drawing.Size(169, 20);
         this.firstNameTextBox.TabIndex = 0;
         // 
         // lastNameTextBox
         // 
         this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "LastName", true));
         this.lastNameTextBox.Location = new System.Drawing.Point(99, 86);
         this.lastNameTextBox.Name = "lastNameTextBox";
         this.lastNameTextBox.Size = new System.Drawing.Size(169, 20);
         this.lastNameTextBox.TabIndex = 1;
         // 
         // phoneNumberTextBox
         // 
         this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "PhoneNumber", true));
         this.phoneNumberTextBox.Location = new System.Drawing.Point(99, 138);
         this.phoneNumberTextBox.Name = "phoneNumberTextBox";
         this.phoneNumberTextBox.Size = new System.Drawing.Size(169, 20);
         this.phoneNumberTextBox.TabIndex = 3;
         // 
         // findGroupBox
         // 
         this.findGroupBox.Controls.Add(this.findButton);
         this.findGroupBox.Controls.Add(this.findTextBox);
         this.findGroupBox.Controls.Add(this.findLabel);
         this.findGroupBox.Location = new System.Drawing.Point(12, 164);
         this.findGroupBox.Name = "findGroupBox";
         this.findGroupBox.Size = new System.Drawing.Size(262, 52);
         this.findGroupBox.TabIndex = 10;
         this.findGroupBox.TabStop = false;
         this.findGroupBox.Text = "Find an entry by last name";
         // 
         // findButton
         // 
         this.findButton.Location = new System.Drawing.Point(180, 18);
         this.findButton.Name = "findButton";
         this.findButton.Size = new System.Drawing.Size(76, 23);
         this.findButton.TabIndex = 1;
         this.findButton.Text = "Find";
         this.findButton.UseVisualStyleBackColor = true;
         this.findButton.Click += new System.EventHandler(this.findButton_Click);
         // 
         // findTextBox
         // 
         this.findTextBox.Location = new System.Drawing.Point(74, 20);
         this.findTextBox.Name = "findTextBox";
         this.findTextBox.Size = new System.Drawing.Size(100, 20);
         this.findTextBox.TabIndex = 0;
         // 
         // findLabel
         // 
         this.findLabel.AutoSize = true;
         this.findLabel.Location = new System.Drawing.Point(7, 23);
         this.findLabel.Name = "findLabel";
         this.findLabel.Size = new System.Drawing.Size(61, 13);
         this.findLabel.TabIndex = 0;
         this.findLabel.Text = "Last Name:";
         // 
         // browseAllButton
         // 
         this.browseAllButton.Location = new System.Drawing.Point(12, 223);
         this.browseAllButton.Name = "browseAllButton";
         this.browseAllButton.Size = new System.Drawing.Size(262, 23);
         this.browseAllButton.TabIndex = 4;
         this.browseAllButton.Text = "Browse All Entries";
         this.browseAllButton.UseVisualStyleBackColor = true;
         this.browseAllButton.Click += new System.EventHandler(this.browseAllButton_Click);
         // 
         // Contacts
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(286, 258);
         this.Controls.Add(this.browseAllButton);
         this.Controls.Add(this.findGroupBox);
         this.Controls.Add(addressIDLabel);
         this.Controls.Add(this.addressIDTextBox);
         this.Controls.Add(emailLabel);
         this.Controls.Add(this.emailTextBox);
         this.Controls.Add(firstNameLabel);
         this.Controls.Add(this.firstNameTextBox);
         this.Controls.Add(lastNameLabel);
         this.Controls.Add(this.lastNameTextBox);
         this.Controls.Add(phoneNumberLabel);
         this.Controls.Add(this.phoneNumberTextBox);
         this.Controls.Add(this.addressBindingNavigator);
         this.Name = "Contacts";
         this.Text = "Address Book";
         this.Load += new System.EventHandler(this.Contacts_Load);
         ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.addressBindingNavigator)).EndInit();
         this.addressBindingNavigator.ResumeLayout(false);
         this.addressBindingNavigator.PerformLayout();
         this.findGroupBox.ResumeLayout(false);
         this.findGroupBox.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.BindingSource addressBindingSource;
      private System.Windows.Forms.BindingNavigator addressBindingNavigator;
      private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
      private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
      private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
      private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
      private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
      private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
      private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
      private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
      private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
      private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
      private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
      private System.Windows.Forms.ToolStripButton addressBindingNavigatorSaveItem;
      private System.Windows.Forms.TextBox addressIDTextBox;
      private System.Windows.Forms.TextBox emailTextBox;
      private System.Windows.Forms.TextBox firstNameTextBox;
      private System.Windows.Forms.TextBox lastNameTextBox;
      private System.Windows.Forms.TextBox phoneNumberTextBox;
      private System.Windows.Forms.GroupBox findGroupBox;
      private System.Windows.Forms.Button findButton;
      private System.Windows.Forms.TextBox findTextBox;
      private System.Windows.Forms.Label findLabel;
      private System.Windows.Forms.Button browseAllButton;
   }
}

