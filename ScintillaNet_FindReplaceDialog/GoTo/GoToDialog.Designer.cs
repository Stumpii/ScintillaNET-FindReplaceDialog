namespace ScintillaNET_FindReplaceDialog
{
    partial class GoToDialog
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoToDialog));
      this.lblCurrentLine = new System.Windows.Forms.Label();
      this.txtCurrentLine = new System.Windows.Forms.TextBox();
      this.err = new System.Windows.Forms.ErrorProvider(this.components);
      this.txtMaxLine = new System.Windows.Forms.TextBox();
      this.lblMaxLine = new System.Windows.Forms.Label();
      this.txtGotoLine = new System.Windows.Forms.TextBox();
      this.lblGotoLine = new System.Windows.Forms.Label();
      this.btnOK = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
      this.SuspendLayout();
      // 
      // lblCurrentLine
      // 
      resources.ApplyResources(this.lblCurrentLine, "lblCurrentLine");
      this.lblCurrentLine.Name = "lblCurrentLine";
      // 
      // txtCurrentLine
      // 
      resources.ApplyResources(this.txtCurrentLine, "txtCurrentLine");
      this.txtCurrentLine.Name = "txtCurrentLine";
      this.txtCurrentLine.ReadOnly = true;
      // 
      // err
      // 
      this.err.ContainerControl = this;
      // 
      // txtMaxLine
      // 
      resources.ApplyResources(this.txtMaxLine, "txtMaxLine");
      this.txtMaxLine.Name = "txtMaxLine";
      this.txtMaxLine.ReadOnly = true;
      // 
      // lblMaxLine
      // 
      resources.ApplyResources(this.lblMaxLine, "lblMaxLine");
      this.lblMaxLine.Name = "lblMaxLine";
      // 
      // txtGotoLine
      // 
      resources.ApplyResources(this.txtGotoLine, "txtGotoLine");
      this.txtGotoLine.Name = "txtGotoLine";
      // 
      // lblGotoLine
      // 
      resources.ApplyResources(this.lblGotoLine, "lblGotoLine");
      this.lblGotoLine.Name = "lblGotoLine";
      // 
      // btnOK
      // 
      resources.ApplyResources(this.btnOK, "btnOK");
      this.btnOK.Name = "btnOK";
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      resources.ApplyResources(this.btnCancel, "btnCancel");
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // GoToDialog
      // 
      this.AcceptButton = this.btnOK;
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.txtGotoLine);
      this.Controls.Add(this.lblGotoLine);
      this.Controls.Add(this.txtMaxLine);
      this.Controls.Add(this.lblMaxLine);
      this.Controls.Add(this.txtCurrentLine);
      this.Controls.Add(this.lblCurrentLine);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "GoToDialog";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.Activated += new System.EventHandler(this.GoToDialog_Activated);
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GoToDialog_FormClosing);
      ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentLine;
        private System.Windows.Forms.TextBox txtCurrentLine;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtGotoLine;
        private System.Windows.Forms.Label lblGotoLine;
        private System.Windows.Forms.TextBox txtMaxLine;
        private System.Windows.Forms.Label lblMaxLine;
    }
}