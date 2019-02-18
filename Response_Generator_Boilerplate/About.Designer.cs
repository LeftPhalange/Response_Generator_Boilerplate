namespace Response_Generator_Boilerplate
{
    partial class About
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
            this._content = new System.Windows.Forms.Label();
            this._close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _header
            // 
            this._header.AutoSize = true;
            this._header.BackColor = System.Drawing.Color.Transparent;
            this._header.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._header.Location = new System.Drawing.Point(13, 11);
            this._header.Name = "_header";
            this._header.Size = new System.Drawing.Size(267, 22);
            this._header.TabIndex = 0;
            this._header.Text = "Response Generator Boilerplate";
            // 
            // _content
            // 
            this._content.AutoSize = true;
            this._content.Location = new System.Drawing.Point(54, 33);
            this._content.Name = "_content";
            this._content.Size = new System.Drawing.Size(184, 65);
            this._content.TabIndex = 1;
            this._content.Text = "Original project done by LeftPhalange\r\nfor GitHub.\r\n\r\nFeel free to modify this bo" +
    "ilerplate to\r\nyour liking. Credit is preferred.";
            this._content.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _close
            // 
            this._close.Location = new System.Drawing.Point(111, 103);
            this._close.Name = "_close";
            this._close.Size = new System.Drawing.Size(71, 23);
            this._close.TabIndex = 2;
            this._close.Text = "OK";
            this._close.UseVisualStyleBackColor = true;
            this._close.Click += new System.EventHandler(this._close_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 136);
            this.ControlBox = false;
            this.Controls.Add(this._close);
            this.Controls.Add(this._content);
            this.Controls.Add(this._header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Response Generator Boilerplate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _header;
        private System.Windows.Forms.Label _content;
        private System.Windows.Forms.Button _close;
    }
}