namespace agencia
{
    partial class FrmProductos
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
            this.dtgvpro = new System.Windows.Forms.DataGridView();
            this.btnmas = new System.Windows.Forms.Button();
            this.txtproductos = new System.Windows.Forms.TextBox();
            this.lblpro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvpro)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvpro
            // 
            this.dtgvpro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvpro.Location = new System.Drawing.Point(38, 19);
            this.dtgvpro.Name = "dtgvpro";
            this.dtgvpro.RowHeadersWidth = 51;
            this.dtgvpro.RowTemplate.Height = 24;
            this.dtgvpro.Size = new System.Drawing.Size(720, 345);
            this.dtgvpro.TabIndex = 7;
            // 
            // btnmas
            // 
            this.btnmas.Location = new System.Drawing.Point(641, 387);
            this.btnmas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnmas.Name = "btnmas";
            this.btnmas.Size = new System.Drawing.Size(117, 50);
            this.btnmas.TabIndex = 6;
            this.btnmas.Text = "+";
            this.btnmas.UseVisualStyleBackColor = true;
            this.btnmas.Click += new System.EventHandler(this.btnmas_Click);
            // 
            // txtproductos
            // 
            this.txtproductos.Location = new System.Drawing.Point(215, 397);
            this.txtproductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtproductos.Name = "txtproductos";
            this.txtproductos.Size = new System.Drawing.Size(418, 40);
            this.txtproductos.TabIndex = 5;
            // 
            // lblpro
            // 
            this.lblpro.AutoSize = true;
            this.lblpro.Location = new System.Drawing.Point(19, 404);
            this.lblpro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpro.Name = "lblpro";
            this.lblpro.Size = new System.Drawing.Size(132, 26);
            this.lblpro.TabIndex = 4;
            this.lblpro.Text = "PRODUCTOS";
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 467);
            this.Controls.Add(this.dtgvpro);
            this.Controls.Add(this.btnmas);
            this.Controls.Add(this.txtproductos);
            this.Controls.Add(this.lblpro);
            this.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmProductos";
            this.Text = "FrmProductos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvpro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvpro;
        private System.Windows.Forms.Button btnmas;
        private System.Windows.Forms.TextBox txtproductos;
        private System.Windows.Forms.Label lblpro;
    }
}