namespace UsingMDI
{
   partial class UsingMDIForm
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
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.lavendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.purpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.yellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.menuStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // menuStrip1
         // 
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.windowToolStripMenuItem});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.MdiWindowListItem = this.windowToolStripMenuItem;
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
         this.menuStrip1.Size = new System.Drawing.Size(412, 24);
         this.menuStrip1.TabIndex = 1;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // fileToolStripMenuItem
         // 
         this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
         this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
         this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
         this.fileToolStripMenuItem.Text = "File";
         // 
         // newToolStripMenuItem
         // 
         this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lavendarToolStripMenuItem,
            this.purpleToolStripMenuItem,
            this.yellowToolStripMenuItem});
         this.newToolStripMenuItem.Name = "newToolStripMenuItem";
         this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
         this.newToolStripMenuItem.Text = "New";
         // 
         // lavendarToolStripMenuItem
         // 
         this.lavendarToolStripMenuItem.Name = "lavendarToolStripMenuItem";
         this.lavendarToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
         this.lavendarToolStripMenuItem.Text = "Lavendar Flowers";
         this.lavendarToolStripMenuItem.Click += new System.EventHandler(this.lavenderToolStripMenuItem_Click);
         // 
         // purpleToolStripMenuItem
         // 
         this.purpleToolStripMenuItem.Name = "purpleToolStripMenuItem";
         this.purpleToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
         this.purpleToolStripMenuItem.Text = "Purple Flowers";
         this.purpleToolStripMenuItem.Click += new System.EventHandler(this.purpleToolStripMenuItem_Click);
         // 
         // yellowToolStripMenuItem
         // 
         this.yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
         this.yellowToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
         this.yellowToolStripMenuItem.Text = "Yellow Flowers";
         this.yellowToolStripMenuItem.Click += new System.EventHandler(this.yellowToolStripMenuItem_Click);
         // 
         // exitToolStripMenuItem
         // 
         this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
         this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
         this.exitToolStripMenuItem.Text = "Exit";
         this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
         // 
         // windowToolStripMenuItem
         // 
         this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.toolStripSeparator1});
         this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
         this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
         this.windowToolStripMenuItem.Text = "Window";
         // 
         // cascadeToolStripMenuItem
         // 
         this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
         this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
         this.cascadeToolStripMenuItem.Text = "Cascade";
         this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
         // 
         // tileHorizontalToolStripMenuItem
         // 
         this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
         this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
         this.tileHorizontalToolStripMenuItem.Text = "Tile Horizontal";
         this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.tileHorizontalToolStripMenuItem_Click);
         // 
         // tileVerticalToolStripMenuItem
         // 
         this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
         this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
         this.tileVerticalToolStripMenuItem.Text = "Tile Vertical";
         this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.tileVerticalToolStripMenuItem_Click);
         // 
         // toolStripSeparator1
         // 
         this.toolStripSeparator1.Name = "toolStripSeparator1";
         this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
         // 
         // UsingMDIForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(412, 358);
         this.Controls.Add(this.menuStrip1);
         this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.IsMdiContainer = true;
         this.MainMenuStrip = this.menuStrip1;
         this.Name = "UsingMDIForm";
         this.Text = "Using MDI";
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem lavendarToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem purpleToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem yellowToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
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
