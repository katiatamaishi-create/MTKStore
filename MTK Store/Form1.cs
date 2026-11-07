
using System;
using System.Globalization;
using System.Windows.Forms;

namespace MTK_Store
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bem-vindo à MTK Store");
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Área de Produtos");
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Área de Clientes");
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Área de Vendas");
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Área de Estoque");
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Histórico de Vendas");
        }

        private void lblQuantidade_Click(object sender, EventArgs e)
        {

        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeProduto.Text.Trim();
            string categoria = txtCategoria.Text.Trim();

            if (nome == "" || categoria == "" ||
                txtPreco.Text.Trim() == "" ||
                txtQuantidade.Text.Trim() == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            decimal preco;

            if (!decimal.TryParse(
                txtPreco.Text,
                NumberStyles.Number,
                CultureInfo.GetCultureInfo("pt-BR"),
                out preco) || preco <= 0)
            {
                MessageBox.Show("Digite um preço válido!");
                txtPreco.Focus();
                return;
            }

            int quantidade;

            if (!int.TryParse(txtQuantidade.Text, out quantidade) ||
                quantidade < 0)
            {
                MessageBox.Show("Digite uma quantidade válida!");
                txtQuantidade.Focus();
                return;
            }

            dgvProdutos.Rows.Add(
            nome,
            categoria,
            preco.ToString("C2", CultureInfo.GetCultureInfo("pt-BR")),
            quantidade
            );

            MessageBox.Show("Produto cadastrado com sucesso!");

            txtNomeProduto.Clear();
            txtCategoria.Clear();
            txtPreco.Clear();
            txtQuantidade.Clear();

            txtNomeProduto.Focus();
        }
    }
}
