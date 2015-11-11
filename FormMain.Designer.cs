namespace TextEdit
{
    partial class FormMain
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
            this.textboxMain = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSave = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonFormatting = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonWordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonFontSize = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textboxMain
            // 
            this.textboxMain.AcceptsTab = true;
            this.textboxMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxMain.BulletIndent = 2;
            this.textboxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textboxMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxMain.Location = new System.Drawing.Point(0, 24);
            this.textboxMain.Name = "textboxMain";
            this.textboxMain.Size = new System.Drawing.Size(284, 237);
            this.textboxMain.TabIndex = 0;
            this.textboxMain.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.buttonFormatting});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonSave,
            this.buttonOpen});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // buttonSave
            // 
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(152, 22);
            this.buttonSave.Text = "Save";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(152, 22);
            this.buttonOpen.Text = "Open";
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonFormatting
            // 
            this.buttonFormatting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonWordWrap,
            this.buttonFontSize});
            this.buttonFormatting.Name = "buttonFormatting";
            this.buttonFormatting.Size = new System.Drawing.Size(78, 20);
            this.buttonFormatting.Text = "Formatting";
            // 
            // buttonWordWrap
            // 
            this.buttonWordWrap.Checked = true;
            this.buttonWordWrap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.buttonWordWrap.Name = "buttonWordWrap";
            this.buttonWordWrap.Size = new System.Drawing.Size(152, 22);
            this.buttonWordWrap.Text = "Word Wrap";
            this.buttonWordWrap.Click += new System.EventHandler(this.buttonWordWrap_Click);
            // 
            // buttonFontSize
            // 
            this.buttonFontSize.Name = "buttonFontSize";
            this.buttonFontSize.Size = new System.Drawing.Size(152, 22);
            this.buttonFontSize.Text = "Font/Size";
            this.buttonFontSize.Click += new System.EventHandler(this.buttonFontSize_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textboxMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TextEdit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textboxMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buttonSave;
        private System.Windows.Forms.ToolStripMenuItem buttonOpen;
        private System.Windows.Forms.ToolStripMenuItem buttonFormatting;
        private System.Windows.Forms.ToolStripMenuItem buttonWordWrap;
        private System.Windows.Forms.ToolStripMenuItem buttonFontSize;
    }
}

