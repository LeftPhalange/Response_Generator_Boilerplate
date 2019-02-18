namespace Response_Generator_Boilerplate
{
    partial class MainForm
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
            this._header = new System.Windows.Forms.Label();
            this._responseOutput = new System.Windows.Forms.TextBox();
            this._menuStrip = new System.Windows.Forms.MenuStrip();
            this._file = new System.Windows.Forms.ToolStripMenuItem();
            this._exit = new System.Windows.Forms.ToolStripMenuItem();
            this._help = new System.Windows.Forms.ToolStripMenuItem();
            this._about = new System.Windows.Forms.ToolStripMenuItem();
            this._generate = new System.Windows.Forms.Button();
            this._copyToClipboard = new System.Windows.Forms.Button();
            this._menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _header
            // 
            this._header.AutoSize = true;
            this._header.ForeColor = System.Drawing.Color.Black;
            this._header.Location = new System.Drawing.Point(9, 27);
            this._header.Name = "_header";
            this._header.Size = new System.Drawing.Size(495, 13);
            this._header.TabIndex = 0;
            this._header.Text = "Here you can state what your response generator would entail. What kind of respon" +
    "se generator is this?";
            // 
            // _responseOutput
            // 
            this._responseOutput.BackColor = System.Drawing.Color.White;
            this._responseOutput.Location = new System.Drawing.Point(12, 43);
            this._responseOutput.Name = "_responseOutput";
            this._responseOutput.ReadOnly = true;
            this._responseOutput.Size = new System.Drawing.Size(628, 20);
            this._responseOutput.TabIndex = 0;
            this._responseOutput.TabStop = false;
            this._responseOutput.Text = "This is the summary before you begin generating responses. Be creative.";
            // 
            // _menuStrip
            // 
            this._menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._file,
            this._help});
            this._menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this._menuStrip.Location = new System.Drawing.Point(0, 0);
            this._menuStrip.Name = "_menuStrip";
            this._menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this._menuStrip.Size = new System.Drawing.Size(652, 23);
            this._menuStrip.TabIndex = 2;
            // 
            // _file
            // 
            this._file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._exit});
            this._file.Name = "_file";
            this._file.Size = new System.Drawing.Size(37, 19);
            this._file.Text = "File";
            // 
            // _exit
            // 
            this._exit.Name = "_exit";
            this._exit.Size = new System.Drawing.Size(152, 22);
            this._exit.Text = "Exit. (ALT + F4)";
            this._exit.Click += new System.EventHandler(this._exit_Click);
            // 
            // _help
            // 
            this._help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._about});
            this._help.Name = "_help";
            this._help.Size = new System.Drawing.Size(44, 20);
            this._help.Text = "Help";
            // 
            // _about
            // 
            this._about.Name = "_about";
            this._about.Size = new System.Drawing.Size(274, 22);
            this._about.Text = "About Response Generator Boilerplate";
            this._about.Click += new System.EventHandler(this._about_Click);
            // 
            // _generate
            // 
            this._generate.Location = new System.Drawing.Point(12, 69);
            this._generate.Name = "_generate";
            this._generate.Size = new System.Drawing.Size(254, 27);
            this._generate.TabIndex = 3;
            this._generate.Text = "Generate a response.";
            this._generate.UseVisualStyleBackColor = true;
            this._generate.Click += new System.EventHandler(this._generate_Click);
            // 
            // _copyToClipboard
            // 
            this._copyToClipboard.Location = new System.Drawing.Point(272, 69);
            this._copyToClipboard.Name = "_copyToClipboard";
            this._copyToClipboard.Size = new System.Drawing.Size(368, 27);
            this._copyToClipboard.TabIndex = 4;
            this._copyToClipboard.Text = "Copy to the clipboard.";
            this._copyToClipboard.UseVisualStyleBackColor = true;
            this._copyToClipboard.Click += new System.EventHandler(this._copyToClipboard_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(652, 108);
            this.Controls.Add(this._copyToClipboard);
            this.Controls.Add(this._generate);
            this.Controls.Add(this._responseOutput);
            this.Controls.Add(this._header);
            this.Controls.Add(this._menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this._menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Response Generator Boilerplate";
            this._menuStrip.ResumeLayout(false);
            this._menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _header;
        private System.Windows.Forms.TextBox _responseOutput;
        private System.Windows.Forms.MenuStrip _menuStrip;
        private System.Windows.Forms.ToolStripMenuItem _file;
        private System.Windows.Forms.ToolStripMenuItem _help;
        private System.Windows.Forms.Button _generate;
        private System.Windows.Forms.Button _copyToClipboard;
        private System.Windows.Forms.ToolStripMenuItem _about;
        private System.Windows.Forms.ToolStripMenuItem _exit;
    }
}

