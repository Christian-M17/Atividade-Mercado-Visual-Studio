namespace SaborVida
{
    partial class Form1
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
            this.lblCadastro = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDecricao = new System.Windows.Forms.TextBox();
            this.lblPrecoCusto = new System.Windows.Forms.Label();
            this.txtPrecoCusto = new System.Windows.Forms.TextBox();
            this.lblAlertaPrecoC = new System.Windows.Forms.Label();
            this.lblAlertaPrecoV = new System.Windows.Forms.Label();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblAlertaQuantidade = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.lblAlertCategoria = new System.Windows.Forms.Label();
            this.txtImposto = new System.Windows.Forms.TextBox();
            this.lblImposto = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblAlertaEstoque = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Location = new System.Drawing.Point(200, 9);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(104, 13);
            this.lblCadastro.TabIndex = 0;
            this.lblCadastro.Text = "Cadastro de Produto";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(47, 39);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtDecricao
            // 
            this.txtDecricao.Location = new System.Drawing.Point(50, 56);
            this.txtDecricao.Name = "txtDecricao";
            this.txtDecricao.Size = new System.Drawing.Size(441, 20);
            this.txtDecricao.TabIndex = 2;
            // 
            // lblPrecoCusto
            // 
            this.lblPrecoCusto.AutoSize = true;
            this.lblPrecoCusto.Location = new System.Drawing.Point(47, 93);
            this.lblPrecoCusto.Name = "lblPrecoCusto";
            this.lblPrecoCusto.Size = new System.Drawing.Size(80, 13);
            this.lblPrecoCusto.TabIndex = 3;
            this.lblPrecoCusto.Text = "Preço do Custo";
            // 
            // txtPrecoCusto
            // 
            this.txtPrecoCusto.Location = new System.Drawing.Point(50, 109);
            this.txtPrecoCusto.Name = "txtPrecoCusto";
            this.txtPrecoCusto.Size = new System.Drawing.Size(142, 20);
            this.txtPrecoCusto.TabIndex = 4;
            // 
            // lblAlertaPrecoC
            // 
            this.lblAlertaPrecoC.AutoSize = true;
            this.lblAlertaPrecoC.Location = new System.Drawing.Point(50, 136);
            this.lblAlertaPrecoC.Name = "lblAlertaPrecoC";
            this.lblAlertaPrecoC.Size = new System.Drawing.Size(0, 13);
            this.lblAlertaPrecoC.TabIndex = 5;
            // 
            // lblAlertaPrecoV
            // 
            this.lblAlertaPrecoV.AutoSize = true;
            this.lblAlertaPrecoV.Location = new System.Drawing.Point(53, 205);
            this.lblAlertaPrecoV.Name = "lblAlertaPrecoV";
            this.lblAlertaPrecoV.Size = new System.Drawing.Size(0, 13);
            this.lblAlertaPrecoV.TabIndex = 8;
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Location = new System.Drawing.Point(53, 178);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(142, 20);
            this.txtPrecoVenda.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Preço de Venda";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Alimento",
            "Bebida"});
            this.cmbCategoria.Location = new System.Drawing.Point(53, 234);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(142, 21);
            this.cmbCategoria.TabIndex = 9;
            this.cmbCategoria.Text = "Edite";
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(50, 218);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 10;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblAlertaQuantidade
            // 
            this.lblAlertaQuantidade.AutoSize = true;
            this.lblAlertaQuantidade.Location = new System.Drawing.Point(317, 205);
            this.lblAlertaQuantidade.Name = "lblAlertaQuantidade";
            this.lblAlertaQuantidade.Size = new System.Drawing.Size(0, 13);
            this.lblAlertaQuantidade.TabIndex = 16;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(317, 178);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(142, 20);
            this.txtQuantidade.TabIndex = 15;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(314, 162);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lblQuantidade.TabIndex = 14;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(314, 109);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(142, 20);
            this.txtEstoque.TabIndex = 12;
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Location = new System.Drawing.Point(311, 93);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(81, 13);
            this.lblEstoque.TabIndex = 11;
            this.lblEstoque.Text = "Estoque minimo";
            // 
            // lblAlertCategoria
            // 
            this.lblAlertCategoria.AutoSize = true;
            this.lblAlertCategoria.Location = new System.Drawing.Point(53, 258);
            this.lblAlertCategoria.Name = "lblAlertCategoria";
            this.lblAlertCategoria.Size = new System.Drawing.Size(0, 13);
            this.lblAlertCategoria.TabIndex = 17;
            // 
            // txtImposto
            // 
            this.txtImposto.Location = new System.Drawing.Point(317, 234);
            this.txtImposto.Name = "txtImposto";
            this.txtImposto.Size = new System.Drawing.Size(142, 20);
            this.txtImposto.TabIndex = 19;
            // 
            // lblImposto
            // 
            this.lblImposto.AutoSize = true;
            this.lblImposto.Location = new System.Drawing.Point(314, 218);
            this.lblImposto.Name = "lblImposto";
            this.lblImposto.Size = new System.Drawing.Size(111, 13);
            this.lblImposto.TabIndex = 18;
            this.lblImposto.Text = "Liquota de Imposto(%)";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(384, 269);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 20;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblAlertaEstoque
            // 
            this.lblAlertaEstoque.AutoSize = true;
            this.lblAlertaEstoque.Location = new System.Drawing.Point(317, 132);
            this.lblAlertaEstoque.Name = "lblAlertaEstoque";
            this.lblAlertaEstoque.Size = new System.Drawing.Size(0, 13);
            this.lblAlertaEstoque.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 450);
            this.Controls.Add(this.lblAlertaEstoque);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtImposto);
            this.Controls.Add(this.lblImposto);
            this.Controls.Add(this.lblAlertCategoria);
            this.Controls.Add(this.lblAlertaQuantidade);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.lblAlertaPrecoV);
            this.Controls.Add(this.txtPrecoVenda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAlertaPrecoC);
            this.Controls.Add(this.txtPrecoCusto);
            this.Controls.Add(this.lblPrecoCusto);
            this.Controls.Add(this.txtDecricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblCadastro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDecricao;
        private System.Windows.Forms.Label lblPrecoCusto;
        private System.Windows.Forms.TextBox txtPrecoCusto;
        private System.Windows.Forms.Label lblAlertaPrecoC;
        private System.Windows.Forms.Label lblAlertaPrecoV;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblAlertaQuantidade;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Label lblAlertCategoria;
        private System.Windows.Forms.TextBox txtImposto;
        private System.Windows.Forms.Label lblImposto;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblAlertaEstoque;
    }
}

