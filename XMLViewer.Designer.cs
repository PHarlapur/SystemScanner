namespace WindowsFormsApp1
{
    partial class XMLViewer
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
            this.dgXMLView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgXMLView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgXMLView
            // 
            this.dgXMLView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgXMLView.Location = new System.Drawing.Point(69, 69);
            this.dgXMLView.Name = "dgXMLView";
            this.dgXMLView.Size = new System.Drawing.Size(643, 318);
            this.dgXMLView.TabIndex = 0;
            // 
            // XMLViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgXMLView);
            this.Name = "XMLViewer";
            this.Text = "XMLViewer";
            this.Load += new System.EventHandler(this.XMLViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgXMLView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgXMLView;
    }
}