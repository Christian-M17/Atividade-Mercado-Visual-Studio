using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaborVida
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            float custo = float.Parse(txtPrecoCusto.Text);
            float venda = float.Parse(txtPrecoVenda.Text);
            string categoria = cmbCategoria.Text;
            int estoque = int.Parse(txtEstoque.Text);
            int quantidade = int.Parse(txtQuantidade.Text);
            float valorImposto;
            int imposto = int.Parse(txtImposto.Text);
            int erros = 0;
            if (estoque < 0)
            {
                lblAlertaEstoque.Text = "Estoque não pode ser menor que 0";
                erros = erros + 1;
            }
            if (custo < 0) {
                lblAlertaPrecoC.Text = "Custo não pode ser menor que 0";
                erros = erros + 1;
            }

            if (venda < custo)
            {
                lblAlertaPrecoV.Text = "Preço de venda não pode ser menor que o de custo!";
                erros = erros + 1;
            }
            if (quantidade >estoque)
            {
                lblAlertaQuantidade.Text = "Quantidade não pode ser maior que o estoque minimo";
                erros = erros + 1;
            }

            if (categoria == "Edite")
            {
                lblAlertCategoria.Text = "Vazio";
                erros = erros + 1;
            }
            if (erros == 0)
            {
                valorImposto = (venda * quantidade * 100) / imposto;
                MessageBox.Show("Produto cadastrado com sucesso! Valor do imposto:R$" + valorImposto);
            }
        }
            
    }
}
