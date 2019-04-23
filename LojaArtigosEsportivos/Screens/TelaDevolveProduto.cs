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
    public partial class TelaDevolveProduto : Form
    {
        public TelaDevolveProduto()
        {
            InitializeComponent();
        }
        public LocalizaDevolucao localizaDevolucao;
        public TelaDevolveProduto(LocalizaDevolucao localizaDevolucao)
        {
            InitializeComponent();
            this.localizaDevolucao = localizaDevolucao;
        }
        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (ValidaQtd(localizaDevolucao.venda.produtosVenda.QtdProduto, Convert.ToInt32(quantidadeDevolvidaTbx.Text)))
            {
                DALVenda dALVenda = new DALVenda();
                dALVenda.Devolucao(localizaDevolucao.venda, Convert.ToInt32(quantidadeDevolvidaTbx.Text),localizaDevolucao.valorTotal);
                MessageBox.Show("Produto devolvido!", "Aviso", MessageBoxButtons.OK);
                localizaDevolucao.venda.produtosVenda.IdProduto = 0;
                Dispose();
            }
            else
            {
                MessageBox.Show("Quantidade Invalida!","Aviso", MessageBoxButtons.OK);
            }
           
        }

        private bool ValidaQtd(int qtdProduto,int qtdDevolucao)
        {
            if(qtdDevolucao > qtdProduto)
            {
                return false;
            }          
            if (qtdDevolucao == 0)
            {
                return false;
            }

            return true;
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void TelaDevolveProduto_Load(object sender, EventArgs e)
        {
         
        }
    }
}
