namespace EncriptarDesencriptar
{
    partial class FormEncriptador
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.txbEncriptacao = new System.Windows.Forms.TextBox();
            this.txbDesencriptacao = new System.Windows.Forms.TextBox();
            this.btnEncriptacao = new System.Windows.Forms.Button();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnDesencriptar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(225, 39);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(206, 22);
            this.txbSenha.TabIndex = 2;
            // 
            // txbEncriptacao
            // 
            this.txbEncriptacao.Location = new System.Drawing.Point(225, 96);
            this.txbEncriptacao.Name = "txbEncriptacao";
            this.txbEncriptacao.ReadOnly = true;
            this.txbEncriptacao.Size = new System.Drawing.Size(206, 22);
            this.txbEncriptacao.TabIndex = 3;
            // 
            // txbDesencriptacao
            // 
            this.txbDesencriptacao.Location = new System.Drawing.Point(225, 153);
            this.txbDesencriptacao.Name = "txbDesencriptacao";
            this.txbDesencriptacao.ReadOnly = true;
            this.txbDesencriptacao.Size = new System.Drawing.Size(206, 22);
            this.txbDesencriptacao.TabIndex = 4;
            // 
            // btnEncriptacao
            // 
            this.btnEncriptacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncriptacao.Location = new System.Drawing.Point(12, 95);
            this.btnEncriptacao.Name = "btnEncriptacao";
            this.btnEncriptacao.Size = new System.Drawing.Size(156, 23);
            this.btnEncriptacao.TabIndex = 5;
            this.btnEncriptacao.Text = "Encriptar Senha";
            this.btnEncriptacao.UseVisualStyleBackColor = true;
            this.btnEncriptacao.Click += new System.EventHandler(this.btnEncriptacao_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(222, 20);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(127, 16);
            this.lblSenha.TabIndex = 6;
            this.lblSenha.Text = "Digite sua senha:";
            // 
            // btnDesencriptar
            // 
            this.btnDesencriptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesencriptar.Location = new System.Drawing.Point(12, 152);
            this.btnDesencriptar.Name = "btnDesencriptar";
            this.btnDesencriptar.Size = new System.Drawing.Size(156, 23);
            this.btnDesencriptar.TabIndex = 7;
            this.btnDesencriptar.Text = "Desencriptar Senha";
            this.btnDesencriptar.UseVisualStyleBackColor = true;
            this.btnDesencriptar.Click += new System.EventHandler(this.btnDesencriptar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(12, 38);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(156, 23);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FormEncriptador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 197);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDesencriptar);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.btnEncriptacao);
            this.Controls.Add(this.txbDesencriptacao);
            this.Controls.Add(this.txbEncriptacao);
            this.Controls.Add(this.txbSenha);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormEncriptador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ENCRIPTADOR / DESENCRIPTADOR AES-256-CBC";
            this.Load += new System.EventHandler(this.FormEncriptador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.TextBox txbEncriptacao;
        private System.Windows.Forms.TextBox txbDesencriptacao;
        private System.Windows.Forms.Button btnEncriptacao;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnDesencriptar;
        private System.Windows.Forms.Button btnLimpar;
    }
}

