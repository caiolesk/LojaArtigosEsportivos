namespace LojaArtigosEsportivos
{
    partial class NovaVenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovaVenda));
            this.efetuaVendaLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.novoProdutoBtn = new System.Windows.Forms.Button();
            this.formaPagamentoCbx = new System.Windows.Forms.ComboBox();
            this.formaPagamentoLbl = new System.Windows.Forms.Label();
            this.panielAtributosVenda = new System.Windows.Forms.Panel();
            this.precoProdVendaTbx = new System.Windows.Forms.TextBox();
            this.descontoVendaTbx = new System.Windows.Forms.TextBox();
            this.quantidadeVendaTbx = new System.Windows.Forms.TextBox();
            this.precoProdutoLbl = new System.Windows.Forms.Label();
            this.descontoLbl = new System.Windows.Forms.Label();
            this.quantidadeLbl = new System.Windows.Forms.Label();
            this.produtoTbx = new System.Windows.Forms.TextBox();
            this.produtoLbl = new System.Windows.Forms.Label();
            this.consultaProdutoVendaGridView = new System.Windows.Forms.DataGridView();
            this.valorTotalVendaReaisLbl = new System.Windows.Forms.Label();
            this.dataVendaLbl = new System.Windows.Forms.Label();
            this.dataVendaTbx = new System.Windows.Forms.TextBox();
            this.excluirCarrinhoBtn = new System.Windows.Forms.Button();
            this.avisoLbl = new System.Windows.Forms.Label();
            this.cancelarTelaVendaBtn = new System.Windows.Forms.Button();
            this.finalizaVendaBtn = new System.Windows.Forms.Button();
            this.valorTotalVendaLbl = new System.Windows.Forms.Label();
            this.consultaCarrinhoVendaGridView = new System.Windows.Forms.DataGridView();
            this.id_produtoEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoProdutoComDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade_estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeClienteVendaTbx = new System.Windows.Forms.TextBox();
            this.localizaClienteBtn = new System.Windows.Forms.Button();
            this.nomeClienteVendaLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panielAtributosVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultaProdutoVendaGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaCarrinhoVendaGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // efetuaVendaLbl
            // 
            this.efetuaVendaLbl.AutoSize = true;
            this.efetuaVendaLbl.BackColor = System.Drawing.Color.Transparent;
            this.efetuaVendaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efetuaVendaLbl.Location = new System.Drawing.Point(471, 9);
            this.efetuaVendaLbl.Name = "efetuaVendaLbl";
            this.efetuaVendaLbl.Size = new System.Drawing.Size(190, 29);
            this.efetuaVendaLbl.TabIndex = 19;
            this.efetuaVendaLbl.Text = "Efetuar Vendas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.novoProdutoBtn);
            this.panel1.Controls.Add(this.formaPagamentoCbx);
            this.panel1.Controls.Add(this.formaPagamentoLbl);
            this.panel1.Controls.Add(this.panielAtributosVenda);
            this.panel1.Controls.Add(this.produtoTbx);
            this.panel1.Controls.Add(this.produtoLbl);
            this.panel1.Controls.Add(this.consultaProdutoVendaGridView);
            this.panel1.Controls.Add(this.valorTotalVendaReaisLbl);
            this.panel1.Controls.Add(this.dataVendaLbl);
            this.panel1.Controls.Add(this.dataVendaTbx);
            this.panel1.Controls.Add(this.excluirCarrinhoBtn);
            this.panel1.Controls.Add(this.avisoLbl);
            this.panel1.Controls.Add(this.cancelarTelaVendaBtn);
            this.panel1.Controls.Add(this.finalizaVendaBtn);
            this.panel1.Controls.Add(this.valorTotalVendaLbl);
            this.panel1.Controls.Add(this.consultaCarrinhoVendaGridView);
            this.panel1.Controls.Add(this.nomeClienteVendaTbx);
            this.panel1.Controls.Add(this.localizaClienteBtn);
            this.panel1.Controls.Add(this.nomeClienteVendaLbl);
            this.panel1.Location = new System.Drawing.Point(9, 44);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 673);
            this.panel1.TabIndex = 20;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // novoProdutoBtn
            // 
            this.novoProdutoBtn.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.novoProdutoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.novoProdutoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novoProdutoBtn.Image = global::LojaArtigosEsportivos.Properties.Resources.add_goods;
            this.novoProdutoBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.novoProdutoBtn.Location = new System.Drawing.Point(76, 107);
            this.novoProdutoBtn.Name = "novoProdutoBtn";
            this.novoProdutoBtn.Size = new System.Drawing.Size(56, 64);
            this.novoProdutoBtn.TabIndex = 118;
            this.novoProdutoBtn.Text = "Novo Produto";
            this.novoProdutoBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.novoProdutoBtn.UseVisualStyleBackColor = false;
            this.novoProdutoBtn.Visible = false;
            this.novoProdutoBtn.Click += new System.EventHandler(this.novoProdutoBtn_Click);
            // 
            // formaPagamentoCbx
            // 
            this.formaPagamentoCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formaPagamentoCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formaPagamentoCbx.Items.AddRange(new object[] {
            "Dinheiro",
            "Crédito",
            "Débito",
            "Cheque"});
            this.formaPagamentoCbx.Location = new System.Drawing.Point(678, 74);
            this.formaPagamentoCbx.Name = "formaPagamentoCbx";
            this.formaPagamentoCbx.Size = new System.Drawing.Size(122, 26);
            this.formaPagamentoCbx.TabIndex = 117;
            // 
            // formaPagamentoLbl
            // 
            this.formaPagamentoLbl.AutoSize = true;
            this.formaPagamentoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formaPagamentoLbl.Location = new System.Drawing.Point(496, 77);
            this.formaPagamentoLbl.Name = "formaPagamentoLbl";
            this.formaPagamentoLbl.Size = new System.Drawing.Size(182, 18);
            this.formaPagamentoLbl.TabIndex = 116;
            this.formaPagamentoLbl.Text = "Forma de Pagamento*:";
            // 
            // panielAtributosVenda
            // 
            this.panielAtributosVenda.BackColor = System.Drawing.Color.White;
            this.panielAtributosVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panielAtributosVenda.Controls.Add(this.precoProdVendaTbx);
            this.panielAtributosVenda.Controls.Add(this.descontoVendaTbx);
            this.panielAtributosVenda.Controls.Add(this.quantidadeVendaTbx);
            this.panielAtributosVenda.Controls.Add(this.precoProdutoLbl);
            this.panielAtributosVenda.Controls.Add(this.descontoLbl);
            this.panielAtributosVenda.Controls.Add(this.quantidadeLbl);
            this.panielAtributosVenda.Location = new System.Drawing.Point(600, 107);
            this.panielAtributosVenda.Name = "panielAtributosVenda";
            this.panielAtributosVenda.Size = new System.Drawing.Size(224, 149);
            this.panielAtributosVenda.TabIndex = 114;
            this.panielAtributosVenda.Visible = false;
            // 
            // precoProdVendaTbx
            // 
            this.precoProdVendaTbx.Enabled = false;
            this.precoProdVendaTbx.Location = new System.Drawing.Point(117, 94);
            this.precoProdVendaTbx.Name = "precoProdVendaTbx";
            this.precoProdVendaTbx.Size = new System.Drawing.Size(102, 20);
            this.precoProdVendaTbx.TabIndex = 5;
            this.precoProdVendaTbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precoProdVendaTbx_KeyPress);
            // 
            // descontoVendaTbx
            // 
            this.descontoVendaTbx.Enabled = false;
            this.descontoVendaTbx.Location = new System.Drawing.Point(117, 53);
            this.descontoVendaTbx.Name = "descontoVendaTbx";
            this.descontoVendaTbx.Size = new System.Drawing.Size(47, 20);
            this.descontoVendaTbx.TabIndex = 4;
            this.descontoVendaTbx.Text = "0";
            this.descontoVendaTbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.descontoVendaTbx_KeyPress);
            // 
            // quantidadeVendaTbx
            // 
            this.quantidadeVendaTbx.Enabled = false;
            this.quantidadeVendaTbx.Location = new System.Drawing.Point(117, 12);
            this.quantidadeVendaTbx.Name = "quantidadeVendaTbx";
            this.quantidadeVendaTbx.Size = new System.Drawing.Size(82, 20);
            this.quantidadeVendaTbx.TabIndex = 3;
            this.quantidadeVendaTbx.Text = "1";
            this.quantidadeVendaTbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantidadeVendaTbx_KeyPress);
            // 
            // precoProdutoLbl
            // 
            this.precoProdutoLbl.AutoSize = true;
            this.precoProdutoLbl.Location = new System.Drawing.Point(7, 97);
            this.precoProdutoLbl.Name = "precoProdutoLbl";
            this.precoProdutoLbl.Size = new System.Drawing.Size(104, 13);
            this.precoProdutoLbl.TabIndex = 2;
            this.precoProdutoLbl.Text = "PREÇO PRODUTO:";
            // 
            // descontoLbl
            // 
            this.descontoLbl.AutoSize = true;
            this.descontoLbl.Location = new System.Drawing.Point(30, 56);
            this.descontoLbl.Name = "descontoLbl";
            this.descontoLbl.Size = new System.Drawing.Size(81, 13);
            this.descontoLbl.TabIndex = 1;
            this.descontoLbl.Text = "DESCONTO %:";
            // 
            // quantidadeLbl
            // 
            this.quantidadeLbl.AutoSize = true;
            this.quantidadeLbl.Location = new System.Drawing.Point(30, 15);
            this.quantidadeLbl.Name = "quantidadeLbl";
            this.quantidadeLbl.Size = new System.Drawing.Size(81, 13);
            this.quantidadeLbl.TabIndex = 0;
            this.quantidadeLbl.Text = "QUANTIDADE:";
            // 
            // produtoTbx
            // 
            this.produtoTbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.produtoTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produtoTbx.Location = new System.Drawing.Point(138, 74);
            this.produtoTbx.Multiline = true;
            this.produtoTbx.Name = "produtoTbx";
            this.produtoTbx.Size = new System.Drawing.Size(275, 27);
            this.produtoTbx.TabIndex = 113;
            this.produtoTbx.TextChanged += new System.EventHandler(this.produtoTbx_TextChanged);
            // 
            // produtoLbl
            // 
            this.produtoLbl.AutoSize = true;
            this.produtoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produtoLbl.Location = new System.Drawing.Point(44, 77);
            this.produtoLbl.Name = "produtoLbl";
            this.produtoLbl.Size = new System.Drawing.Size(85, 18);
            this.produtoLbl.TabIndex = 112;
            this.produtoLbl.Text = "Produto *:";
            // 
            // consultaProdutoVendaGridView
            // 
            this.consultaProdutoVendaGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.consultaProdutoVendaGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.consultaProdutoVendaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consultaProdutoVendaGridView.GridColor = System.Drawing.Color.Silver;
            this.consultaProdutoVendaGridView.Location = new System.Drawing.Point(138, 107);
            this.consultaProdutoVendaGridView.Name = "consultaProdutoVendaGridView";
            this.consultaProdutoVendaGridView.ReadOnly = true;
            this.consultaProdutoVendaGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.consultaProdutoVendaGridView.RowHeadersVisible = false;
            this.consultaProdutoVendaGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.consultaProdutoVendaGridView.Size = new System.Drawing.Size(463, 149);
            this.consultaProdutoVendaGridView.TabIndex = 111;
            this.consultaProdutoVendaGridView.Visible = false;
            this.consultaProdutoVendaGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.consultaProdutoVendaGridView_CellClick_1);
            this.consultaProdutoVendaGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.consultaProdutoVendaGridView_CellDoubleClick);
            this.consultaProdutoVendaGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.consultaProdutoVendaGridView_CellEnter);
            this.consultaProdutoVendaGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.consultaProdutoVendaGridView_RowHeaderMouseClick);
            this.consultaProdutoVendaGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.consultaProdutoVendaGridView_KeyPress);
            // 
            // valorTotalVendaReaisLbl
            // 
            this.valorTotalVendaReaisLbl.AutoSize = true;
            this.valorTotalVendaReaisLbl.Font = new System.Drawing.Font("Arial", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorTotalVendaReaisLbl.Location = new System.Drawing.Point(419, 577);
            this.valorTotalVendaReaisLbl.Name = "valorTotalVendaReaisLbl";
            this.valorTotalVendaReaisLbl.Size = new System.Drawing.Size(51, 55);
            this.valorTotalVendaReaisLbl.TabIndex = 109;
            this.valorTotalVendaReaisLbl.Text = "0";
            // 
            // dataVendaLbl
            // 
            this.dataVendaLbl.AutoSize = true;
            this.dataVendaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataVendaLbl.Location = new System.Drawing.Point(616, 26);
            this.dataVendaLbl.Name = "dataVendaLbl";
            this.dataVendaLbl.Size = new System.Drawing.Size(120, 18);
            this.dataVendaLbl.TabIndex = 104;
            this.dataVendaLbl.Text = "Data da venda:";
            // 
            // dataVendaTbx
            // 
            this.dataVendaTbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataVendaTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataVendaTbx.Location = new System.Drawing.Point(745, 21);
            this.dataVendaTbx.Multiline = true;
            this.dataVendaTbx.Name = "dataVendaTbx";
            this.dataVendaTbx.ReadOnly = true;
            this.dataVendaTbx.Size = new System.Drawing.Size(123, 28);
            this.dataVendaTbx.TabIndex = 103;
            this.dataVendaTbx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // excluirCarrinhoBtn
            // 
            this.excluirCarrinhoBtn.BackColor = System.Drawing.Color.Teal;
            this.excluirCarrinhoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.excluirCarrinhoBtn.FlatAppearance.BorderSize = 0;
            this.excluirCarrinhoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluirCarrinhoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirCarrinhoBtn.ForeColor = System.Drawing.Color.White;
            this.excluirCarrinhoBtn.Location = new System.Drawing.Point(830, 107);
            this.excluirCarrinhoBtn.Name = "excluirCarrinhoBtn";
            this.excluirCarrinhoBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.excluirCarrinhoBtn.Size = new System.Drawing.Size(123, 64);
            this.excluirCarrinhoBtn.TabIndex = 102;
            this.excluirCarrinhoBtn.Text = "Excluir do Carrinho";
            this.excluirCarrinhoBtn.UseVisualStyleBackColor = false;
            this.excluirCarrinhoBtn.Click += new System.EventHandler(this.excluirCarrinhoBtn_Click);
            // 
            // avisoLbl
            // 
            this.avisoLbl.AutoSize = true;
            this.avisoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avisoLbl.Location = new System.Drawing.Point(52, 158);
            this.avisoLbl.Name = "avisoLbl";
            this.avisoLbl.Size = new System.Drawing.Size(380, 16);
            this.avisoLbl.TabIndex = 101;
            this.avisoLbl.Text = "[*]Todos os campos com asteriscos são obrigatórios.";
            // 
            // cancelarTelaVendaBtn
            // 
            this.cancelarTelaVendaBtn.BackColor = System.Drawing.Color.Teal;
            this.cancelarTelaVendaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelarTelaVendaBtn.FlatAppearance.BorderSize = 0;
            this.cancelarTelaVendaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarTelaVendaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarTelaVendaBtn.ForeColor = System.Drawing.Color.White;
            this.cancelarTelaVendaBtn.Location = new System.Drawing.Point(856, 574);
            this.cancelarTelaVendaBtn.Name = "cancelarTelaVendaBtn";
            this.cancelarTelaVendaBtn.Size = new System.Drawing.Size(109, 74);
            this.cancelarTelaVendaBtn.TabIndex = 48;
            this.cancelarTelaVendaBtn.Text = "Cancelar";
            this.cancelarTelaVendaBtn.UseVisualStyleBackColor = false;
            this.cancelarTelaVendaBtn.Click += new System.EventHandler(this.cancelarTelaVendaBtn_Click);
            // 
            // finalizaVendaBtn
            // 
            this.finalizaVendaBtn.BackColor = System.Drawing.Color.Teal;
            this.finalizaVendaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finalizaVendaBtn.FlatAppearance.BorderSize = 0;
            this.finalizaVendaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finalizaVendaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalizaVendaBtn.ForeColor = System.Drawing.Color.White;
            this.finalizaVendaBtn.Location = new System.Drawing.Point(683, 577);
            this.finalizaVendaBtn.Name = "finalizaVendaBtn";
            this.finalizaVendaBtn.Size = new System.Drawing.Size(109, 71);
            this.finalizaVendaBtn.TabIndex = 45;
            this.finalizaVendaBtn.Text = "Finalizar Venda";
            this.finalizaVendaBtn.UseVisualStyleBackColor = false;
            this.finalizaVendaBtn.Click += new System.EventHandler(this.finalizaVendaBtn_Click_1);
            // 
            // valorTotalVendaLbl
            // 
            this.valorTotalVendaLbl.AutoSize = true;
            this.valorTotalVendaLbl.BackColor = System.Drawing.Color.Transparent;
            this.valorTotalVendaLbl.Font = new System.Drawing.Font("Arial", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorTotalVendaLbl.Location = new System.Drawing.Point(42, 577);
            this.valorTotalVendaLbl.Name = "valorTotalVendaLbl";
            this.valorTotalVendaLbl.Size = new System.Drawing.Size(371, 55);
            this.valorTotalVendaLbl.TabIndex = 44;
            this.valorTotalVendaLbl.Text = "VALOR TOTAL:";
            // 
            // consultaCarrinhoVendaGridView
            // 
            this.consultaCarrinhoVendaGridView.BackgroundColor = System.Drawing.Color.White;
            this.consultaCarrinhoVendaGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.consultaCarrinhoVendaGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.consultaCarrinhoVendaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consultaCarrinhoVendaGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_produtoEstoque,
            this.precoProdutoComDesconto,
            this.categoria,
            this.modelo,
            this.quantidade,
            this.preco,
            this.quantidade_estoque,
            this.dataVenda,
            this.desconto});
            this.consultaCarrinhoVendaGridView.GridColor = System.Drawing.Color.Gray;
            this.consultaCarrinhoVendaGridView.Location = new System.Drawing.Point(52, 177);
            this.consultaCarrinhoVendaGridView.Name = "consultaCarrinhoVendaGridView";
            this.consultaCarrinhoVendaGridView.ReadOnly = true;
            this.consultaCarrinhoVendaGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.consultaCarrinhoVendaGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.consultaCarrinhoVendaGridView.RowHeadersVisible = false;
            this.consultaCarrinhoVendaGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.consultaCarrinhoVendaGridView.Size = new System.Drawing.Size(901, 372);
            this.consultaCarrinhoVendaGridView.TabIndex = 43;
            this.consultaCarrinhoVendaGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.consultaCarrinhoVendaGridView_CellDoubleClick);
            // 
            // id_produtoEstoque
            // 
            this.id_produtoEstoque.HeaderText = "Id Produto no Estoque";
            this.id_produtoEstoque.Name = "id_produtoEstoque";
            this.id_produtoEstoque.ReadOnly = true;
            // 
            // precoProdutoComDesconto
            // 
            this.precoProdutoComDesconto.HeaderText = "Preço da venda";
            this.precoProdutoComDesconto.Name = "precoProdutoComDesconto";
            this.precoProdutoComDesconto.ReadOnly = true;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // modelo
            // 
            this.modelo.HeaderText = "Modelo";
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            // 
            // preco
            // 
            this.preco.HeaderText = "Preço";
            this.preco.Name = "preco";
            this.preco.ReadOnly = true;
            // 
            // quantidade_estoque
            // 
            this.quantidade_estoque.HeaderText = "Quantidade No Estoque";
            this.quantidade_estoque.Name = "quantidade_estoque";
            this.quantidade_estoque.ReadOnly = true;
            // 
            // dataVenda
            // 
            this.dataVenda.HeaderText = "Data da Venda";
            this.dataVenda.Name = "dataVenda";
            this.dataVenda.ReadOnly = true;
            // 
            // desconto
            // 
            this.desconto.HeaderText = "Desconto %";
            this.desconto.Name = "desconto";
            this.desconto.ReadOnly = true;
            // 
            // nomeClienteVendaTbx
            // 
            this.nomeClienteVendaTbx.Enabled = false;
            this.nomeClienteVendaTbx.Location = new System.Drawing.Point(138, 22);
            this.nomeClienteVendaTbx.Multiline = true;
            this.nomeClienteVendaTbx.Name = "nomeClienteVendaTbx";
            this.nomeClienteVendaTbx.Size = new System.Drawing.Size(275, 27);
            this.nomeClienteVendaTbx.TabIndex = 37;
            // 
            // localizaClienteBtn
            // 
            this.localizaClienteBtn.BackColor = System.Drawing.Color.Teal;
            this.localizaClienteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.localizaClienteBtn.FlatAppearance.BorderSize = 0;
            this.localizaClienteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.localizaClienteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localizaClienteBtn.ForeColor = System.Drawing.Color.White;
            this.localizaClienteBtn.Image = global::LojaArtigosEsportivos.Properties.Resources.LUPAPEQUENA16x16;
            this.localizaClienteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.localizaClienteBtn.Location = new System.Drawing.Point(419, 20);
            this.localizaClienteBtn.Name = "localizaClienteBtn";
            this.localizaClienteBtn.Size = new System.Drawing.Size(91, 33);
            this.localizaClienteBtn.TabIndex = 38;
            this.localizaClienteBtn.Text = "Buscar";
            this.localizaClienteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.localizaClienteBtn.UseVisualStyleBackColor = false;
            this.localizaClienteBtn.Click += new System.EventHandler(this.localizaClienteBtn_Click_1);
            // 
            // nomeClienteVendaLbl
            // 
            this.nomeClienteVendaLbl.AutoSize = true;
            this.nomeClienteVendaLbl.BackColor = System.Drawing.Color.Transparent;
            this.nomeClienteVendaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeClienteVendaLbl.Location = new System.Drawing.Point(3, 25);
            this.nomeClienteVendaLbl.Name = "nomeClienteVendaLbl";
            this.nomeClienteVendaLbl.Size = new System.Drawing.Size(127, 18);
            this.nomeClienteVendaLbl.TabIndex = 34;
            this.nomeClienteVendaLbl.Text = "Nome Cliente *:";
            // 
            // NovaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LojaArtigosEsportivos.Properties.Resources.Blue_Abstract_Background_Design;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1023, 728);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.efetuaVendaLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NovaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
            this.Load += new System.EventHandler(this.NovaVenda_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NovaVenda_MouseClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panielAtributosVenda.ResumeLayout(false);
            this.panielAtributosVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultaProdutoVendaGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaCarrinhoVendaGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label efetuaVendaLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelarTelaVendaBtn;
        private System.Windows.Forms.Button finalizaVendaBtn;
        private System.Windows.Forms.Label valorTotalVendaLbl;
        private System.Windows.Forms.DataGridView consultaCarrinhoVendaGridView;
        private System.Windows.Forms.TextBox nomeClienteVendaTbx;
        private System.Windows.Forms.Button localizaClienteBtn;
        private System.Windows.Forms.Label nomeClienteVendaLbl;
        private System.Windows.Forms.Label avisoLbl;
        private System.Windows.Forms.Button excluirCarrinhoBtn;
        private System.Windows.Forms.Label dataVendaLbl;
        private System.Windows.Forms.TextBox dataVendaTbx;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_produtoEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoProdutoComDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade_estoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn desconto;
        private System.Windows.Forms.Label valorTotalVendaReaisLbl;
        private System.Windows.Forms.TextBox produtoTbx;
        private System.Windows.Forms.Label produtoLbl;
        private System.Windows.Forms.DataGridView consultaProdutoVendaGridView;
        private System.Windows.Forms.Panel panielAtributosVenda;
        private System.Windows.Forms.TextBox precoProdVendaTbx;
        private System.Windows.Forms.TextBox descontoVendaTbx;
        private System.Windows.Forms.TextBox quantidadeVendaTbx;
        private System.Windows.Forms.Label precoProdutoLbl;
        private System.Windows.Forms.Label descontoLbl;
        private System.Windows.Forms.Label quantidadeLbl;
        private System.Windows.Forms.ComboBox formaPagamentoCbx;
        private System.Windows.Forms.Label formaPagamentoLbl;
        private System.Windows.Forms.Button novoProdutoBtn;
    }
}