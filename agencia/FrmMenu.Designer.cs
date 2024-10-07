namespace agencia
{
    partial class FrmMenu
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
            this.mst = new System.Windows.Forms.MenuStrip();
            this.productostool = new System.Windows.Forms.ToolStripMenuItem();
            this.herraminetastool = new System.Windows.Forms.ToolStripMenuItem();
            this.rEGISTROUSESRSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mst.SuspendLayout();
            this.SuspendLayout();
            // 
            // mst
            // 
            this.mst.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mst.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productostool,
            this.herraminetastool,
            this.rEGISTROUSESRSToolStripMenuItem});
            this.mst.Location = new System.Drawing.Point(0, 0);
            this.mst.Name = "mst";
            this.mst.Size = new System.Drawing.Size(800, 28);
            this.mst.TabIndex = 0;
            this.mst.Text = "menuStrip1";
            // 
            // productostool
            // 
            this.productostool.Name = "productostool";
            this.productostool.Size = new System.Drawing.Size(107, 24);
            this.productostool.Text = "PRODUCTOS";
            this.productostool.Click += new System.EventHandler(this.productostool_Click);
            // 
            // herraminetastool
            // 
            this.herraminetastool.Name = "herraminetastool";
            this.herraminetastool.Size = new System.Drawing.Size(131, 24);
            this.herraminetastool.Text = "HERRAMIENTAS";
            this.herraminetastool.Click += new System.EventHandler(this.herraminetastool_Click);
            // 
            // rEGISTROUSESRSToolStripMenuItem
            // 
            this.rEGISTROUSESRSToolStripMenuItem.Name = "rEGISTROUSESRSToolStripMenuItem";
            this.rEGISTROUSESRSToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.rEGISTROUSESRSToolStripMenuItem.Text = "REGISTRO USERS";
            this.rEGISTROUSESRSToolStripMenuItem.Click += new System.EventHandler(this.rEGISTROUSESRSToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mst);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mst;
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.mst.ResumeLayout(false);
            this.mst.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mst;
        private System.Windows.Forms.ToolStripMenuItem productostool;
        private System.Windows.Forms.ToolStripMenuItem herraminetastool;
        private System.Windows.Forms.ToolStripMenuItem rEGISTROUSESRSToolStripMenuItem;
    }
}