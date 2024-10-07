namespace agencia
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblnick = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.txtnick = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblnick
            // 
            this.lblnick.AutoSize = true;
            this.lblnick.Location = new System.Drawing.Point(53, 52);
            this.lblnick.Name = "lblnick";
            this.lblnick.Size = new System.Drawing.Size(76, 16);
            this.lblnick.TabIndex = 0;
            this.lblnick.Text = "NICKNAME";
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Location = new System.Drawing.Point(53, 121);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(86, 16);
            this.lblpass.TabIndex = 1;
            this.lblpass.Text = "PASSWORD";
            // 
            // txtnick
            // 
            this.txtnick.Location = new System.Drawing.Point(178, 49);
            this.txtnick.Name = "txtnick";
            this.txtnick.Size = new System.Drawing.Size(168, 22);
            this.txtnick.TabIndex = 2;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(178, 115);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(168, 22);
            this.txtpass.TabIndex = 3;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 202);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtnick);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lblnick);
            this.Name = "FrmLogin";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnick;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox txtnick;
        private System.Windows.Forms.TextBox txtpass;
    }
}

