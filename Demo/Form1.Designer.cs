namespace Demo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.scintilla1 = new ScintillaNET.Scintilla();
            this.GotoButton = new System.Windows.Forms.Button();
            this.incrementalSearcher1 = new ScintillaNET_FindReplaceDialog.IncrementalSearcher();
            this.FindResultsScintilla = new ScintillaNET.Scintilla();
            this.SuspendLayout();
            // 
            // scintilla1
            // 
            this.scintilla1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scintilla1.CaretLineVisible = true;
            this.scintilla1.Location = new System.Drawing.Point(9, 34);
            this.scintilla1.Name = "scintilla1";
            this.scintilla1.ScrollWidth = 5001;
            this.scintilla1.Size = new System.Drawing.Size(715, 242);
            this.scintilla1.TabIndex = 0;
            this.scintilla1.Text = resources.GetString("scintilla1.Text");
            this.scintilla1.UseTabs = false;
            this.scintilla1.WrapMode = ScintillaNET.WrapMode.Word;
            this.scintilla1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.scintilla1_KeyDown);
            // 
            // GotoButton
            // 
            this.GotoButton.Location = new System.Drawing.Point(730, 34);
            this.GotoButton.Name = "GotoButton";
            this.GotoButton.Size = new System.Drawing.Size(75, 23);
            this.GotoButton.TabIndex = 2;
            this.GotoButton.Text = "Goto";
            this.GotoButton.UseVisualStyleBackColor = true;
            this.GotoButton.Click += new System.EventHandler(this.GotoButton_Click);
            // 
            // incrementalSearcher1
            // 
            this.incrementalSearcher1.AutoPosition = false;
            this.incrementalSearcher1.AutoSize = true;
            this.incrementalSearcher1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.incrementalSearcher1.BackColor = System.Drawing.Color.Transparent;
            this.incrementalSearcher1.FindReplace = null;
            this.incrementalSearcher1.Location = new System.Drawing.Point(9, 9);
            this.incrementalSearcher1.Margin = new System.Windows.Forms.Padding(0);
            this.incrementalSearcher1.Name = "incrementalSearcher1";
            this.incrementalSearcher1.Scintilla = null;
            this.incrementalSearcher1.Size = new System.Drawing.Size(259, 22);
            this.incrementalSearcher1.TabIndex = 1;
            this.incrementalSearcher1.ToolItem = true;
            // 
            // FindResultsScintilla
            // 
            this.FindResultsScintilla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FindResultsScintilla.Location = new System.Drawing.Point(9, 282);
            this.FindResultsScintilla.Name = "FindResultsScintilla";
            this.FindResultsScintilla.ScrollWidth = 5001;
            this.FindResultsScintilla.Size = new System.Drawing.Size(715, 167);
            this.FindResultsScintilla.TabIndex = 3;
            this.FindResultsScintilla.Text = "FindResultsScintilla";
            this.FindResultsScintilla.UseTabs = false;
            this.FindResultsScintilla.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FindResultsScintilla_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 461);
            this.Controls.Add(this.FindResultsScintilla);
            this.Controls.Add(this.GotoButton);
            this.Controls.Add(this.incrementalSearcher1);
            this.Controls.Add(this.scintilla1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private ScintillaNET.Scintilla scintilla1;
        private ScintillaNET_FindReplaceDialog.IncrementalSearcher incrementalSearcher1;
        private System.Windows.Forms.Button GotoButton;
        private ScintillaNET.Scintilla FindResultsScintilla;
    }
}

