
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

            pnlProdutos.Visible = false;
            pnlTabelaClientes.Visible = false;

            pnlInicio.Visible = true;
            pnlInicio.BringToFront();
        }

        // NAVEGAÇÃO

        private void btnInicio_Click(object sender, EventArgs e)
        {
            pnlProdutos.Visible = false;
            pnlTabelaClientes.Visible = false;

            pnlInicio.Visible = true;
            pnlInicio.BringToFront();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            pnlInicio.Visible = false;
            pnlTabelaClientes.Visible = false;

            pnlProdutos.Visible = true;
            pnlProdutos.BringToFront();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            pnlInicio.Visible = false;
            pnlProdutos.Visible = false;

            pnlTabelaClientes.Visible = true;
            pnlTabelaClientes.BringToFront();
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

        // CADASTRO DE PRODUTOS

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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um produto na tabela!");
                return;
            }

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
                return;
            }

            int quantidade;

            if (!int.TryParse(txtQuantidade.Text, out quantidade) ||
                quantidade < 0)
            {
                MessageBox.Show("Digite uma quantidade válida!");
                return;
            }

            DataGridViewRow linha = dgvProdutos.SelectedRows[0];

            linha.Cells["colNome"].Value = nome;
            linha.Cells["ColCategoria"].Value = categoria;
            linha.Cells["ColPreco"].Value = preco.ToString(
                "C2", CultureInfo.GetCultureInfo("pt-BR"));
            linha.Cells["ColQuantidade"].Value = quantidade;

            MessageBox.Show("Produto alterado com sucesso!");

            txtNomeProduto.Clear();
            txtCategoria.Clear();
            txtPreco.Clear();
            txtQuantidade.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um produto para excluir!");
                return;
            }

            DialogResult resposta = MessageBox.Show(
                "Tem certeza que deseja excluir este produto?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta == DialogResult.Yes)
            {
                dgvProdutos.Rows.Remove(dgvProdutos.SelectedRows[0]);

                MessageBox.Show("Produto excluído com sucesso!");

                txtNomeProduto.Clear();
                txtCategoria.Clear();
                txtPreco.Clear();
                txtQuantidade.Clear();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeProduto.Clear();
            txtCategoria.Clear();
            txtPreco.Clear();
            txtQuantidade.Clear();

            txtNomeProduto.Focus();
        }

        private void pnlProdutos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        // CADASTRO DE CLIENTES

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            string nome = txtNomeCliente.Text.Trim();
            string telefone = txtTelefoneCliente.Text.Trim();
            string email = txtEmailCliente.Text.Trim();
            string endereco = txtEnderecoCliente.Text.Trim();

            if (nome == "" || telefone == "" ||
                email == "" || endereco == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            dgvClientes.Rows.Add(
                nome,
                telefone,
                email,
                endereco
            );

            MessageBox.Show("Cliente cadastrado com sucesso!");

            LimparCamposCliente();
        }

        private void btnAlterarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um cliente na tabela!");
                return;
            }

            string nome = txtNomeCliente.Text.Trim();
            string telefone = txtTelefoneCliente.Text.Trim();
            string email = txtEmailCliente.Text.Trim();
            string endereco = txtEnderecoCliente.Text.Trim();

            if (nome == "" || telefone == "" ||
                email == "" || endereco == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            DataGridViewRow linha = dgvClientes.SelectedRows[0];

            linha.Cells["colNomeCliente"].Value = nome;
            linha.Cells["colTelefoneCliente"].Value = telefone;
            linha.Cells["colEmailCliente"].Value = email;
            linha.Cells["colEnderecoCliente"].Value = endereco;

            MessageBox.Show("Cliente alterado com sucesso!");

            LimparCamposCliente();
        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um cliente para excluir!");
                return;
            }

            DialogResult resposta = MessageBox.Show(
                "Tem certeza que deseja excluir este cliente?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta == DialogResult.Yes)
            {
                dgvClientes.Rows.Remove(dgvClientes.SelectedRows[0]);

                MessageBox.Show("Cliente excluído com sucesso!");

                LimparCamposCliente();
            }
        }

        private void btnLimparCliente_Click(object sender, EventArgs e)
        {
            LimparCamposCliente();
        }

        // LIMPAR CAMPOS DE CLIENTES

        private void LimparCamposCliente()
        {
            txtNomeCliente.Clear();
            txtTelefoneCliente.Clear();
            txtEmailCliente.Clear();
            txtEnderecoCliente.Clear();

            txtNomeCliente.Focus();
        }
    }
}
