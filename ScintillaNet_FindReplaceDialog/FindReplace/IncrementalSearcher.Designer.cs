namespace ScintillaNET_FindReplaceDialog
{
    partial class IncrementalSearcher
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncrementalSearcher));
      this.lblFind = new System.Windows.Forms.Label();
      this.txtFind = new System.Windows.Forms.TextBox();
      this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
      this.btnNext = new System.Windows.Forms.Button();
      this.brnPrevious = new System.Windows.Forms.Button();
      this.btnHighlightAll = new System.Windows.Forms.Button();
      this.btnClearHighlights = new System.Windows.Forms.Button();
      this.toolTip = new System.Windows.Forms.ToolTip(this.components);
      this.flowLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblFind
      // 
      resources.ApplyResources(this.lblFind, "lblFind");
      this.lblFind.Name = "lblFind";
      // 
      // txtFind
      // 
      resources.ApplyResources(this.txtFind, "txtFind");
      this.txtFind.Name = "txtFind";
      this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
      this.txtFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFind_KeyDown);
      // 
      // flowLayoutPanel1
      // 
      resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
      this.flowLayoutPanel1.Controls.Add(this.lblFind);
      this.flowLayoutPanel1.Controls.Add(this.txtFind);
      this.flowLayoutPanel1.Controls.Add(this.btnNext);
      this.flowLayoutPanel1.Controls.Add(this.brnPrevious);
      this.flowLayoutPanel1.Controls.Add(this.btnHighlightAll);
      this.flowLayoutPanel1.Controls.Add(this.btnClearHighlights);
      this.flowLayoutPanel1.Name = "flowLayoutPanel1";
      // 
      // btnNext
      // 
      resources.ApplyResources(this.btnNext, "btnNext");
      this.btnNext.BackgroundImage = global::ScintillaNET_FindReplaceDialog.Properties.Resources.GoToNextMessage;
      this.btnNext.FlatAppearance.BorderSize = 0;
      this.btnNext.Image = global::ScintillaNET_FindReplaceDialog.Properties.Resources.GoToNextMessage;
      this.btnNext.Name = "btnNext";
      this.toolTip.SetToolTip(this.btnNext, resources.GetString("btnNext.ToolTip"));
      this.btnNext.UseVisualStyleBackColor = true;
      this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
      // 
      // brnPrevious
      // 
      resources.ApplyResources(this.brnPrevious, "brnPrevious");
      this.brnPrevious.FlatAppearance.BorderSize = 0;
      this.brnPrevious.Image = global::ScintillaNET_FindReplaceDialog.Properties.Resources.GoToPreviousMessage;
      this.brnPrevious.Name = "brnPrevious";
      this.toolTip.SetToolTip(this.brnPrevious, resources.GetString("brnPrevious.ToolTip"));
      this.brnPrevious.UseVisualStyleBackColor = true;
      this.brnPrevious.Click += new System.EventHandler(this.brnPrevious_Click);
      // 
      // btnHighlightAll
      // 
      resources.ApplyResources(this.btnHighlightAll, "btnHighlightAll");
      this.btnHighlightAll.BackgroundImage = global::ScintillaNET_FindReplaceDialog.Properties.Resources.LineColorHS;
      this.btnHighlightAll.FlatAppearance.BorderSize = 0;
      this.btnHighlightAll.ForeColor = System.Drawing.Color.SkyBlue;
      this.btnHighlightAll.Image = global::ScintillaNET_FindReplaceDialog.Properties.Resources.LineColorHS;
      this.btnHighlightAll.Name = "btnHighlightAll";
      this.toolTip.SetToolTip(this.btnHighlightAll, resources.GetString("btnHighlightAll.ToolTip"));
      this.btnHighlightAll.UseVisualStyleBackColor = true;
      this.btnHighlightAll.Click += new System.EventHandler(this.btnHighlightAll_Click);
      // 
      // btnClearHighlights
      // 
      resources.ApplyResources(this.btnClearHighlights, "btnClearHighlights");
      this.btnClearHighlights.FlatAppearance.BorderSize = 0;
      this.btnClearHighlights.Image = global::ScintillaNET_FindReplaceDialog.Properties.Resources.DeleteHS;
      this.btnClearHighlights.Name = "btnClearHighlights";
      this.toolTip.SetToolTip(this.btnClearHighlights, resources.GetString("btnClearHighlights.ToolTip"));
      this.btnClearHighlights.UseVisualStyleBackColor = true;
      this.btnClearHighlights.Click += new System.EventHandler(this.btnClearHighlights_Click);
      // 
      // IncrementalSearcher
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.LightSteelBlue;
      this.Controls.Add(this.flowLayoutPanel1);
      this.Name = "IncrementalSearcher";
      this.flowLayoutPanel1.ResumeLayout(false);
      this.flowLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button brnPrevious;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnHighlightAll;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnClearHighlights;
    }
}
