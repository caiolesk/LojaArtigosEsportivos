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
    public partial class TelaClientesDoMes : Form
    {
        public TelaClientesDoMes()
        {
            InitializeComponent();
        }

        private void TelaClientesDoMes_Load(object sender, EventArgs e)
        {
            DALRelatorio dALRelatorio = new DALRelatorio();
            clienteDoMesGridView.DataSource = dALRelatorio.PesquisarClientesDoMes();
            alterarNomesCulunasGridView();
        }

        public void alterarNomesCulunasGridView()
        {
            clienteDoMesGridView.Columns[0].HeaderText = "Data Nascimento";
            clienteDoMesGridView.Columns[1].HeaderText = "Nome Cliente";
            clienteDoMesGridView.Columns[2].HeaderText = "CPF";
            clienteDoMesGridView.Columns[3].HeaderText = "Email";
           
            clienteDoMesGridView.AutoResizeColumns();

        }

        private void sairTelaAniversariantesBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
