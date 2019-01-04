namespace GeometryProgram
{
    partial class eometry_Design
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edit = new System.Windows.Forms.RichTextBox();
            this.stop = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.run = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(919, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(0, 27);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(364, 387);
            this.edit.TabIndex = 2;
            this.edit.Text = "";
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.stop.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.stop.FlatAppearance.BorderSize = 0;
            this.stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stop.Location = new System.Drawing.Point(43, 0);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(40, 24);
            this.stop.TabIndex = 5;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = false;
            // 
            // pause
            // 
            this.pause.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pause.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.pause.FlatAppearance.BorderSize = 0;
            this.pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pause.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pause.Location = new System.Drawing.Point(43, 0);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(46, 23);
            this.pause.TabIndex = 7;
            this.pause.Text = "Run";
            this.pause.UseVisualStyleBackColor = false;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // run
            // 
            this.run.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.run.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.run.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.run.FlatAppearance.BorderSize = 0;
            this.run.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.run.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.run.Location = new System.Drawing.Point(43, 0);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(40, 24);
            this.run.TabIndex = 3;
            this.run.Text = "Stop";
            this.run.UseVisualStyleBackColor = false;
            this.run.Click += new System.EventHandler(this.button1_Click);
            // 
            // eometry_Design
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(919, 419);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.run);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.stop);
            this.IsMdiContainer = true;
            this.Name = "eometry_Design";
            this.Text = "geometry_Design";
            this.Load += new System.EventHandler(this.eometry_Design_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.RichTextBox edit;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button run;
    }
}