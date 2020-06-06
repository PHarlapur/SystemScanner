namespace WindowsFormsApp1
{
    partial class frmLogin
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbSystems = new System.Windows.Forms.ComboBox();
            this.btnScanSystem = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.pbar = new System.Windows.Forms.ProgressBar();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(134, 79);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(90, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Open SSH";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(771, 24);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLViewToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.toolStripMenuItem1.Text = "Data";
            // 
            // xMLViewToolStripMenuItem
            // 
            this.xMLViewToolStripMenuItem.Name = "xMLViewToolStripMenuItem";
            this.xMLViewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xMLViewToolStripMenuItem.Text = "XML View";
            this.xMLViewToolStripMenuItem.Click += new System.EventHandler(this.xMLViewToolStripMenuItem_Click);
            // 
            // cbSystems
            // 
            this.cbSystems.FormattingEnabled = true;
            this.cbSystems.Location = new System.Drawing.Point(31, 41);
            this.cbSystems.Name = "cbSystems";
            this.cbSystems.Size = new System.Drawing.Size(193, 21);
            this.cbSystems.TabIndex = 9;
            this.cbSystems.SelectedIndexChanged += new System.EventHandler(this.cbSystems_SelectedIndexChanged);
            // 
            // btnScanSystem
            // 
            this.btnScanSystem.Location = new System.Drawing.Point(31, 79);
            this.btnScanSystem.Name = "btnScanSystem";
            this.btnScanSystem.Size = new System.Drawing.Size(90, 23);
            this.btnScanSystem.TabIndex = 10;
            this.btnScanSystem.Text = "Scan Systems";
            this.btnScanSystem.UseVisualStyleBackColor = true;
            this.btnScanSystem.Click += new System.EventHandler(this.btnScanSystem_Click);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblResults.Location = new System.Drawing.Point(231, 41);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(0, 13);
            this.lblResults.TabIndex = 11;
            // 
            // pbar
            // 
            this.pbar.Location = new System.Drawing.Point(31, 548);
            this.pbar.Name = "pbar";
            this.pbar.Size = new System.Drawing.Size(720, 23);
            this.pbar.TabIndex = 12;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 583);
            this.Controls.Add(this.pbar);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnScanSystem);
            this.Controls.Add(this.cbSystems);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmLogin";
            this.Text = "Unix system Scanner";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xMLViewToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbSystems;
        private System.Windows.Forms.Button btnScanSystem;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.ProgressBar pbar;
    }
}

