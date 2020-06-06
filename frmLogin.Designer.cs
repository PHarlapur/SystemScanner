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
            this.cbSystems = new System.Windows.Forms.ComboBox();
            this.btnScanSystem = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.pbar = new System.Windows.Forms.ProgressBar();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnViewXml = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(271, 247);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(6);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(180, 44);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Open SSH";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip.Size = new System.Drawing.Size(1495, 24);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "menuStrip1";
            // 
            // cbSystems
            // 
            this.cbSystems.FormattingEnabled = true;
            this.cbSystems.Location = new System.Drawing.Point(65, 174);
            this.cbSystems.Margin = new System.Windows.Forms.Padding(6);
            this.cbSystems.Name = "cbSystems";
            this.cbSystems.Size = new System.Drawing.Size(382, 33);
            this.cbSystems.TabIndex = 9;
            this.cbSystems.SelectedIndexChanged += new System.EventHandler(this.cbSystems_SelectedIndexChanged);
            // 
            // btnScanSystem
            // 
            this.btnScanSystem.Location = new System.Drawing.Point(65, 247);
            this.btnScanSystem.Margin = new System.Windows.Forms.Padding(6);
            this.btnScanSystem.Name = "btnScanSystem";
            this.btnScanSystem.Size = new System.Drawing.Size(180, 44);
            this.btnScanSystem.TabIndex = 10;
            this.btnScanSystem.Text = "Scan Systems";
            this.btnScanSystem.UseVisualStyleBackColor = true;
            this.btnScanSystem.Click += new System.EventHandler(this.btnScanSystem_Click);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblResults.Location = new System.Drawing.Point(465, 174);
            this.lblResults.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(0, 25);
            this.lblResults.TabIndex = 11;
            // 
            // pbar
            // 
            this.pbar.Location = new System.Drawing.Point(55, 46);
            this.pbar.Margin = new System.Windows.Forms.Padding(6);
            this.pbar.Name = "pbar";
            this.pbar.Size = new System.Drawing.Size(1353, 44);
            this.pbar.TabIndex = 12;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(65, 330);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(386, 31);
            this.txtFilePath.TabIndex = 13;
            this.txtFilePath.Text = "D:\\\\data.xml";
            // 
            // btnViewXml
            // 
            this.btnViewXml.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewXml.Location = new System.Drawing.Point(65, 380);
            this.btnViewXml.Name = "btnViewXml";
            this.btnViewXml.Size = new System.Drawing.Size(151, 63);
            this.btnViewXml.TabIndex = 14;
            this.btnViewXml.Text = "View";
            this.btnViewXml.UseVisualStyleBackColor = true;
            this.btnViewXml.Click += new System.EventHandler(this.btnViewXml_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1495, 738);
            this.Controls.Add(this.btnViewXml);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.pbar);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnScanSystem);
            this.Controls.Add(this.cbSystems);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmLogin";
            this.Text = "Unix system Scanner";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ComboBox cbSystems;
        private System.Windows.Forms.Button btnScanSystem;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.ProgressBar pbar;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnViewXml;
    }
}

