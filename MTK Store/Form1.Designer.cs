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
            pnlProdutos = new Panel();
            dgvProdutos = new DataGridView();
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
            ColNome = new DataGridViewTextBoxColumn();
            ColCategoria = new DataGridViewTextBoxColumn();
            ColPreco = new DataGridViewTextBoxColumn();
            ColQuantidade = new DataGridViewTextBoxColumn();
            pnlMenu.SuspendLayout();
            pnlConteudo.SuspendLayout();
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
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(220, 553);
            pnlMenu.TabIndex = 0;
            // 
            // btnHistorico
            // 
            btnHistorico.BackColor = Color.White;
            btnHistorico.FlatStyle = FlatStyle.Flat;
            btnHistorico.ForeColor = Color.PaleVioletRed;
            btnHistorico.Location = new Point(17, 414);
            btnHistorico.Name = "btnHistorico";
            btnHistorico.RightToLeft = RightToLeft.No;
            btnHistorico.Size = new Size(180, 40);
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
            btnEstoque.Location = new Point(17, 353);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Size = new Size(180, 40);
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
            btnVendas.Location = new Point(17, 292);
            btnVendas.Name = "btnVendas";
            btnVendas.Size = new Size(180, 40);
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
            btnClientes.Location = new Point(17, 232);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(180, 40);
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
            btnProdutos.Location = new Point(17, 170);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(180, 40);
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
            btnInicio.Location = new Point(17, 110);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(180, 40);
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
            lblNomeLoja.Location = new Point(9, 9);
            lblNomeLoja.Name = "lblNomeLoja";
            lblNomeLoja.Size = new Size(208, 46);
            lblNomeLoja.TabIndex = 0;
            lblNomeLoja.Text = "MTK STORE";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.BackColor = Color.PaleVioletRed;
            lblSubtitulo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.White;
            lblSubtitulo.Location = new Point(22, 65);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(175, 20);
            lblSubtitulo.TabIndex = 0;
            lblSubtitulo.Text = "Sistema de loja de roupa";
            // 
            // pnlConteudo
            // 
            pnlConteudo.Controls.Add(pnlProdutos);
            pnlConteudo.Dock = DockStyle.Fill;
            pnlConteudo.Location = new Point(220, 0);
            pnlConteudo.Name = "pnlConteudo";
            pnlConteudo.Size = new Size(762, 553);
            pnlConteudo.TabIndex = 1;
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
            pnlProdutos.Name = "pnlProdutos";
            pnlProdutos.Size = new Size(762, 553);
            pnlProdutos.TabIndex = 0;
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProdutos.BackgroundColor = Color.White;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { ColNome, ColCategoria, ColPreco, ColQuantidade });
            dgvProdutos.Location = new Point(114, 451);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.RowHeadersWidth = 51;
            dgvProdutos.Size = new Size(527, 90);
            dgvProdutos.TabIndex = 14;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.PaleVioletRed;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(583, 399);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(110, 40);
            btnLimpar.TabIndex = 13;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.PaleVioletRed;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(402, 399);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(110, 40);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.PaleVioletRed;
            btnAlterar.FlatStyle = FlatStyle.Flat;
            btnAlterar.ForeColor = Color.White;
            btnAlterar.Location = new Point(231, 399);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(110, 40);
            btnAlterar.TabIndex = 11;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btncadastrar
            // 
            btncadastrar.BackColor = Color.PaleVioletRed;
            btncadastrar.FlatStyle = FlatStyle.Flat;
            btncadastrar.ForeColor = Color.White;
            btncadastrar.Location = new Point(62, 399);
            btncadastrar.Name = "btncadastrar";
            btncadastrar.Size = new Size(110, 40);
            btncadastrar.TabIndex = 10;
            btncadastrar.Text = "Cadastrar";
            btncadastrar.UseVisualStyleBackColor = false;
            btncadastrar.Click += btncadastrar_Click;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(231, 336);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(203, 27);
            txtQuantidade.TabIndex = 9;
            txtQuantidade.TextChanged += txtQuantidade_TextChanged;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(40, 343);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(172, 20);
            lblQuantidade.TabIndex = 8;
            lblQuantidade.Text = "Quantidade em estoque:";
            lblQuantidade.Click += lblQuantidade_Click;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(231, 256);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(203, 27);
            txtPreco.TabIndex = 7;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(40, 259);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(145, 20);
            lblPreco.TabIndex = 6;
            lblPreco.Text = "Preço de venda (R$):";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(231, 177);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(203, 27);
            txtCategoria.TabIndex = 5;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(40, 177);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(77, 20);
            lblCategoria.TabIndex = 4;
            lblCategoria.Text = "Categoria:";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(231, 110);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(203, 27);
            txtNomeProduto.TabIndex = 2;
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.AutoSize = true;
            lblNomeProduto.Location = new Point(40, 110);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(111, 20);
            lblNomeProduto.TabIndex = 1;
            lblNomeProduto.Text = "Nome produto:";
            // 
            // lblTituloProdutos
            // 
            lblTituloProdutos.AutoSize = true;
            lblTituloProdutos.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloProdutos.ForeColor = Color.PaleVioletRed;
            lblTituloProdutos.Location = new Point(25, 20);
            lblTituloProdutos.Name = "lblTituloProdutos";
            lblTituloProdutos.Size = new Size(365, 46);
            lblTituloProdutos.TabIndex = 0;
            lblTituloProdutos.Text = "Cadastro de Produtos";
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(982, 553);
            Controls.Add(pnlConteudo);
            Controls.Add(pnlMenu);
            MinimumSize = new Size(1000, 600);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MTK Store - Sistema de Gerenciamento";
            WindowState = FormWindowState.Maximized;
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            pnlConteudo.ResumeLayout(false);
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
    }
}
