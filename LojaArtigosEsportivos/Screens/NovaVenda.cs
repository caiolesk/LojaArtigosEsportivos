using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace LojaArtigosEsportivos
{
    public partial class NovaVenda : Form
    {
        public NovaVenda()
        {
            InitializeComponent();

            dataVendaTbx.Text = DateTime.Now.ToShortDateString();
        }
        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        private int codigoProduto;
        public int quantidadeProduto;
        public decimal descontoValorProduto;
        public decimal precoProduto;

        public Produto produto = new Produto();
        public decimal precoProdDesconto = 0;
        LocalizaCliente localizaCliente = null;
       
        CadastroDeProduto cadastroDeProduto = null;

        MySqlConnection conn = new Conexao().ObjetoConexao();

        void cadastroDeProduto_Disposed(object sender, EventArgs e)
        {
            cadastroDeProduto = null;
        }
        void localizaCliente_Disposed(object sender, EventArgs e)
        {
            localizaCliente = null;
        }
       

        public decimal precoAtualVenda;
        private decimal _qtdProdutoEstoque;
        private int _idProdutoEstoque = 0;
        private decimal _qtdAtualizadaEstoque = 0;

        public void ClienteNoTextBox()
        {
            nomeClienteVendaTbx.Text = NomeCliente;

        }
        public void ProdutoNoGrid(Produto produto, Decimal precoProdDesconto, string dataVenda, decimal descontoValorProduto)
        {
            consultaCarrinhoVendaGridView.Rows.Add(produto.IdProduto, precoProdDesconto, produto.Categoria, produto.Modelo, quantidadeProduto, produto.Preco, produto.Quantidade, dataVenda, descontoValorProduto);

        }

        public void LiberaFinalizarBtn()
        {
            finalizaVendaBtn.Enabled = true;
        }
        public decimal getPrecoAtual()
        {
            decimal preco = Convert.ToDecimal(valorTotalVendaReaisLbl.Text);

            return preco;
        }
        public void setValoTotalVenda(decimal precoAtual, decimal precoProdDesconto)
        {
            DALVenda dALVenda = new DALVenda();
            valorTotalVendaReaisLbl.Text = Convert.ToString(dALVenda.calculaPrecoVendaTotal(precoAtual, precoProdDesconto));
        }
        private void adcCarrinhoVendaBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void qtdVendaTbx_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        void LimpaCampos()
        {
            nomeClienteVendaTbx.Clear();
            consultaCarrinhoVendaGridView.ClearSelection();
            consultaCarrinhoVendaGridView.Rows.Clear();
            consultaCarrinhoVendaGridView.DataSource = null;
            formaPagamentoCbx.SelectedIndex = -1;
            produtoTbx.Clear();
            NomeCliente = null;
            IdCliente = 0;
            _idProdutoEstoque = 0;
            valorTotalVendaReaisLbl.Text = "0";
        }
        private void finalizaVendaBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                ValidarCamposVenda validarCamposVenda = new ValidarCamposVenda();
                Venda venda = new Venda();
               // ProdutosVenda produtosVenda
                DALVenda dALVenda = new DALVenda();
                List<ProdutosVenda> produtosDaVenda = new List<ProdutosVenda>();
                venda.NomeCliente = this.NomeCliente;
                venda.IdCliente = IdCliente;
                venda.ValorTotal = Convert.ToDecimal(valorTotalVendaReaisLbl.Text);
                venda.DataVenda = Convert.ToDateTime(dataVendaTbx.Text);
                venda.FormaPagamento = formaPagamentoCbx.Text;

                if (validarCamposVenda.ValidarCampos(venda) == 0)
                {
                    dALVenda.Inserir(venda);

                    for (int i = 0; i < (consultaCarrinhoVendaGridView.Rows.Count - 1); i++)
                    {
                        DataGridViewRow row = consultaCarrinhoVendaGridView.Rows[i];
                        venda.produtosVenda.Categoria = Convert.ToString(row.Cells["categoria"].Value);
                        venda.produtosVenda.Modelo = Convert.ToString(row.Cells["modelo"].Value);
                        venda.produtosVenda.QtdProduto = Convert.ToInt32(row.Cells["quantidade"].Value);
                        venda.produtosVenda.PrecoUnitario = Convert.ToDecimal(row.Cells["preco"].Value);
                        venda.produtosVenda.PrecoVenda = Convert.ToDecimal(row.Cells["precoProdutoComDesconto"].Value);
                        venda.produtosVenda.Desconto = Convert.ToDecimal(row.Cells["desconto"].Value);
                        _qtdProdutoEstoque = Convert.ToInt32(row.Cells["quantidade_estoque"].Value);
                        _idProdutoEstoque = Convert.ToInt32(row.Cells["id_produtoEstoque"].Value);
                        venda.produtosVenda.IdProduto = _idProdutoEstoque;

                        _qtdAtualizadaEstoque = Convert.ToInt32(_qtdProdutoEstoque - venda.produtosVenda.QtdProduto);

                        dALVenda.InserirProdutos(venda);
                        dALVenda.AtualizarEstoque(_qtdAtualizadaEstoque, _idProdutoEstoque);

                        produtosDaVenda.Add(new ProdutosVenda(venda.produtosVenda));
                    }

                    MessageBox.Show("Venda finalizada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    Form1 form1 = new Form1(produtosDaVenda);
                    form1.Show();
                    //LimpaCampos();
                    //venda.produtosVenda.clear();
                }
                else
                {
                    switch (validarCamposVenda.ValidarCampos(venda))
                    {
                        case 1:
                            MessageBox.Show("Cliente é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        case 3:
                            MessageBox.Show("Forma de pagamento é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        case 2:
                            MessageBox.Show("Selecionar pelo menos um produto na venda!", "Aviso", MessageBoxButtons.OK);
                            break;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelarTelaVendaBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void localizaClienteBtn_Click_1(object sender, EventArgs e)
        {
            if (localizaCliente == null)
            {
                localizaCliente = new LocalizaCliente(this);
                localizaCliente.Disposed += new EventHandler(localizaCliente_Disposed);
                localizaCliente.Show();
            }


        }


        private void produtoVendaLbl_Click_1(object sender, EventArgs e)
        {

        }

        private void valorTotalVendaLbl_Click_1(object sender, EventArgs e)
        {

        }



        private void NovaVenda_Load_1(object sender, EventArgs e)
        {

        }







        private void NovaVenda_Load(object sender, EventArgs e)
        {

        }

        private void qtdVendaTbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void consultaCarrinhoVendaGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0)
                {
                    codigoProduto = Convert.ToInt32(consultaCarrinhoVendaGridView.Rows[e.RowIndex].Cells[0].Value);
                    //this.Close();
                    MessageBox.Show("Produto selecionado!", "Aviso", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Operação inválida!");
            }
        }

        private void excluirCarrinhoBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (codigoProduto != 0)
                {


                    for (int i = 0; i < (consultaCarrinhoVendaGridView.Rows.Count - 1); i++)
                    {
                        DALVenda dALVenda = new DALVenda();
                        DataGridViewRow row = consultaCarrinhoVendaGridView.Rows[i];
                        int idProduto;
                        decimal valorProduto;

                        idProduto = Convert.ToInt32(row.Cells["id_produtoEstoque"].Value);
                        valorProduto = Convert.ToDecimal(row.Cells["precoProdutoComDesconto"].Value);
                        if (codigoProduto == idProduto)
                        {
                            consultaCarrinhoVendaGridView.Rows.Remove(consultaCarrinhoVendaGridView.Rows[i]);

                            valorTotalVendaReaisLbl.Text = Convert.ToString(dALVenda.calculaValorTotalExclusaoProdCarrinho(valorProduto, Convert.ToDecimal(valorTotalVendaReaisLbl.Text)));
                        }



                    }
                    codigoProduto = 0;
                }
                else
                {
                    MessageBox.Show("Produto não selecionado!");
                }
            }
            catch
            {
                MessageBox.Show("Operação inválida!");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void descontoTbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void localizarProdutoBtn_Click(object sender, EventArgs e)
        {
  
        }

        private void produtoTbx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                consultaProdutoVendaGridView.Visible = true;
                panielAtributosVenda.Visible = true;
                novoProdutoBtn.Visible = true;
                DALProduto dALProduto = new DALProduto();

                consultaProdutoVendaGridView.DataSource = dALProduto.LocalizaPorModelo(produtoTbx.Text);
                alterarNomesCulunasGridViewProduto();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void alterarNomesCulunasGridViewProduto()
        {
            consultaProdutoVendaGridView.Columns[0].HeaderText = "ID Produto";
            consultaProdutoVendaGridView.Columns[1].HeaderText = "Modelo";
            consultaProdutoVendaGridView.Columns[2].HeaderText = "Preço Unitário";
            consultaProdutoVendaGridView.Columns[3].HeaderText = "Quantidade";
            consultaProdutoVendaGridView.Columns[4].HeaderText = "Descrição";
            consultaProdutoVendaGridView.Columns[5].HeaderText = "Categoria";
            consultaProdutoVendaGridView.Columns[6].HeaderText = "Marca";
            consultaProdutoVendaGridView.Columns[7].HeaderText = "Nome Fornecedor";

            consultaProdutoVendaGridView.AutoResizeColumns();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            consultaProdutoVendaGridView.Visible = false;
            panielAtributosVenda.Visible = false;
            novoProdutoBtn.Visible = false;
        }

        private void NovaVenda_MouseClick(object sender, MouseEventArgs e)
        {
            consultaProdutoVendaGridView.Visible = false;
            panielAtributosVenda.Visible = false;
            novoProdutoBtn.Visible = false;
        }

        private void consultaProdutoVendaGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            adcProdutoNoCarrinho();
        }

        private bool LiberaSelecao()
        {
            if (string.IsNullOrEmpty(quantidadeVendaTbx.Text))
            {
                return false;
            }
            if (Convert.ToInt32(quantidadeVendaTbx.Text) == 0)
            {
                return false;
            }
            return true;
        }

        private void consultaProdutoVendaGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void consultaProdutoVendaGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void consultaProdutoVendaGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void consultaProdutoVendaGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0)
                {
                    produto.IdProduto = Convert.ToInt32(consultaProdutoVendaGridView.Rows[e.RowIndex].Cells[0].Value);
                    produto.Modelo = Convert.ToString(consultaProdutoVendaGridView.Rows[e.RowIndex].Cells[1].Value);
                    produto.Preco = Convert.ToDecimal(consultaProdutoVendaGridView.Rows[e.RowIndex].Cells[2].Value);
                    produto.Quantidade = Convert.ToInt32(consultaProdutoVendaGridView.Rows[e.RowIndex].Cells[3].Value);
                    produto.Descricao = Convert.ToString(consultaProdutoVendaGridView.Rows[e.RowIndex].Cells[4].Value);
                    produto.Categoria = Convert.ToString(consultaProdutoVendaGridView.Rows[e.RowIndex].Cells[5].Value);
                    produto.Marca = Convert.ToString(consultaProdutoVendaGridView.Rows[e.RowIndex].Cells[6].Value);

                    quantidadeVendaTbx.Enabled = true;
                    descontoVendaTbx.Enabled = true;
                    precoProdVendaTbx.Enabled = true;
                    precoProdVendaTbx.Text = Convert.ToString(produto.Preco);
                    //this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Operacao Invalida!");
            }

        }

        private void consultaProdutoVendaGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                adcProdutoNoCarrinho();
            }
        }



        private void adcProdutoNoCarrinho()
        {
            try
            {


                decimal precoProdDesconto = 0;
                decimal descontoValorProduto = 0;
                decimal precoAtual = 0;
                string dataVenda = DateTime.Now.ToShortDateString();



                DALVenda dALVenda = new DALVenda();
                if (produto.IdProduto != 0)
                {
                    if (!(Convert.ToInt32(descontoVendaTbx.Text) == 0))
                    {
                        precoProdDesconto = dALVenda.calculaPrecoDesconto(Convert.ToInt32(quantidadeVendaTbx.Text), produto.Preco, Convert.ToDecimal(descontoVendaTbx.Text));
                    }
                    else
                    {
                        precoProdDesconto = dALVenda.calculaPrecoVendaSemDesconto(Convert.ToInt32(quantidadeVendaTbx.Text), produto.Preco);
                    }
                    if (LiberaSelecao() == true)
                    {
                        if (Convert.ToInt32(quantidadeVendaTbx.Text) <= produto.Quantidade)
                        {
                            quantidadeProduto = Convert.ToInt32(quantidadeVendaTbx.Text);
                            descontoValorProduto = Convert.ToDecimal(descontoVendaTbx.Text);

                            consultaCarrinhoVendaGridView.Rows.Add(produto.IdProduto, precoProdDesconto, produto.Categoria, produto.Modelo, quantidadeProduto, produto.Preco, produto.Quantidade, dataVenda, descontoValorProduto);

                            precoAtual = getPrecoAtual();
                            setValoTotalVenda(precoAtual, precoProdDesconto);
                            finalizaVendaBtn.Enabled = true;
                            produto.clear();
                            consultaProdutoVendaGridView.Visible = false;
                            panielAtributosVenda.Visible = false;
                            novoProdutoBtn.Visible = false;
                            quantidadeVendaTbx.Text = "1";
                            descontoVendaTbx.Text = "0";
                            precoProdVendaTbx.Clear();
                        }
                        else
                        {
                            MessageBox.Show("A quantidade escolhida é maior que contida no estoque Produto: " + produto.Modelo + "/Quantidade: " + produto.Quantidade, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("A quantidade é inválida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                /* else
                 {
                     MessageBox.Show("Produto nao selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void novoProdutoBtn_Click(object sender, EventArgs e)
        {
            if (cadastroDeProduto == null)
            {
                cadastroDeProduto = new CadastroDeProduto();
                cadastroDeProduto.Disposed += new EventHandler(cadastroDeProduto_Disposed);
                cadastroDeProduto.Show();
            }

        }

        private void quantidadeVendaTbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                adcProdutoNoCarrinho();
            }
        }

        private void descontoVendaTbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                adcProdutoNoCarrinho();
            }
        }

        private void precoProdVendaTbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                adcProdutoNoCarrinho();
            }
        }
    }
}

