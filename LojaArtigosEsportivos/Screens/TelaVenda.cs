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
    public partial class TelaVenda : Form
    {
        public TelaVenda()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new Conexao().ObjetoConexao();

        public int _codigoVenda;
        TelaRelatorioVenda telaRelatorioVenda = null;
        void telaRelatorioVenda_Disposed(object sender, EventArgs e)
        {
            telaRelatorioVenda = null;
        }
        private void novaVendaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if ((_codigoVenda != 0))
                {
                    if (telaRelatorioVenda == null)
                    {
                        telaRelatorioVenda = new TelaRelatorioVenda(this);
                        telaRelatorioVenda.Disposed += new EventHandler(telaRelatorioVenda_Disposed);
                        telaRelatorioVenda.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Tabela vazia ou venda não selecionada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }      
        }

        private void pesquisaVendaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DALVenda dALVenda = new DALVenda();


                if (string.IsNullOrEmpty(cpfPesqVendaMskBx.Text))
                {
                    consultaVendaGridView.DataSource = dALVenda.PesquisarPorNomeCliente(nomeClientePesqTbx.Text);
                    alterarNomesCulunasGridView();
                }
                else if(string.IsNullOrEmpty(nomeClientePesqTbx.Text))
                {
                    consultaVendaGridView.DataSource = dALVenda.PesquisarPorCpf(cpfPesqVendaMskBx.Text);
                    alterarNomesCulunasGridView();
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
            consultaVendaGridView.Columns[0].HeaderText = "ID Venda";
            consultaVendaGridView.Columns[1].HeaderText = "Nome Cliente";
            consultaVendaGridView.Columns[2].HeaderText = "CPF";
            consultaVendaGridView.Columns[3].HeaderText = "Valor Total";
            consultaVendaGridView.Columns[4].HeaderText = "Forma Pagamento";
            consultaVendaGridView.Columns[5].HeaderText = "Data Venda";

        }

        private void cancelarTelaVendaBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void consultaVendaGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0)
                {
                    _codigoVenda = Convert.ToInt32(consultaVendaGridView.Rows[e.RowIndex].Cells[0].Value);
;                    //this.Close();
                    MessageBox.Show("Venda selecionada!", "Aviso", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Operação inválida!");
            }
         
        }

        private void excluirVendaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if ((_codigoVenda != 0))
                {
                   
                    if (MessageBox.Show("Deseja realmente excluir isto?", "Cuidado!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {                      
                        DALVenda dALVenda = new DALVenda();
                        dALVenda.Excluir(_codigoVenda);
                        consultaVendaGridView.DataSource = dALVenda.Pesquisar();
                        _codigoVenda = 0;
                        MessageBox.Show("Venda excluída com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Operação cancelada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Tabela vazia ou venda não selecionada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TelaVenda_Load(object sender, EventArgs e)
        {

        }

        private void consultaVendaGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0)
                {
                    _codigoVenda = Convert.ToInt32(consultaVendaGridView.Rows[e.RowIndex].Cells[0].Value);
                    //this.Close();

                    DALVenda dALVenda = new DALVenda();
                    produtoVendaGridView.DataSource = dALVenda.PesquisarProdutosVenda(Convert.ToString(_codigoVenda));
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
            produtoVendaGridView.Columns[0].HeaderText = "Modelo";
            produtoVendaGridView.Columns[1].HeaderText = "Categoria";
            produtoVendaGridView.Columns[2].HeaderText = "Quantidade";
            produtoVendaGridView.Columns[3].HeaderText = "Preço da Venda";
            produtoVendaGridView.Columns[4].HeaderText = "Desconto %";
            produtoVendaGridView.Columns[5].HeaderText = "Preço Unitario Produto";
           
            produtoVendaGridView.AutoResizeColumns();

        }
    }
}
