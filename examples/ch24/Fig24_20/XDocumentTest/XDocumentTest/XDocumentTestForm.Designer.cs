namespace XDocumentTest
{
    partial class XDocumentTestForm
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
           this.outputTextBox = new System.Windows.Forms.TextBox();
           this.SuspendLayout();
           // 
           // outputTextBox
           // 
           this.outputTextBox.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                       | System.Windows.Forms.AnchorStyles.Left )
                       | System.Windows.Forms.AnchorStyles.Right ) ) );
           this.outputTextBox.BackColor = System.Drawing.Color.White;
           this.outputTextBox.Font = new System.Drawing.Font( "Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
           this.outputTextBox.Location = new System.Drawing.Point( 12, 12 );
           this.outputTextBox.Multiline = true;
           this.outputTextBox.Name = "outputTextBox";
           this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
           this.outputTextBox.Size = new System.Drawing.Size( 454, 380 );
           this.outputTextBox.TabIndex = 2;
           this.outputTextBox.TabStop = false;
           this.outputTextBox.WordWrap = false;
           // 
           // XDocumentTestForm
           // 
           this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
           this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           this.ClientSize = new System.Drawing.Size( 478, 404 );
           this.Controls.Add( this.outputTextBox );
           this.Name = "XDocumentTestForm";
           this.Text = "XDocument Test";
           this.Load += new System.EventHandler( this.XDocumentTestForm_Load );
           this.ResumeLayout( false );
           this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outputTextBox;
    }
}

