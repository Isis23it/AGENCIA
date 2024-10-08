namespace agencia
{
    partial class FrmModuloHerramientas
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
            this.lblherrm = new System.Windows.Forms.Label();
            this.txtHerra = new System.Windows.Forms.TextBox();
            this.btnmas = new System.Windows.Forms.Button();
            this.dtgvHerramientas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHerramientas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblherrm
            // 
            this.lblherrm.AutoSize = true;
            this.lblherrm.Location = new System.Drawing.Point(22, 408);
            this.lblherrm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblherrm.Name = "lblherrm";
            this.lblherrm.Size = new System.Drawing.Size(173, 26);
            this.lblherrm.TabIndex = 0;
            this.lblherrm.Text = "HERRAMIENTAS";
            this.lblherrm.Click += new System.EventHandler(this.lblherrm_Click);
            // 
            // txtHerra
            // 
            this.txtHerra.Location = new System.Drawing.Point(218, 401);
            this.txtHerra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHerra.Name = "txtHerra";
            this.txtHerra.Size = new System.Drawing.Size(418, 40);
            this.txtHerra.TabIndex = 1;
            this.txtHerra.TextChanged += new System.EventHandler(this.txtHerra_TextChanged);
            // 
            // btnmas
            // 
            this.btnmas.Location = new System.Drawing.Point(644, 391);
            this.btnmas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnmas.Name = "btnmas";
            this.btnmas.Size = new System.Drawing.Size(117, 50);
            this.btnmas.TabIndex = 2;
            this.btnmas.Text = "+";
            this.btnmas.UseVisualStyleBackColor = true;
            this.btnmas.Click += new System.EventHandler(this.btnmas_Click);
            // 
            // dtgvHerramientas
            // 
            this.dtgvHerramientas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHerramientas.Location = new System.Drawing.Point(41, 23);
            this.dtgvHerramientas.Name = "dtgvHerramientas";
            this.dtgvHerramientas.RowHeadersWidth = 51;
            this.dtgvHerramientas.RowTemplate.Height = 24;
            this.dtgvHerramientas.Size = new System.Drawing.Size(720, 345);
            this.dtgvHerramientas.TabIndex = 3;
            this.dtgvHerramientas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHerramientas_CellContentClick);
            // 
            // FrmModuloHerramientas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 472);
            this.Controls.Add(this.dtgvHerramientas);
            this.Controls.Add(this.btnmas);
            this.Controls.Add(this.txtHerra);
            this.Controls.Add(this.lblherrm);
            this.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmModuloHerramientas";
            this.Text = "FrmModuloHerramientas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHerramientas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblherrm;
        private System.Windows.Forms.TextBox txtHerra;
        private System.Windows.Forms.Button btnmas;
        private System.Windows.Forms.DataGridView dtgvHerramientas;
    }
}