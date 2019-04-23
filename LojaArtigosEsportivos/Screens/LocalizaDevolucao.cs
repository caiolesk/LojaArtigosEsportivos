using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaArtigosEsportivos
{
    public partial class LocalizaDevolucao : Form
    {
        public LocalizaDevolucao()
        {
            InitializeComponent();
        }
        private int _codigoVenda = 0;
        MySqlConnection conn = new Conexao().ObjetoConexao();
        public Venda venda = new Venda();
        TelaDevolveProduto telaDevolveProduto = null;
        public decimal valorTotal = 0;
        void telaDevolveProduto_Disposed_1(object sender, EventArgs e)
        {
            telaDevolveProduto = null;
        }
        private void cancelarTelaDevolverBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void pesquisarVendaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DALVenda dALVenda = new DALVenda();

                if (!string.IsNullOrEmpty(tipoPesquisaCbx.Text))
                {
                    if (tipoPesquisaCbx.Text == "Nome")
                    {
                        vendasDevolucaoGridView.DataSource = dALVenda.PesquisarPorNomeCliente(pesquisaVendaMskBx.Text);
                        alterarNomesCulunasGridView();
                    }
                    if (tipoPesquisaCbx.Text == "Data")
                    {
                        vendasDevolucaoGridView.DataSource = dALVenda.PesquisarPorData(Convert.ToDateTime(pesquisaVendaMskBx.Text));
                        alterarNomesCulunasGridView();
                    }
                }
                else
                {
                    MessageBox.Show("Escolher o tipo de pesquisa!", "Aviso", MessageBoxButtons.OK);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void alterarNomesCulunasGridView()
        {
            vendasDevolucaoGridView.Columns[0].HeaderText = "ID Venda";
            vendasDevolucaoGridView.Columns[1].HeaderText = "Nome Cliente";
            vendasDevolucaoGridView.Columns[2].HeaderText = "CPF";
            vendasDevolucaoGridView.Columns[3].HeaderText = "Valor Total";
            vendasDevolucaoGridView.Columns[4].HeaderText = "Forma Pagamento";
            vendasDevolucaoGridView.Columns[5].HeaderText = "Data Venda";
        }

        private void vendasDevolucaoGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0)
                {

                    _codigoVenda = Convert.ToInt32(vendasDevolucaoGridView.Rows[e.RowIndex].Cells[0].Value);
                    valorTotal = Convert.ToInt32(vendasDevolucaoGridView.Rows[e.RowIndex].Cells[3].Value);
                    //this.Close();
                    venda.produtosVenda.IdProduto = 0;
                    DALVenda dALVenda = new DALVenda();
                    produtosDevolucaoGridView.DataSource = dALVenda.PesquisarProdutosVenda(Convert.ToString(_codigoVenda));
                    alterarNomesCulunasGridViewProdutos();
                }
            }
            catch
            {
                MessageBox.Show("Operação inválida!");
            }
        }

        public void alterarNomesCulunasGridViewProdutos()
        {
            produtosDevolucaoGridView.Columns[0].HeaderText = "Modelo";
            produtosDevolucaoGridView.Columns[1].HeaderText = "Categoria";
            produtosDevolucaoGridView.Columns[2].HeaderText = "Quantidade";
            produtosDevolucaoGridView.Columns[3].HeaderText = "Preço da Venda";
            produtosDevolucaoGridView.Columns[4].HeaderText = "Desconto %";
            produtosDevolucaoGridView.Columns[5].HeaderText = "Preço Unitario Produto";
            produtosDevolucaoGridView.Columns[6].HeaderText = "ID Compra";
            produtosDevolucaoGridView.Columns[7].HeaderText = "ID Produto";

            produtosDevolucaoGridView.AutoResizeColumns();

        }

        private void tipoPesquisaCbx_TextChanged(object sender, EventArgs e)
        {
            if (tipoPesquisaCbx.Text == "Nome")
            {
                pesquisaVendaMskBx.Size = new Size(100, 31);
                pesquisaVendaMskBx.Mask = "";
            }
            if (tipoPesquisaCbx.Text == "Data")
            {
                pesquisaVendaMskBx.Size = new Size(62, 31);
                pesquisaVendaMskBx.Mask = "00-00-0000";
            }
        }

        private void produtosDevolucaoGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0)
                {
                    venda.IdCompra = Convert.ToInt32(produtosDevolucaoGridView.Rows[e.RowIndex].Cells[6].Value);
                    venda.produtosVenda.Modelo = Convert.ToString(produtosDevolucaoGridView.Rows[e.RowIndex].Cells[0].Value);
                    venda.produtosVenda.QtdProduto = Convert.ToInt32(produtosDevolucaoGridView.Rows[e.RowIndex].Cells[2].Value);
                    venda.produtosVenda.IdProduto = Convert.ToInt32(produtosDevolucaoGridView.Rows[e.RowIndex].Cells[7].Value);
                    venda.produtosVenda.IdCompra = Convert.ToInt32(produtosDevolucaoGridView.Rows[e.RowIndex].Cells[6].Value);
                    venda.produtosVenda.PrecoVenda = Convert.ToInt32(produtosDevolucaoGridView.Rows[e.RowIndex].Cells[3].Value);
                    

                    //this.Close();           
                    MessageBox.Show("Produto Selecionado!", "Aviso!", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void devolverProdBtn_Click(object sender, EventArgs e)
        {
            if (!(venda.produtosVenda.IdProduto == 0))
            {
                if (telaDevolveProduto == null)
                {
                    telaDevolveProduto = new TelaDevolveProduto(this);
                    telaDevolveProduto.Disposed += new EventHandler(telaDevolveProduto_Disposed_1);
                    telaDevolveProduto.Show();
                }
            }
            else
            {
                MessageBox.Show("Selecionar Produto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
