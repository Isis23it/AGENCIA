namespace agencia
{
    partial class FrmEdicion
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
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btnmas = new System.Windows.Forms.Button();
            this.dtgvusuairos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvusuairos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(8, 405);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(139, 37);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "NOMBRE";
            this.lblnombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(150, 402);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(478, 51);
            this.txtnombre.TabIndex = 1;
            this.txtnombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnmas
            // 
            this.btnmas.Location = new System.Drawing.Point(640, 405);
            this.btnmas.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnmas.Name = "btnmas";
            this.btnmas.Size = new System.Drawing.Size(118, 49);
            this.btnmas.TabIndex = 2;
            this.btnmas.Text = "+";
            this.btnmas.UseVisualStyleBackColor = true;
            this.btnmas.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtgvusuairos
            // 
            this.dtgvusuairos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvusuairos.Location = new System.Drawing.Point(15, 15);
            this.dtgvusuairos.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtgvusuairos.Name = "dtgvusuairos";
            this.dtgvusuairos.RowHeadersWidth = 51;
            this.dtgvusuairos.RowTemplate.Height = 24;
            this.dtgvusuairos.Size = new System.Drawing.Size(743, 361);
            this.dtgvusuairos.TabIndex = 3;
            // 
            // FrmEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 480);
            this.Controls.Add(this.dtgvusuairos);
            this.Controls.Add(this.btnmas);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblnombre);
            this.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmEdicion";
            this.Text = "USUARIOS";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvusuairos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btnmas;
        private System.Windows.Forms.DataGridView dtgvusuairos;
    }
}