namespace MasterDetail
{
   partial class Details
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Details));
         System.Windows.Forms.Label authorIDLabel;
         System.Windows.Forms.Label firstNameLabel;
         System.Windows.Forms.Label lastNameLabel;
         this.authorBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.authorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
         this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
         this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
         this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
         this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
         this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
         this.authorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
         this.authorIDTextBox = new System.Windows.Forms.TextBox();
         this.firstNameTextBox = new System.Windows.Forms.TextBox();
         this.lastNameTextBox = new System.Windows.Forms.TextBox();
         this.titlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.titlesDataGridView = new System.Windows.Forms.DataGridView();
         this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         authorIDLabel = new System.Windows.Forms.Label();
         firstNameLabel = new System.Windows.Forms.Label();
         lastNameLabel = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.authorBindingNavigator)).BeginInit();
         this.authorBindingNavigator.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.titlesBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.titlesDataGridView)).BeginInit();
         this.SuspendLayout();
         // 
         // authorBindingSource
         // 
         this.authorBindingSource.DataSource = typeof(BooksExamples.Author);
         // 
         // authorBindingNavigator
         // 
         this.authorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
         this.authorBindingNavigator.BindingSource = this.authorBindingSource;
         this.authorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
         this.authorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
         this.authorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.authorBindingNavigatorSaveItem});
         this.authorBindingNavigator.Location = new System.Drawing.Point(0, 0);
         this.authorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
         this.authorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
         this.authorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
         this.authorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
         this.authorBindingNavigator.Name = "authorBindingNavigator";
         this.authorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
         this.authorBindingNavigator.Size = new System.Drawing.Size(534, 25);
         this.authorBindingNavigator.TabIndex = 0;
         this.authorBindingNavigator.Text = "bindingNavigator1";
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
         // bindingNavigatorCountItem
         // 
         this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
         this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
         this.bindingNavigatorCountItem.Text = "of {0}";
         this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
         // 
         // bindingNavigatorSeparator1
         // 
         this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
         this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
         this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
         // 
         // bindingNavigatorAddNewItem
         // 
         this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorAddNewItem.Enabled = false;
         this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
         this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
         this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorAddNewItem.Text = "Add new";
         // 
         // bindingNavigatorDeleteItem
         // 
         this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorDeleteItem.Enabled = false;
         this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
         this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
         this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorDeleteItem.Text = "Delete";
         // 
         // authorBindingNavigatorSaveItem
         // 
         this.authorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.authorBindingNavigatorSaveItem.Enabled = false;
         this.authorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("authorBindingNavigatorSaveItem.Image")));
         this.authorBindingNavigatorSaveItem.Name = "authorBindingNavigatorSaveItem";
         this.authorBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
         this.authorBindingNavigatorSaveItem.Text = "Save Data";
         // 
         // authorIDLabel
         // 
         authorIDLabel.AutoSize = true;
         authorIDLabel.Location = new System.Drawing.Point(12, 36);
         authorIDLabel.Name = "authorIDLabel";
         authorIDLabel.Size = new System.Drawing.Size(55, 13);
         authorIDLabel.TabIndex = 1;
         authorIDLabel.Text = "Author ID:";
         // 
         // authorIDTextBox
         // 
         this.authorIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authorBindingSource, "AuthorID", true));
         this.authorIDTextBox.Location = new System.Drawing.Point(73, 33);
         this.authorIDTextBox.Name = "authorIDTextBox";
         this.authorIDTextBox.Size = new System.Drawing.Size(100, 20);
         this.authorIDTextBox.TabIndex = 2;
         // 
         // firstNameLabel
         // 
         firstNameLabel.AutoSize = true;
         firstNameLabel.Location = new System.Drawing.Point(179, 36);
         firstNameLabel.Name = "firstNameLabel";
         firstNameLabel.Size = new System.Drawing.Size(60, 13);
         firstNameLabel.TabIndex = 3;
         firstNameLabel.Text = "First Name:";
         // 
         // firstNameTextBox
         // 
         this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authorBindingSource, "FirstName", true));
         this.firstNameTextBox.Location = new System.Drawing.Point(245, 33);
         this.firstNameTextBox.Name = "firstNameTextBox";
         this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
         this.firstNameTextBox.TabIndex = 4;
         // 
         // lastNameLabel
         // 
         lastNameLabel.AutoSize = true;
         lastNameLabel.Location = new System.Drawing.Point(351, 36);
         lastNameLabel.Name = "lastNameLabel";
         lastNameLabel.Size = new System.Drawing.Size(61, 13);
         lastNameLabel.TabIndex = 5;
         lastNameLabel.Text = "Last Name:";
         // 
         // lastNameTextBox
         // 
         this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authorBindingSource, "LastName", true));
         this.lastNameTextBox.Location = new System.Drawing.Point(418, 33);
         this.lastNameTextBox.Name = "lastNameTextBox";
         this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
         this.lastNameTextBox.TabIndex = 6;
         // 
         // titlesBindingSource
         // 
         this.titlesBindingSource.DataMember = "Titles";
         this.titlesBindingSource.DataSource = this.authorBindingSource;
         // 
         // titlesDataGridView
         // 
         this.titlesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.titlesDataGridView.AutoGenerateColumns = false;
         this.titlesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.titlesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
         this.titlesDataGridView.DataSource = this.titlesBindingSource;
         this.titlesDataGridView.Location = new System.Drawing.Point(12, 59);
         this.titlesDataGridView.Name = "titlesDataGridView";
         this.titlesDataGridView.ReadOnly = true;
         this.titlesDataGridView.Size = new System.Drawing.Size(510, 190);
         this.titlesDataGridView.TabIndex = 7;
         // 
         // dataGridViewTextBoxColumn1
         // 
         this.dataGridViewTextBoxColumn1.DataPropertyName = "ISBN";
         this.dataGridViewTextBoxColumn1.HeaderText = "ISBN";
         this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
         this.dataGridViewTextBoxColumn1.ReadOnly = true;
         // 
         // dataGridViewTextBoxColumn2
         // 
         this.dataGridViewTextBoxColumn2.DataPropertyName = "Title1";
         this.dataGridViewTextBoxColumn2.HeaderText = "Title1";
         this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
         this.dataGridViewTextBoxColumn2.ReadOnly = true;
         // 
         // dataGridViewTextBoxColumn3
         // 
         this.dataGridViewTextBoxColumn3.DataPropertyName = "EditionNumber";
         this.dataGridViewTextBoxColumn3.HeaderText = "EditionNumber";
         this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
         this.dataGridViewTextBoxColumn3.ReadOnly = true;
         // 
         // dataGridViewTextBoxColumn4
         // 
         this.dataGridViewTextBoxColumn4.DataPropertyName = "Copyright";
         this.dataGridViewTextBoxColumn4.HeaderText = "Copyright";
         this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
         this.dataGridViewTextBoxColumn4.ReadOnly = true;
         // 
         // Details
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(534, 261);
         this.Controls.Add(this.titlesDataGridView);
         this.Controls.Add(authorIDLabel);
         this.Controls.Add(this.authorIDTextBox);
         this.Controls.Add(firstNameLabel);
         this.Controls.Add(this.firstNameTextBox);
         this.Controls.Add(lastNameLabel);
         this.Controls.Add(this.lastNameTextBox);
         this.Controls.Add(this.authorBindingNavigator);
         this.MinimumSize = new System.Drawing.Size(550, 300);
         this.Name = "Details";
         this.Text = "Master/Detail";
         this.Load += new System.EventHandler(this.Details_Load);
         ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.authorBindingNavigator)).EndInit();
         this.authorBindingNavigator.ResumeLayout(false);
         this.authorBindingNavigator.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.titlesBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.titlesDataGridView)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.BindingSource authorBindingSource;
      private System.Windows.Forms.BindingNavigator authorBindingNavigator;
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
      private System.Windows.Forms.ToolStripButton authorBindingNavigatorSaveItem;
      private System.Windows.Forms.TextBox authorIDTextBox;
      private System.Windows.Forms.TextBox firstNameTextBox;
      private System.Windows.Forms.TextBox lastNameTextBox;
      private System.Windows.Forms.BindingSource titlesBindingSource;
      private System.Windows.Forms.DataGridView titlesDataGridView;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
   }
}

