namespace MTK_Store
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMenu = new Panel();
            btnHistorico = new Button();
            btnEstoque = new Button();
            btnVendas = new Button();
            btnClientes = new Button();
            btnProdutos = new Button();
            btnInicio = new Button();
            lblNomeLoja = new Label();
            lblSubtitulo = new Label();
            pnlConteudo = new Panel();
            pnlTabelaClientes = new Panel();
            dgvClientes = new DataGridView();
            colNomeCliente = new DataGridViewTextBoxColumn();
            colTelefoneCliente = new DataGridViewTextBoxColumn();
            colEmailCliente = new DataGridViewTextBoxColumn();
            colEnderecoCliente = new DataGridViewTextBoxColumn();
            btnLimparCliente = new Button();
            btnExcluirCliente = new Button();
            btnAlterarCliente = new Button();
            btnCadastrarCliente = new Button();
            txtEnderecoCliente = new TextBox();
            txtNomeCliente = new TextBox();
            txtEmailCliente = new TextBox();
            txtTelefoneCliente = new TextBox();
            lblEnderecoCliente = new Label();
            lblEmailCliente = new Label();
            lblTelefoneCliente = new Label();
            lblNomeCliente = new Label();
            lblTituloClientes = new Label();
            pnlInicio = new Panel();
            label1lblMensagemInicio = new Label();
            lnlituloInicio = new Label();
            pnlProdutos = new Panel();
            dgvProdutos = new DataGridView();
            ColNome = new DataGridViewTextBoxColumn();
            ColCategoria = new DataGridViewTextBoxColumn();
            ColPreco = new DataGridViewTextBoxColumn();
            ColQuantidade = new DataGridViewTextBoxColumn();
            btnLimpar = new Button();
            btnExcluir = new Button();
            btnAlterar = new Button();
            btncadastrar = new Button();
            txtQuantidade = new TextBox();
            lblQuantidade = new Label();
            txtPreco = new TextBox();
            lblPreco = new Label();
            txtCategoria = new TextBox();
            lblCategoria = new Label();
            txtNomeProduto = new TextBox();
            lblNomeProduto = new Label();
            lblTituloProdutos = new Label();
            pnlMenu.SuspendLayout();
            pnlConteudo.SuspendLayout();
            pnlTabelaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            pnlInicio.SuspendLayout();
            pnlProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.PaleVioletRed;
            pnlMenu.Controls.Add(btnHistorico);
            pnlMenu.Controls.Add(btnEstoque);
            pnlMenu.Controls.Add(btnVendas);
            pnlMenu.Controls.Add(btnClientes);
            pnlMenu.Controls.Add(btnProdutos);
            pnlMenu.Controls.Add(btnInicio);
            pnlMenu.Controls.Add(lblNomeLoja);
            pnlMenu.Controls.Add(lblSubtitulo);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Margin = new Padding(3, 2, 3, 2);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(192, 920);
            pnlMenu.TabIndex = 0;
            // 
            // btnHistorico
            // 
            btnHistorico.BackColor = Color.White;
            btnHistorico.FlatStyle = FlatStyle.Flat;
            btnHistorico.ForeColor = Color.PaleVioletRed;
            btnHistorico.Location = new Point(16, 354);
            btnHistorico.Margin = new Padding(3, 2, 3, 2);
            btnHistorico.Name = "btnHistorico";
            btnHistorico.RightToLeft = RightToLeft.No;
            btnHistorico.Size = new Size(158, 30);
            btnHistorico.TabIndex = 6;
            btnHistorico.Text = "Historico";
            btnHistorico.UseVisualStyleBackColor = false;
            btnHistorico.Click += btnHistorico_Click;
            // 
            // btnEstoque
            // 
            btnEstoque.BackColor = Color.White;
            btnEstoque.FlatStyle = FlatStyle.Flat;
            btnEstoque.ForeColor = Color.PaleVioletRed;
            btnEstoque.Location = new Point(16, 296);
            btnEstoque.Margin = new Padding(3, 2, 3, 2);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Size = new Size(158, 30);
            btnEstoque.TabIndex = 5;
            btnEstoque.Text = "Estoque";
            btnEstoque.UseVisualStyleBackColor = false;
            btnEstoque.Click += btnEstoque_Click;
            // 
            // btnVendas
            // 
            btnVendas.BackColor = Color.White;
            btnVendas.FlatStyle = FlatStyle.Flat;
            btnVendas.ForeColor = Color.PaleVioletRed;
            btnVendas.Location = new Point(16, 242);
            btnVendas.Margin = new Padding(3, 2, 3, 2);
            btnVendas.Name = "btnVendas";
            btnVendas.Size = new Size(158, 30);
            btnVendas.TabIndex = 4;
            btnVendas.Text = "Vendas";
            btnVendas.UseVisualStyleBackColor = false;
            btnVendas.Click += btnVendas_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.White;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.ForeColor = Color.PaleVioletRed;
            btnClientes.Location = new Point(16, 187);
            btnClientes.Margin = new Padding(3, 2, 3, 2);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(158, 30);
            btnClientes.TabIndex = 3;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnProdutos
            // 
            btnProdutos.BackColor = Color.White;
            btnProdutos.FlatStyle = FlatStyle.Flat;
            btnProdutos.ForeColor = Color.PaleVioletRed;
            btnProdutos.Location = new Point(15, 133);
            btnProdutos.Margin = new Padding(3, 2, 3, 2);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(158, 30);
            btnProdutos.TabIndex = 2;
            btnProdutos.Text = "Produtos";
            btnProdutos.UseVisualStyleBackColor = false;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.White;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.ForeColor = Color.PaleVioletRed;
            btnInicio.Location = new Point(15, 82);
            btnInicio.Margin = new Padding(3, 2, 3, 2);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(158, 30);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // lblNomeLoja
            // 
            lblNomeLoja.AutoSize = true;
            lblNomeLoja.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeLoja.ForeColor = Color.White;
            lblNomeLoja.Location = new Point(8, 7);
            lblNomeLoja.Name = "lblNomeLoja";
            lblNomeLoja.Size = new Size(166, 37);
            lblNomeLoja.TabIndex = 0;
            lblNomeLoja.Text = "MTK STORE";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.BackColor = Color.PaleVioletRed;
            lblSubtitulo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.White;
            lblSubtitulo.Location = new Point(19, 49);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(136, 15);
            lblSubtitulo.TabIndex = 0;
            lblSubtitulo.Text = "Sistema de loja de roupa";
            // 
            // pnlConteudo
            // 
            pnlConteudo.Controls.Add(pnlTabelaClientes);
            pnlConteudo.Controls.Add(pnlInicio);
            pnlConteudo.Controls.Add(pnlProdutos);
            pnlConteudo.Dock = DockStyle.Fill;
            pnlConteudo.Location = new Point(192, 0);
            pnlConteudo.Margin = new Padding(3, 2, 3, 2);
            pnlConteudo.Name = "pnlConteudo";
            pnlConteudo.Size = new Size(1651, 920);
            pnlConteudo.TabIndex = 1;
            // 
            // pnlTabelaClientes
            // 
            pnlTabelaClientes.Controls.Add(dgvClientes);
            pnlTabelaClientes.Controls.Add(btnLimparCliente);
            pnlTabelaClientes.Controls.Add(btnExcluirCliente);
            pnlTabelaClientes.Controls.Add(btnAlterarCliente);
            pnlTabelaClientes.Controls.Add(btnCadastrarCliente);
            pnlTabelaClientes.Controls.Add(txtEnderecoCliente);
            pnlTabelaClientes.Controls.Add(txtNomeCliente);
            pnlTabelaClientes.Controls.Add(txtEmailCliente);
            pnlTabelaClientes.Controls.Add(txtTelefoneCliente);
            pnlTabelaClientes.Controls.Add(lblEnderecoCliente);
            pnlTabelaClientes.Controls.Add(lblEmailCliente);
            pnlTabelaClientes.Controls.Add(lblTelefoneCliente);
            pnlTabelaClientes.Controls.Add(lblNomeCliente);
            pnlTabelaClientes.Controls.Add(lblTituloClientes);
            pnlTabelaClientes.Dock = DockStyle.Fill;
            pnlTabelaClientes.Location = new Point(0, 0);
            pnlTabelaClientes.Name = "pnlTabelaClientes";
            pnlTabelaClientes.Size = new Size(1651, 920);
            pnlTabelaClientes.TabIndex = 2;
            pnlTabelaClientes.Visible = false;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.BackgroundColor = Color.White;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { colNomeCliente, colTelefoneCliente, colEmailCliente, colEnderecoCliente });
            dgvClientes.Location = new Point(441, 572);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(779, 348);
            dgvClientes.TabIndex = 13;
            // 
            // colNomeCliente
            // 
            colNomeCliente.HeaderText = "Nome Completo";
            colNomeCliente.Name = "colNomeCliente";
            colNomeCliente.ReadOnly = true;
            // 
            // colTelefoneCliente
            // 
            colTelefoneCliente.HeaderText = "Telefone";
            colTelefoneCliente.Name = "colTelefoneCliente";
            colTelefoneCliente.ReadOnly = true;
            // 
            // colEmailCliente
            // 
            colEmailCliente.HeaderText = "E-mail";
            colEmailCliente.Name = "colEmailCliente";
            colEmailCliente.ReadOnly = true;
            // 
            // colEnderecoCliente
            // 
            colEnderecoCliente.HeaderText = "Endereço";
            colEnderecoCliente.Name = "colEnderecoCliente";
            colEnderecoCliente.ReadOnly = true;
            // 
            // btnLimparCliente
            // 
            btnLimparCliente.BackColor = Color.PaleVioletRed;
            btnLimparCliente.FlatStyle = FlatStyle.Flat;
            btnLimparCliente.ForeColor = Color.White;
            btnLimparCliente.Location = new Point(1089, 445);
            btnLimparCliente.Name = "btnLimparCliente";
            btnLimparCliente.Size = new Size(75, 23);
            btnLimparCliente.TabIndex = 12;
            btnLimparCliente.Text = "Limpar";
            btnLimparCliente.UseVisualStyleBackColor = false;
            btnLimparCliente.Click += button4_Click;
            // 
            // btnExcluirCliente
            // 
            btnExcluirCliente.BackColor = Color.PaleVioletRed;
            btnExcluirCliente.FlatStyle = FlatStyle.Flat;
            btnExcluirCliente.ForeColor = Color.White;
            btnExcluirCliente.Location = new Point(888, 445);
            btnExcluirCliente.Name = "btnExcluirCliente";
            btnExcluirCliente.Size = new Size(75, 23);
            btnExcluirCliente.TabIndex = 11;
            btnExcluirCliente.Text = "Excluir";
            btnExcluirCliente.UseVisualStyleBackColor = false;
            // 
            // btnAlterarCliente
            // 
            btnAlterarCliente.BackColor = Color.PaleVioletRed;
            btnAlterarCliente.FlatStyle = FlatStyle.Flat;
            btnAlterarCliente.ForeColor = Color.White;
            btnAlterarCliente.Location = new Point(703, 445);
            btnAlterarCliente.Name = "btnAlterarCliente";
            btnAlterarCliente.Size = new Size(75, 23);
            btnAlterarCliente.TabIndex = 10;
            btnAlterarCliente.Text = "Alterar";
            btnAlterarCliente.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarCliente
            // 
            btnCadastrarCliente.BackColor = Color.PaleVioletRed;
            btnCadastrarCliente.FlatStyle = FlatStyle.Flat;
            btnCadastrarCliente.ForeColor = Color.White;
            btnCadastrarCliente.Location = new Point(503, 445);
            btnCadastrarCliente.Name = "btnCadastrarCliente";
            btnCadastrarCliente.Size = new Size(75, 23);
            btnCadastrarCliente.TabIndex = 9;
            btnCadastrarCliente.Text = "Cadastrar";
            btnCadastrarCliente.UseVisualStyleBackColor = false;
            btnCadastrarCliente.Click += btnCadastrarCliente_Click;
            // 
            // txtEnderecoCliente
            // 
            txtEnderecoCliente.Location = new Point(703, 257);
            txtEnderecoCliente.Name = "txtEnderecoCliente";
            txtEnderecoCliente.Size = new Size(292, 23);
            txtEnderecoCliente.TabIndex = 8;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(703, 133);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(292, 23);
            txtNomeCliente.TabIndex = 7;
            txtNomeCliente.TextChanged += textBox3_TextChanged;
            // 
            // txtEmailCliente
            // 
            txtEmailCliente.Location = new Point(703, 197);
            txtEmailCliente.Name = "txtEmailCliente";
            txtEmailCliente.Size = new Size(292, 23);
            txtEmailCliente.TabIndex = 6;
            // 
            // txtTelefoneCliente
            // 
            txtTelefoneCliente.Location = new Point(703, 323);
            txtTelefoneCliente.Name = "txtTelefoneCliente";
            txtTelefoneCliente.Size = new Size(292, 23);
            txtTelefoneCliente.TabIndex = 5;
            // 
            // lblEnderecoCliente
            // 
            lblEnderecoCliente.AutoSize = true;
            lblEnderecoCliente.Location = new Point(569, 323);
            lblEnderecoCliente.Name = "lblEnderecoCliente";
            lblEnderecoCliente.Size = new Size(59, 15);
            lblEnderecoCliente.TabIndex = 4;
            lblEnderecoCliente.Text = "Endereço:";
            // 
            // lblEmailCliente
            // 
            lblEmailCliente.AutoSize = true;
            lblEmailCliente.Location = new Point(573, 260);
            lblEmailCliente.Name = "lblEmailCliente";
            lblEmailCliente.Size = new Size(44, 15);
            lblEmailCliente.TabIndex = 3;
            lblEmailCliente.Text = "E-mail:";
            // 
            // lblTelefoneCliente
            // 
            lblTelefoneCliente.AutoSize = true;
            lblTelefoneCliente.Location = new Point(569, 200);
            lblTelefoneCliente.Name = "lblTelefoneCliente";
            lblTelefoneCliente.Size = new Size(55, 15);
            lblTelefoneCliente.TabIndex = 2;
            lblTelefoneCliente.Text = "Telefone:";
            // 
            // lblNomeCliente
            // 
            lblNomeCliente.AutoSize = true;
            lblNomeCliente.Location = new Point(557, 141);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(97, 15);
            lblNomeCliente.TabIndex = 1;
            lblNomeCliente.Text = "\tNome completo:";
            lblNomeCliente.Click += label1_Click;
            // 
            // lblTituloClientes
            // 
            lblTituloClientes.AutoSize = true;
            lblTituloClientes.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloClientes.ForeColor = Color.PaleVioletRed;
            lblTituloClientes.Location = new Point(657, 21);
            lblTituloClientes.Name = "lblTituloClientes";
            lblTituloClientes.Size = new Size(261, 37);
            lblTituloClientes.TabIndex = 0;
            lblTituloClientes.Text = "Cadastro de Clientes";
            // 
            // pnlInicio
            // 
            pnlInicio.Controls.Add(label1lblMensagemInicio);
            pnlInicio.Controls.Add(lnlituloInicio);
            pnlInicio.Dock = DockStyle.Fill;
            pnlInicio.Location = new Point(0, 0);
            pnlInicio.Name = "pnlInicio";
            pnlInicio.Size = new Size(1651, 920);
            pnlInicio.TabIndex = 15;
            // 
            // label1lblMensagemInicio
            // 
            label1lblMensagemInicio.AutoSize = true;
            label1lblMensagemInicio.ForeColor = SystemColors.GrayText;
            label1lblMensagemInicio.Location = new Point(687, 82);
            label1lblMensagemInicio.Name = "label1lblMensagemInicio";
            label1lblMensagemInicio.Size = new Size(219, 15);
            label1lblMensagemInicio.TabIndex = 1;
            label1lblMensagemInicio.Text = "Seu espaço de moda, estilo e novidades!";
            // 
            // lnlituloInicio
            // 
            lnlituloInicio.AutoSize = true;
            lnlituloInicio.BackColor = Color.Transparent;
            lnlituloInicio.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnlituloInicio.ForeColor = Color.PaleVioletRed;
            lnlituloInicio.Location = new Point(618, 15);
            lnlituloInicio.Name = "lnlituloInicio";
            lnlituloInicio.Size = new Size(363, 45);
            lnlituloInicio.TabIndex = 0;
            lnlituloInicio.Text = "Bem-vinda à MTK Store!";
            // 
            // pnlProdutos
            // 
            pnlProdutos.Controls.Add(dgvProdutos);
            pnlProdutos.Controls.Add(btnLimpar);
            pnlProdutos.Controls.Add(btnExcluir);
            pnlProdutos.Controls.Add(btnAlterar);
            pnlProdutos.Controls.Add(btncadastrar);
            pnlProdutos.Controls.Add(txtQuantidade);
            pnlProdutos.Controls.Add(lblQuantidade);
            pnlProdutos.Controls.Add(txtPreco);
            pnlProdutos.Controls.Add(lblPreco);
            pnlProdutos.Controls.Add(txtCategoria);
            pnlProdutos.Controls.Add(lblCategoria);
            pnlProdutos.Controls.Add(txtNomeProduto);
            pnlProdutos.Controls.Add(lblNomeProduto);
            pnlProdutos.Controls.Add(lblTituloProdutos);
            pnlProdutos.Dock = DockStyle.Fill;
            pnlProdutos.Location = new Point(0, 0);
            pnlProdutos.Margin = new Padding(3, 2, 3, 2);
            pnlProdutos.Name = "pnlProdutos";
            pnlProdutos.Size = new Size(1651, 920);
            pnlProdutos.TabIndex = 0;
            pnlProdutos.Paint += pnlProdutos_Paint;
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProdutos.BackgroundColor = Color.White;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { ColNome, ColCategoria, ColPreco, ColQuantidade });
            dgvProdutos.Location = new Point(117, 455);
            dgvProdutos.Margin = new Padding(3, 2, 3, 2);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.RowHeadersWidth = 51;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.Size = new Size(1417, 258);
            dgvProdutos.TabIndex = 14;
            dgvProdutos.CellContentClick += dgvProdutos_CellContentClick;
            // 
            // ColNome
            // 
            ColNome.HeaderText = "Nome";
            ColNome.MinimumWidth = 6;
            ColNome.Name = "ColNome";
            ColNome.ReadOnly = true;
            // 
            // ColCategoria
            // 
            ColCategoria.HeaderText = "Categoria";
            ColCategoria.MinimumWidth = 6;
            ColCategoria.Name = "ColCategoria";
            ColCategoria.ReadOnly = true;
            // 
            // ColPreco
            // 
            ColPreco.HeaderText = "Preço";
            ColPreco.MinimumWidth = 6;
            ColPreco.Name = "ColPreco";
            ColPreco.ReadOnly = true;
            // 
            // ColQuantidade
            // 
            ColQuantidade.HeaderText = "Quantidade";
            ColQuantidade.MinimumWidth = 6;
            ColQuantidade.Name = "ColQuantidade";
            ColQuantidade.ReadOnly = true;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.PaleVioletRed;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(1307, 382);
            btnLimpar.Margin = new Padding(3, 2, 3, 2);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(96, 30);
            btnLimpar.TabIndex = 13;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.PaleVioletRed;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(975, 382);
            btnExcluir.Margin = new Padding(3, 2, 3, 2);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(96, 30);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.PaleVioletRed;
            btnAlterar.FlatStyle = FlatStyle.Flat;
            btnAlterar.ForeColor = Color.White;
            btnAlterar.Location = new Point(618, 382);
            btnAlterar.Margin = new Padding(3, 2, 3, 2);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(96, 30);
            btnAlterar.TabIndex = 11;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btncadastrar
            // 
            btncadastrar.BackColor = Color.PaleVioletRed;
            btncadastrar.FlatStyle = FlatStyle.Flat;
            btncadastrar.ForeColor = Color.White;
            btncadastrar.Location = new Point(263, 382);
            btncadastrar.Margin = new Padding(3, 2, 3, 2);
            btncadastrar.Name = "btncadastrar";
            btncadastrar.Size = new Size(96, 30);
            btncadastrar.TabIndex = 10;
            btncadastrar.Text = "Cadastrar";
            btncadastrar.UseVisualStyleBackColor = false;
            btncadastrar.Click += btncadastrar_Click;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(202, 252);
            txtQuantidade.Margin = new Padding(3, 2, 3, 2);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(178, 23);
            txtQuantidade.TabIndex = 9;
            txtQuantidade.TextChanged += txtQuantidade_TextChanged;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(35, 257);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(137, 15);
            lblQuantidade.TabIndex = 8;
            lblQuantidade.Text = "Quantidade em estoque:";
            lblQuantidade.Click += lblQuantidade_Click;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(202, 192);
            txtPreco.Margin = new Padding(3, 2, 3, 2);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(178, 23);
            txtPreco.TabIndex = 7;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(35, 194);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(115, 15);
            lblPreco.TabIndex = 6;
            lblPreco.Text = "Preço de venda (R$):";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(202, 133);
            txtCategoria.Margin = new Padding(3, 2, 3, 2);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(178, 23);
            txtCategoria.TabIndex = 5;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(35, 133);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(61, 15);
            lblCategoria.TabIndex = 4;
            lblCategoria.Text = "Categoria:";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(202, 82);
            txtNomeProduto.Margin = new Padding(3, 2, 3, 2);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(178, 23);
            txtNomeProduto.TabIndex = 2;
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.AutoSize = true;
            lblNomeProduto.Location = new Point(35, 82);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(89, 15);
            lblNomeProduto.TabIndex = 1;
            lblNomeProduto.Text = "Nome produto:";
            // 
            // lblTituloProdutos
            // 
            lblTituloProdutos.AutoSize = true;
            lblTituloProdutos.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloProdutos.ForeColor = Color.PaleVioletRed;
            lblTituloProdutos.Location = new Point(22, 15);
            lblTituloProdutos.Name = "lblTituloProdutos";
            lblTituloProdutos.Size = new Size(296, 37);
            lblTituloProdutos.TabIndex = 0;
            lblTituloProdutos.Text = "Cadastro de Produtos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1843, 920);
            Controls.Add(pnlConteudo);
            Controls.Add(pnlMenu);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(877, 460);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MTK Store - Sistema de Gerenciamento";
            WindowState = FormWindowState.Maximized;
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            pnlConteudo.ResumeLayout(false);
            pnlTabelaClientes.ResumeLayout(false);
            pnlTabelaClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            pnlInicio.ResumeLayout(false);
            pnlInicio.PerformLayout();
            pnlProdutos.ResumeLayout(false);
            pnlProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Panel pnlConteudo;
        private Label lblSubtitulo;
        private Label lblNomeLoja;
        private Button btnInicio;
        private Button btnEstoque;
        private Button btnVendas;
        private Button btnClientes;
        private Button btnProdutos;
        private Button btnHistorico;
        private Panel pnlProdutos;
        private Label lblTituloProdutos;
        private TextBox txtNomeProduto;
        private Label lblNomeProduto;
        private Label lblCategoria;
        private TextBox txtPreco;
        private Label lblPreco;
        private TextBox txtCategoria;
        private TextBox txtQuantidade;
        private Label lblQuantidade;
        private Button btnLimpar;
        private Button btnExcluir;
        private Button btnAlterar;
        private Button btncadastrar;
        private DataGridView dgvProdutos;
        private DataGridViewTextBoxColumn ColNome;
        private DataGridViewTextBoxColumn ColCategoria;
        private DataGridViewTextBoxColumn ColPreco;
        private DataGridViewTextBoxColumn ColQuantidade;
        private Panel pnlInicio;
        private Label lnlituloInicio;
        private Label label1lblMensagemInicio;
        private Panel pnlTabelaClientes;
        private Label lblTituloClientes;
        private TextBox txtEnderecoCliente;
        private TextBox txtNomeCliente;
        private TextBox txtEmailCliente;
        private TextBox txtTelefoneCliente;
        private Label lblEnderecoCliente;
        private Label lblEmailCliente;
        private Label lblTelefoneCliente;
        private Label lblNomeCliente;
        private Button btnCadastrarCliente;
        private Button btnLimparCliente;
        private Button btnExcluirCliente;
        private Button btnAlterarCliente;
        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn colNomeCliente;
        private DataGridViewTextBoxColumn colTelefoneCliente;
        private DataGridViewTextBoxColumn colEmailCliente;
        private DataGridViewTextBoxColumn colEnderecoCliente;
    }
}
